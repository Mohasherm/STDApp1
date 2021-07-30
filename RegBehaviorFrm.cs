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
    public partial class RegBehaviorFrm : Form
    {
        Behavior model = new Behavior();
        STDEntities dbContext = new STDEntities();
        
        public RegBehaviorFrm()
        {
            InitializeComponent();
        }
        void clear()
        {

            radDropSubject.SelectedIndex = -1;
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            radDropweek.SelectedIndex = -1;
            model.ID = 0;
        }

        void PopulateDataGridView()
        {

            var x = Convert.ToInt32(radDropweek.SelectedValue);
            var z = Convert.ToInt32(radDropSubject.SelectedValue);
            var v = Convert.ToInt32(radDropDepartment.SelectedValue);
            dbContext.Behavior.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                behaviorBindingSource.DataSource = dbContext.Behavior
                          .Where(a => a.Week_Id == x && a.Subject_Id == z && a.Student.Department_Id == v).ToList();                
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            
        }

        private void RegBehaviorFrm_Load(object sender, EventArgs e)
        {
            behaviorBindingSource.DataSource = dbContext.Behavior.Where(a => a.Week_Id == -1).ToList();

            GridViewTextBoxColumn txtstudent = new GridViewTextBoxColumn("StudentName");
            txtstudent.ReadOnly = true;
            txtstudent.FieldName = "Student.Name";
            txtstudent.Name = "Student.Name";
            txtstudent.HeaderText = "الطالب";
            txtstudent.PinPosition = PinnedColumnPosition.Left;
            radGridView.Columns.Add(txtstudent);
            radGridView.BestFitColumns();

            
            using (STDEntities db = new STDEntities())
            {
                radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Class.ToList<Class>().OrderBy(a => a.ID);
                radDropclasses.SelectedIndex = -1;

                db.Behavior.Load();

                radDropweek.SelectedIndexChanged -= radDropweek_SelectedIndexChanged;
                radDropweek.DataSource = db.Week.ToList<Week>().OrderBy(a => a.ID);
                radDropweek.ValueMember = "ID";
                radDropweek.DisplayMember = "Number";
                radDropweek.SelectedIndex = -1;
                radDropweek.SelectedIndexChanged += radDropweek_SelectedIndexChanged;
            }

            clear();
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            behaviorBindingSource.DataSource = dbContext.Behavior.Where(a => a.Week_Id == -1).ToList();
            radGridView1.DataSource = null;
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.SelectedIndexChanged -= radDropDepartment_SelectedIndexChanged;
                radDropDepartment.DataSource = db.Department
                        .Where(dep => dep.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;
                radDropDepartment.SelectedIndexChanged += radDropDepartment_SelectedIndexChanged;
                radDropSubject.SelectedIndexChanged -= radDropSubject_SelectedIndexChanged;
                radDropSubject.DataSource = db.Subject
                       .Where(sub => sub.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropSubject.ValueMember = "ID";
                radDropSubject.DisplayMember = "Name";
                radDropSubject.SelectedIndex = -1;
                radDropSubject.SelectedIndexChanged += radDropSubject_SelectedIndexChanged;
            }
        }

        void Generate()
        {
            if (radDropclasses.SelectedIndex == -1 || radDropDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الصف والفصل");
            }
            else
            {
                radGridView1.AutoGenerateColumns = false;
                var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                var y = Convert.ToInt32(radDropweek.SelectedValue);
                var z = Convert.ToInt32(radDropSubject.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    List<int> result = db.Behavior
                        .Where(a => a.Week_Id == y && a.Subject_Id == z && a.Student.Department_Id == x)
                        .Select(a => a.Sudent_Id).ToList();

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
                    radGridView.Columns[11].Width = 250;
                }
            }
        }
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
           
        }

        string msg = "";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            msg = "";

            if (radDropSubject.SelectedIndex == -1)
            {
                msg = "- اختر المادة ";
            }
            if (radDropweek.SelectedIndex == -1)
            {
                msg = "- اختر الاسبوع ";
            }


            if (msg == "")
            {

                if (model.ID == 0)
                {
                    foreach (var data in radGridView1.SelectedRows)
                    {
                        using (STDEntities db = new STDEntities())
                        {                           
                            model.Ok = (int)numok.Value;
                            model.Bad = (int)numbad.Value;
                            model.Sleep = (int)numsleep.Value;
                            model.GetBook = (int)numgetbook.Value;
                            model.Sudent_Id = Convert.ToInt32(data.Cells["ID"].Value);
                            model.Subject_Id = (int)radDropSubject.SelectedValue;
                            model.Week_Id = (int)radDropweek.SelectedValue;
                            db.Behavior.Add(model);
                            db.SaveChanges();
                        }
                    }
                    model.ID = 0;
                    numok.Value = 0;
                    numbad.Value = 0;
                    numsleep.Value = 0;
                    numgetbook.Value = 0;
                    //MessageBox.Show("تمت الإضافة بنجاح");
                }
                Generate();
                PopulateDataGridView();
                radGridView.Refresh();
               
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void radGridView_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
                var result = dbContext.Behavior.Find(ID);
                dbContext.Behavior.Remove(result);
                dbContext.SaveChanges();
                Generate();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                Generate();
            }
        }

        private void radGridView_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
            var result = (from x in dbContext.Behavior where x.ID == ID select x).FirstOrDefault();
            switch (e.ColumnIndex)
            {
                case 1:
                    result.Ok = (int)e.Value;
                    break;
                case 2:
                    result.Bad = (int)e.Value;
                    break;
                case 3:
                    result.Sleep = (int)e.Value;
                    break;
                case 4:
                    result.GetBook = (int)e.Value;
                    break;
                default:
                    break;
            }

            dbContext.SaveChanges();
        }

        private void radDropDepartment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            behaviorBindingSource.DataSource = dbContext.Behavior.Where(a => a.Week_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDropweek.SelectedIndex = -1;
            radDropSubject.SelectedIndex = -1;
        }

        private void radDropSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            behaviorBindingSource.DataSource = dbContext.Behavior.Where(a => a.Week_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDropweek.SelectedIndex = -1;
        }

        private void radDropweek_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Generate();
        }

        private void RegBehaviorFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbContext.Dispose();
        }
    }
}
