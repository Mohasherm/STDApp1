using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDApp
{
    public partial class testFrm : Form
    {
        Test model = new Test();
        public testFrm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txttest.Text = "";
            radDroptestperiod.SelectedIndex = -1;
            datefinal.Value = DateTime.Now;          
            radDropSubject.SelectedIndex = -1;
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            AddBtn.Text = "إضافة";
            DeleteBtn.Enabled = false;
            model.ID = 0;
        }

        void PopulateDataGridView()
        {
            radGrid.AutoGenerateColumns = false;
            using (STDEntities db = new STDEntities())
            {
                radGrid.DataSource = (from test in db.Tests
                                      join dep in db.Departments on test.Department_Id equals dep.ID
                                      join clas in db.Classes on dep.Class_Id equals clas.ID
                                      join sub in db.Subjects on test.Subject_Id equals sub.ID
                                      //where condtion if any                                             
                                      select new
                                      {
                                          //Column list here
                                          ID = test.ID,
                                          TimePeriod = test.TimePeriod,
                                          FinalDate = test.FinalDate,
                                          Test = test.Test1,
                                          ClassId = dep.Class_Id,
                                          ClassName = clas.Name,
                                          DepartmentId = test.Department_Id,
                                          DepartmentName = dep.Name,
                                          SubjectId = test.Subject_Id,
                                          SubjectName = sub.Name
                                      }).ToList();
                radGrid.Refresh();

            }

            using (STDEntities db = new STDEntities())
            {
                radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Classes.ToList<Class>();
                radDropclasses.SelectedIndex = -1;
            }

        }

        private void testFrm_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.DataSource = db.Departments
                        .Where(dep => dep.Class_Id == x).ToList();
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;

                radDropSubject.DataSource = db.Subjects
                       .Where(sub => sub.Class_Id == x).ToList();
                radDropSubject.ValueMember = "ID";
                radDropSubject.DisplayMember = "Name";
                radDropSubject.SelectedIndex = -1;
            }
        }

        string msg = "";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            msg = "";
            if (radDropclasses.SelectedIndex == -1)
            {
                msg = "- اختر الصف ";
            }
            if (radDropDepartment.SelectedIndex == -1)
            {
                msg = "- اختر الفصل ";
            }
            if (radDropSubject.SelectedIndex == -1)
            {
                msg = "- اختر المادة ";
            }
            if (radDroptestperiod.SelectedIndex == -1)
            {
                msg = "- اختر فترة الاختبار ";
            }
            if (string.IsNullOrEmpty(txttest.Text.Trim()))
            {
                msg += "- ادخل الاختبار ";
            }
            if (msg == "")
            {
                model.Test1 = txttest.Text;
                model.TimePeriod = radDroptestperiod.SelectedItem.Text;
                model.FinalDate = datefinal.Text;
                model.Subject_Id = Convert.ToInt32(radDropSubject.SelectedValue);
                model.Department_Id = Convert.ToInt32(radDropDepartment.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        db.Tests.Add(model);
                        //MessageBox.Show("تمت الإضافة بنجاح");
                    }
                    else
                    {
                        db.Entry(model).State = EntityState.Modified;
                        //MessageBox.Show("تمت التعديل بنجاح");
                    }

                    db.SaveChanges();
                }
                clear();

                PopulateDataGridView();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (STDEntities db = new STDEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Tests.Attach(model);
                    db.Tests.Remove(model);
                    try
                    {
                        db.SaveChanges();
                        PopulateDataGridView();
                        clear();
                        MessageBox.Show("تم الحذف بنجاح");
                    }
                    catch (DbUpdateException ex)
                    {
                        if (ex.InnerException.Message.Equals("An error occurred while updating the entries. See the inner exception for details."))
                        {
                            MessageBox.Show("يجب حذف الطلاب الذين قاموا بانهاء هذا الإختبار");
                        }
                    }
                }
            }
        }

        private void radGrid_DoubleClick(object sender, EventArgs e)
        {
            if (radGrid.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(radGrid.CurrentRow.Cells["ID"].Value);
                using (STDEntities db = new STDEntities())
                {
                    model = db.Tests.Where(x => x.ID == model.ID).FirstOrDefault();
                    txttest.Text = model.Test1;
                    datefinal.Text = model.FinalDate;
                    radDroptestperiod.SelectedValue = model.TimePeriod;
                    radDropclasses.SelectedValue = Convert.ToInt32(radGrid.CurrentRow.Cells["ClassId"].Value);
                    radDropDepartment.SelectedValue = model.Department_Id;
                    radDropSubject.SelectedValue = model.Subject_Id;
                }
                AddBtn.Text = "تعديل";
                DeleteBtn.Enabled = true;
            }
        }
    }
}
