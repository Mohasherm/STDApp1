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
    public partial class SubjectFrm : Form
    {
        Subject model = new Subject();
        public SubjectFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtsubject.Text = "";
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
                radGrid.DataSource = (from clas in db.Classes
                                      join sub in db.Subjects on clas.ID equals sub.Class_Id
                                      //where condtion if any                                             
                                      select new
                                      {
                                          //Column list here
                                          ID = sub.ID,
                                          Name = sub.Name,
                                          ClassId = clas.ID,
                                          ClassName = clas.Name
                                      }).ToList();
                radGrid.Refresh();

            }
            using (STDEntities db = new STDEntities())
            {
                ClassDropdownlist.DataSource = db.Classes.ToList<Class>();
                ClassDropdownlist.ValueMember = "ID";
                ClassDropdownlist.DisplayMember = "Name";
                ClassDropdownlist.SelectedIndex = -1;
            }
        }

        private void SubjectFrm_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtsubject.Text.Trim()))
            {
                msg += "- ادخل المادة ";
            }
            if (msg == "")
            {
                model.Name = txtsubject.Text.Trim();
                model.Class_Id = Convert.ToInt32(ClassDropdownlist.SelectedValue);
                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        if (IsSubjectAvailable(model.Name, model.Class_Id))
                        {
                            db.Subjects.Add(model);
                            //MessageBox.Show("تمت الإضافة بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن تكرار المادة");
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

        public bool IsSubjectAvailable(string name, int id)
        {
            using (STDEntities db = new STDEntities())
            {
                bool Subject = db.Subjects.Where(m => m.Class_Id == id).Where(x => x.Name == name).Any();

                return !Subject;

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
                        db.Subjects.Attach(model);
                    db.Subjects.Remove(model);
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
                            MessageBox.Show("يجب حذف البيانات الأسبوعية التابعة للمادة");
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
                    model = db.Subjects.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtsubject.Text = model.Name;
                    ClassDropdownlist.SelectedValue = model.Class_Id;
                }
                AddBtn.Text = "تعديل";
                DeleteBtn.Enabled = true;
            }
        }
    }
}
