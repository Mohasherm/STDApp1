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
    public partial class DutyFrm : Form
    {
        Duty model = new Duty();
        public DutyFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtduty.Text = "";
           // txtDutyNumber.Text = "";
            datedutyfinal.Value = DateTime.Now;
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
                radGrid.DataSource = (from duty in db.Duties
                                      join dep in db.Departments on duty.Department_Id equals dep.ID
                                      join clas in db.Classes on dep.Class_Id equals clas.ID
                                      join sub in db.Subjects on duty.Subject_Id equals sub.ID
                                      //where condtion if any                                             
                                      select new
                                      {
                                          //Column list here
                                          ID = duty.ID,
                                          Name = duty.Name,
                                          Number = duty.Number,
                                          Expire = duty.Expire,
                                          ClassId = dep.Class_Id,
                                          ClassName = clas.Name,
                                          DepartmentId = duty.Department_Id,
                                          DepartmentName = dep.Name,
                                          SubjectId = duty.Subject_Id,
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
        private void DutyFrm_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void txtDutyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
            if (string.IsNullOrEmpty(txtduty.Text.Trim()))
            {
                msg += "- ادخل الواجب المطلوب ";
            }
            //if (string.IsNullOrEmpty(txtDutyNumber.Text.Trim()))
            //{
            //    msg += "- ادخل رقم الواجب ";
            //}
           
            if (msg == "")
            {
                using (STDEntities db = new STDEntities())
                {
                    int i = db.Duties.Max(a => a.ID);
                    var result = db.Duties.Find(i);
                    model.Number = (Convert.ToInt32(result.Number) + 1).ToString();

                }
                   
                model.Name = txtduty.Text.Trim();               
                model.Expire = datedutyfinal.Text;
                model.Subject_Id = Convert.ToInt32(radDropSubject.SelectedValue);
                model.Department_Id = Convert.ToInt32(radDropDepartment.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        if (IsDutyAvailable(model.Number , model.Department_Id))
                        {
                            db.Duties.Add(model);
                            //MessageBox.Show("تمت الإضافة بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("لايمكن تكرار رقم الواجب");
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

        public bool IsDutyAvailable(string num, int id)
        {
            using (STDEntities db = new STDEntities())
            {
                bool duty = db.Duties.Where(m => m.Department_Id == id).Where(x => x.Number == num).Any();

                return !duty;

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
                        db.Duties.Attach(model);
                    db.Duties.Remove(model);
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
                            MessageBox.Show("يجب حذف الطلاب الذين أتمو الواجب");
                        }
                    }
                }
            }
        }
        

        private void RadGridView_DoubleClick(object sender, EventArgs e)
        {
            if (radGrid.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(radGrid.CurrentRow.Cells["ID"].Value);
                using (STDEntities db = new STDEntities())
                {
                    model = db.Duties.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtduty.Text = model.Name;
                    //txtDutyNumber.Text = model.Number;
                    datedutyfinal.Text = model.Expire;
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
