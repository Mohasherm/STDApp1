using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STDApp
{
    public partial class StudentFrm : Form
    {
        Student model = new Student();
        public StudentFrm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtcivilnumber.Text = "";
            txtname.Text = "";
            txtmobile.Text = "0";
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
                radGrid.DataSource = (from std in db.Student
                                      join dep in db.Department on std.Department_Id equals dep.ID
                                      join clas in db.Class on dep.Class_Id equals clas.ID
                                      //where condtion if any                                             
                                      select new
                                      {
                                          //Column list here
                                          ID = std.ID,
                                          Name = std.Name,
                                          Mobile = std.Mobile,
                                          CivilNumber = std.CivilNumber,
                                          ClassId = dep.Class_Id,
                                          ClassName = clas.Name,
                                          DepartmentId = std.Department_Id,
                                          DepartmentName = dep.Name
                                      }).ToList();
                radGrid.Refresh();

            }
            
            using (STDEntities db = new STDEntities())
            {
                radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Class.ToList<Class>().OrderBy(a => a.ID);               
                radDropclasses.SelectedIndex = -1;
            }       

        }

        private void txtcivilnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void StudentFrm_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
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
            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                msg += "- ادخل الاسم ";
            }
            if (string.IsNullOrEmpty(txtmobile.Text.Trim()) || txtmobile.Text.Trim() == "0" || txtmobile.TextLength < 10)
            {
                msg += "- ادخل جوال ولي الأمر ";
            }
            if (string.IsNullOrEmpty(txtcivilnumber.Text.Trim()) || txtcivilnumber.TextLength < 10)
            {
                msg += "- ادخل رقم الهوية ";
            }
            if (msg == "")
            {
                model.Name = txtname.Text.Trim();
                model.Mobile = txtmobile.Text.Trim();
                model.CivilNumber = txtcivilnumber.Text.Trim();
                model.Points = 0;
                model.Department_Id = Convert.ToInt32(radDropDepartment.SelectedValue);
                
                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        if (IsNameAvailable(model.Name))
                        {
                            db.Student.Add(model);
                            //MessageBox.Show("تمت الإضافة بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن تكرار الاسم");
                            return;
                        }

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

        public bool IsNameAvailable(string name)
        {
            using (STDEntities db = new STDEntities())
            {
                bool Number = db.Student.Where(m => m.Name == name).Any();

                return !Number;

            }
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
           
               using (STDEntities db = new STDEntities())
                {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.DataSource = db.Department
                        .Where(dep => dep.Class_Id == x).ToList().OrderBy(a => a.ID);
                    radDropDepartment.ValueMember = "ID";
                    radDropDepartment.DisplayMember = "Name";
                    radDropDepartment.SelectedIndex = -1;
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
                        db.Student.Attach(model);
                    db.Student.Remove(model);
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
                            MessageBox.Show("يجب حذف البيانات الأسبوعية التابعة للطالب");
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
                    model = db.Student.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtname.Text = model.Name;
                    txtmobile.Text = model.Mobile;
                    txtcivilnumber.Text = model.CivilNumber;
                    radDropclasses.SelectedValue = Convert.ToInt32(radGrid.CurrentRow.Cells["ClassId"].Value);
                    radDropDepartment.SelectedValue = model.Department_Id;
                }
                AddBtn.Text = "تعديل";
                DeleteBtn.Enabled = true;
            }
        }
    }
}
