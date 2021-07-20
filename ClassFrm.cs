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
    public partial class ClassFrm : Form
    {
        Class model = new Class();
        public ClassFrm()
        {
            InitializeComponent();
        }

        private void ClassFrm_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtclass.Text.Trim()))
            {
                model.Name = txtclass.Text.Trim();               
                    using (STDEntities db = new STDEntities())
                    {
                        if (model.ID == 0)
                        {
                             if (IsClassAvailable(model.Name))
                              {
                                  db.Class.Add(model);
                                 //MessageBox.Show("تمت الإضافة بنجاح");
                              }
                              else
                              {
                                     MessageBox.Show("لا يمكن تكرار اسم الصف");
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
                MessageBox.Show("أدخل الصف للإضافة");
            }

        }

        public bool IsClassAvailable(string name)
        {
            using (STDEntities db = new STDEntities())
            {
                bool Class = db.Class.Where(m => m.Name == name).Any();

                return !Class;

            }
        }

        private void RadGrid_DoubleClick(object sender, EventArgs e)
        {
            if (RadGrid.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(RadGrid.CurrentRow.Cells["ID"].Value);
                using (STDEntities db = new STDEntities())
                {
                    model = db.Class.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtclass.Text = model.Name;
                }
                AddBtn.Text = "تعديل";
                DeleteBtn.Enabled = true;
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
                        db.Class.Attach(model);
                    db.Class.Remove(model);
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
                            MessageBox.Show("يجب حذف فصول الصف اولا");
                        }
                       
                       // throw;
                    }
                  

                }
            }
        }


        void clear()
        {
            txtclass.Text = "";
            AddBtn.Text = "إضافة";
            DeleteBtn.Enabled = false;
            model.ID = 0;
        }


        void PopulateDataGridView()
        {
            RadGrid.AutoGenerateColumns = false;
            using (STDEntities db = new STDEntities())
            {
                RadGrid.DataSource = db.Class.ToList<Class>();
            }
        }
    }
}