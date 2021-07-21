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
    public partial class DepartmentFrm : Form
    {
        Department model = new Department();
        public DepartmentFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtdepartment.Text = "";
            ClassDropdownlist.SelectedIndex = -1;
            AddBtn.Text = "إضافة";
            DeleteBtn.Enabled = false;
            model.ID = 0;
        }


        void PopulateDataGridView()
        {
            radGrid.AutoGenerateColumns = false;
            using (STDEntities db = new STDEntities())
            {                
                radGrid.DataSource = (from clas in db.Class
                                      join dep in db.Department on clas.ID equals dep.Class_Id
                                      //where condtion if any                                             
                                      select new
                                      {
                                          //Column list here
                                          ID = dep.ID,
                                          Name = dep.Name,
                                          ClassId = clas.ID,
                                          ClassName = clas.Name
                                      }).ToList();
                radGrid.Refresh();

            }
            using (STDEntities db = new STDEntities())
            {
                ClassDropdownlist.DataSource = db.Class.ToList<Class>().OrderBy(a => a.ID);
                ClassDropdownlist.ValueMember = "ID";
                ClassDropdownlist.DisplayMember = "Name";
                ClassDropdownlist.SelectedIndex = -1;
            }
        }

        private void DepartmentFrm_Load(object sender, EventArgs e)
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
            if (ClassDropdownlist.SelectedIndex == -1)
            {
                msg = "- اختر الصف ";
            }
            if (string.IsNullOrEmpty(txtdepartment.Text.Trim()))
            {
                msg += "- ادخل الفصل ";
            }
            if (msg == "")
            {
                model.Name = txtdepartment.Text.Trim();
                model.Class_Id = Convert.ToInt32(ClassDropdownlist.SelectedValue);
                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        if (IsDepartmentAvailable(model.Name,model.Class_Id))
                        {
                            db.Department.Add(model);
                            //MessageBox.Show("تمت الإضافة بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن تكرار الفصل");
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

        public bool IsDepartmentAvailable(string name, int id)
        {
            using (STDEntities db = new STDEntities())
            {
                bool Department = db.Department.Where(m => m.Class_Id == id).Where(x => x.Name == name).Any();

                return !Department;

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
                        db.Department.Attach(model);
                    db.Department.Remove(model);
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
                            MessageBox.Show("يجب حذف طلاب الفصل اولا");
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
                    model = db.Department.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtdepartment.Text = model.Name;
                    ClassDropdownlist.SelectedValue = model.Class_Id;
                }
                AddBtn.Text = "تعديل";
                DeleteBtn.Enabled = true;

            }
        }
    }
}
