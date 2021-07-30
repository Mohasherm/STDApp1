using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace STDApp
{
    public partial class AbsenceFrm : Form
    {
        Absence model = new Absence();
        STDEntities dbContext = new STDEntities();
        public AbsenceFrm()
        {
            InitializeComponent();
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            absenceBindingSource.DataSource = dbContext.Absence.Where(a => a.ID == -1).ToList();
            radGridView1.DataSource = null;
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropSubject.SelectedIndexChanged -= radDropSubject_SelectedIndexChanged;
                radDropDepartment.DataSource = db.Department
                        .Where(dep => dep.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;

                //radDropSubject.SelectedIndexChanged -= radDropSubject_SelectedIndexChanged;
                radDropSubject.DataSource = db.Subject
                       .Where(sub => sub.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropSubject.ValueMember = "ID";
                radDropSubject.DisplayMember = "Name";
                radDropSubject.SelectedIndex = -1;
                radDropSubject.SelectedIndexChanged += radDropSubject_SelectedIndexChanged;
            }
        }

        private void AbsenceFrm_Load(object sender, EventArgs e)
        {
            absenceBindingSource.DataSource = dbContext.Absence.Where(a => a.ID == -1).ToList();

            GridViewTextBoxColumn txtstudent = new GridViewTextBoxColumn("StudentName");
            txtstudent.ReadOnly = true;
            txtstudent.FieldName = "Student.Name";
            txtstudent.Name = "Student.Name";
            txtstudent.HeaderText = "الطالب";
            txtstudent.PinPosition = PinnedColumnPosition.Left;
            radGridView.Columns.Add(txtstudent);            
             radGridView.Columns[6].Width = 150;       
           // radGridView.BestFitColumns();


            using (STDEntities db = new STDEntities())
            {
               radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Class.ToList<Class>().OrderBy(a => a.ID);              
                radDropclasses.SelectedIndex = -1;
                db.Absence.Load();
            }
            date.ValueChanged -= date_ValueChanged;
            clear();
            date.ValueChanged += date_ValueChanged;
        }

        void clear()
        {           
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            date.Value = DateTime.Now;
            model.ID = 0;            
        }
        public void Generate()
        {
            if (radDropclasses.SelectedIndex == -1 || radDropDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الصف والفصل ");
            }
            else
            {
                radGridView1.AutoGenerateColumns = false;
                var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                var y =date.Text;
                var z = Convert.ToInt32(radDropSubject.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    List<int> result = db.Absence
                        .Where(a => a.Date == y && a.Subject_Id == z)
                        .Select(a => a.Student_Id).ToList();

                    radGridView1.DataSource = (from std in db.Student.Where(c => !result.Contains(c.ID))
                                               where std.Department_Id == x
                                               select new
                                               {
                                                   //Column list here
                                                   ID = std.ID,
                                                   Name = std.Name,
                                                   DepartmentId = std.Department_Id,
                                                   DepartmentName = radDropDepartment.SelectedItem.Text
                                               }).ToList();
                    PopulateDataGridView();
                    radGridView.Columns[6].Width = 150;                   
                    radGridView.Columns[2].Width = 150;
                 
                }
            }
        }

        void PopulateDataGridView()
        {

            var x = date.Text;
            var z = Convert.ToInt32(radDropSubject.SelectedValue);
            var v = Convert.ToInt32(radDropDepartment.SelectedValue);
            dbContext.Absence.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                absenceBindingSource.DataSource = dbContext.Absence
                          .Where(a => a.Date == x && a.Student.Department_Id == v && a.Subject_Id ==z).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
       
        private void radDropSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            absenceBindingSource.DataSource = dbContext.Absence.Where(a => a.ID == -1).ToList();
            radGridView1.DataSource = null;
            date.Value = DateTime.Now;
            Generate();
        }

        string msg = "";
        private void AddBtn_Click(object sender, EventArgs e)
        {
            msg = "";

            if (radDropSubject.SelectedIndex == -1)
            {
                msg = " اختر المادة ";
            }
          


            if (msg == "")
            {

                if ( model.ID == 0)
                {
                    foreach (var data in radGridView1.SelectedRows)
                    {
                        using (STDEntities db = new STDEntities())
                        {                       
                            model.Date = date.Text;
                            model.Student_Id = Convert.ToInt32(data.Cells["ID"].Value);
                            model.Subject_Id = (int)radDropSubject.SelectedValue;
                            db.Absence.Add(model);
                            db.SaveChanges();

                        }
                    }                   
                    //MessageBox.Show("تمت الإضافة بنجاح");
                }
                Generate();
                PopulateDataGridView();
                radGridView.Refresh();
                model.ID = 0;
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void radGridView_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;               
                var result = dbContext.Absence.Where(a => a.ID == ID).FirstOrDefault();
                dbContext.Absence.Remove(result);
                dbContext.SaveChanges();
                Generate();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                Generate();
            }
        }

        private void radDropDepartment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            absenceBindingSource.DataSource = dbContext.Absence.Where(a => a.ID == -1).ToList();
            radGridView1.DataSource = null;
            radDropSubject.SelectedIndex = -1;           
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void AbsenceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbContext.Dispose();
        }
    }
}
