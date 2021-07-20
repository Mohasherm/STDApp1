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
    public partial class RegTestFrm : Form
    {
        RegisterTest model = new RegisterTest();
        STDEntities dbContext = new STDEntities();
        public RegTestFrm()
        {
            InitializeComponent();
        }


        private void RegTestFrm_FormClosing(object sender, EventArgs e)
        {
            dbContext.Dispose();
        }
        private void RegTestFrm_Load(object sender, EventArgs e)
        {
            registerTestBindingSource.DataSource = dbContext.RegisterTest.Where(a => a.Test_Id == -1).ToList();

            GridViewTextBoxColumn txtstudent = new GridViewTextBoxColumn("StudentName");
            txtstudent.ReadOnly = true;
            txtstudent.FieldName = "Student.Name";
            txtstudent.Name = "Student.Name";
            txtstudent.PinPosition = PinnedColumnPosition.Left;
            txtstudent.HeaderText = "الطالب";
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

           // AddBtn.Text = "إضافة";
            model.ID = 0;

        }

        void PopulateDataGridView()
        {

            var x = Convert.ToInt32(radDroptestperiod.SelectedValue);
            //var z = Convert.ToInt32(radDropSubject.SelectedValue);
            var v = Convert.ToInt32(radDropDepartment.SelectedValue);
            dbContext.RegisterTest.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                registerTestBindingSource.DataSource = dbContext.RegisterTest
                          .Where(a => a.Test_Id == x && a.Student.Department_Id == v).ToList();               
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            registerTestBindingSource.DataSource = dbContext.RegisterTest.Where(a => a.Test_Id == -1).ToList();
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
            if (radDropclasses.SelectedIndex == -1 || radDropDepartment.SelectedIndex == -1 || radDroptestperiod.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الصف والفصل وفترة الاختبار");
            }
            else
            {
                radGridView1.AutoGenerateColumns = false;
                var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                var y = Convert.ToInt32(radDroptestperiod.SelectedValue);
                // var z = Convert.ToInt32(radDropSubject.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    List<int> result = db.RegisterTest
                        .Where(a => a.Test_Id == y)
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
       

        string msg = "";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            msg = "";

            if (radDropSubject.SelectedIndex == -1)
            {
                msg = "- اختر المادة ";
            }
            if (radDroptestperiod.SelectedIndex == -1)
            {
                msg = "- اختر فترة الاختبار ";
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
                            model.Test_Id = Convert.ToInt32(radDroptestperiod.SelectedValue);
                            model.Degree = (int)numdegree.Value;
                            model.Attend = chkattend.Checked;
                            model.IsEarly = false;
                            db.RegisterTest.Add(model);
                            db.SaveChanges();
                        }
                    }
                    model.ID = 0;
                    numdegree.Value = 0;
                    chkattend.Checked = false;                   
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

        private void MasterTemplate_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
                var result = dbContext.RegisterTest.Find(ID);
                dbContext.RegisterTest.Remove(result);
                dbContext.SaveChanges();
                Generate();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                Generate();
            }
        }

        private void MasterTemplate_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
            var result = (from x in dbContext.RegisterTest where x.ID == ID select x).FirstOrDefault();
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
            registerTestBindingSource.DataSource = dbContext.RegisterTest.Where(a => a.Test_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDroptestperiod.SelectedIndexChanged -= radDroptestperiod_SelectedIndexChanged;
            radDroptestperiod.DataSource = null;
            radDroptestperiod.SelectedIndex = -1;
            radDropSubject.SelectedIndex = -1;
            radDroptestperiod.SelectedIndexChanged += radDroptestperiod_SelectedIndexChanged;
        }

        private void radDropSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            registerTestBindingSource.DataSource = dbContext.RegisterTest.Where(a => a.Test_Id == -1).ToList();
            radGridView1.DataSource = null;
            if (radDropSubject.SelectedIndex != -1)
            {
                radDroptestperiod.ValueMember = "ID";
                radDroptestperiod.DisplayMember = "TimePeriod";
                var z = Convert.ToInt32(radDropSubject.SelectedValue);
                var v = Convert.ToInt32(radDropDepartment.SelectedValue);
                radDroptestperiod.SelectedIndexChanged -= radDroptestperiod_SelectedIndexChanged;
                radDroptestperiod.DataSource = dbContext.Test.Where(a => a.Department_Id == v && a.Subject_Id == z).ToList<Test>();
                radDroptestperiod.SelectedIndex = -1;
                radDroptestperiod.SelectedIndexChanged += radDroptestperiod_SelectedIndexChanged;
            }
        }

        private void radDroptestperiod_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Generate();
           
        }
    }
}
