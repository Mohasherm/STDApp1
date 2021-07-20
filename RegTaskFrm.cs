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
    public partial class RegTaskFrm : Form
    {
        RegisterTask model = new RegisterTask();
        STDEntities dbContext = new STDEntities();
        public RegTaskFrm()
        {
            InitializeComponent();
        }

        private void RegTaskFrm_Load(object sender, EventArgs e)
        {
            registerTaskBindingSource.DataSource = dbContext.RegisterTask.Where(a => a.Task_Id == -1).ToList();

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
                radDropclasses.DataSource = db.Class.ToList<Class>();
                radDropclasses.SelectedIndex = -1;

                db.RegisterTest.Load();


            }

            clear();
        }

        void clear()
        {

            //   radDropSubject.SelectedIndex = -1;
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            // radDroptestperiod.SelectedIndex = -1;            
            model.ID = 0;
        }

        void PopulateDataGridView()
        {

            var x = Convert.ToInt32(radDropTaskTitle.SelectedValue);
            //var z = Convert.ToInt32(radDropSubject.SelectedValue);
            var v = Convert.ToInt32(radDropDepartment.SelectedValue);
            dbContext.RegisterTest.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                registerTaskBindingSource.DataSource = dbContext.RegisterTask
                          .Where(a => a.Task_Id == x && a.Student.Department_Id == v).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            registerTaskBindingSource.DataSource = dbContext.RegisterTask.Where(a => a.Task_Id == -1).ToList();
            radGridView1.DataSource = null;
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.DataSource = db.Department
                        .Where(dep => dep.Class_Id == x).ToList();
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;

                radDropSubject.SelectedIndexChanged -= radDropSubject_SelectedIndexChanged;
                radDropSubject.DataSource = db.Subject
                       .Where(sub => sub.Class_Id == x).ToList();
                radDropSubject.ValueMember = "ID";
                radDropSubject.DisplayMember = "Name";
                radDropSubject.SelectedIndex = -1;
               radDropSubject.SelectedIndexChanged += radDropSubject_SelectedIndexChanged;
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        void Generate()
        {
            if (radDropclasses.SelectedIndex == -1 || radDropDepartment.SelectedIndex == -1 || radDropTaskTitle.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الصف والفصل وعنوان المهمة");
            }
            else
            {
                radGridView1.AutoGenerateColumns = false;
                var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                var y = Convert.ToInt32(radDropTaskTitle.SelectedValue);
                // var z = Convert.ToInt32(radDropSubject.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    List<int> result = db.RegisterTask
                        .Where(a => a.Task_Id == y)
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
                    radGridView.Columns[8].Width = 150;
                }
            }
        }
        private void radDropSubject_Click(object sender, EventArgs e)
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
            if (radDropTaskTitle.SelectedIndex == -1)
            {
                msg = "- اختر عنوان المهمة ";
            }


            if (msg == "")
            {

                if (model.ID == 0)
                {
                    foreach (var data in radGridView1.SelectedRows)
                    {
                        using (STDEntities db = new STDEntities())
                        {

                            model.Student_Id = Convert.ToInt32(data.Cells["ID"].Value);
                            model.Task_Id = Convert.ToInt32(radDropTaskTitle.SelectedValue);
                            model.Degree = (int)numdegree.Value;
                            model.Attend = chkattend.Checked;
                            model.IsEarly = chkearly.Checked;
                            db.RegisterTask.Add(model);
                            db.SaveChanges();
                        }
                    }
                    model.ID = 0;
                    numdegree.Value = 0;
                    chkattend.Checked = false;
                    chkearly.Checked = false;
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

        private void radGridView_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
                var result = dbContext.RegisterTask.Find(ID);
                dbContext.RegisterTask.Remove(result);
                dbContext.SaveChanges();
                Generate();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                Generate();

            }
        }

        private void radGridView_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
            var result = (from x in dbContext.RegisterTask where x.ID == ID select x).FirstOrDefault();
            switch (e.ColumnIndex)
            {
                case 1:
                    result.Degree = (int)e.Value;
                    break;
                case 2:
                    result.Attend = (bool)e.Value;
                    break;
                case 3:
                    result.IsEarly = (bool)e.Value;
                    break;
                default:
                    break;
            }

            dbContext.SaveChanges();
        }

        private void radDropDepartment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            registerTaskBindingSource.DataSource = dbContext.RegisterTask.Where(a => a.Task_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDropTaskTitle.SelectedIndexChanged -= radDropTaskTitle_SelectedIndexChanged;
            radDropTaskTitle.DataSource = null;
            radDropTaskTitle.SelectedIndex = -1;
            radDropSubject.SelectedIndex = -1;
            radDropTaskTitle.SelectedIndexChanged += radDropTaskTitle_SelectedIndexChanged;
        }

        private void radDropSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            registerTaskBindingSource.DataSource = dbContext.RegisterTask.Where(a => a.Task_Id == -1).ToList();
            radGridView1.DataSource = null;
            if (radDropSubject.SelectedIndex != -1)
            {
                radDropTaskTitle.ValueMember = "ID";
                radDropTaskTitle.DisplayMember = "Title";
                var z = Convert.ToInt32(radDropSubject.SelectedValue);
                var v = Convert.ToInt32(radDropDepartment.SelectedValue);
                radDropTaskTitle.SelectedIndexChanged -= radDropTaskTitle_SelectedIndexChanged;
                radDropTaskTitle.DataSource = dbContext.Task.Where(a => a.Department_Id == v && a.Subject_Id == z).ToList<Task>();
                radDropTaskTitle.SelectedIndex = -1;
                radDropTaskTitle.SelectedIndexChanged += radDropTaskTitle_SelectedIndexChanged;
            }
        }

        private void radDropTaskTitle_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Generate();
        }

        private void RegTaskFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext.Dispose();
        }
    }
}
