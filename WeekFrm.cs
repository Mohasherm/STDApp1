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
    public partial class WeekFrm : Form
    {
        Week model = new Week();
        public WeekFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtweeknumber.Text = "";
            datefrom.Value = DateTime.Now;
            dateto.Value = DateTime.Now;
            AddBtn.Text = "إضافة";
            DeleteBtn.Enabled = false;
            model.ID = 0;
        }

        void PopulateDataGridView()
        {
            radGrid.AutoGenerateColumns = false;
            using (STDEntities db = new STDEntities())
            {
                radGrid.DataSource = db.Weeks.ToList<Week>();
            }
        }

        private void txtweeknumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void WeekFrm_Load(object sender, EventArgs e)
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
            if (!string.IsNullOrEmpty(txtweeknumber.Text.Trim()))
            {
                model.Number = txtweeknumber.Text.Trim();
                model.Start = datefrom.Text;
                model.Finish = dateto.Text;
                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        if (IsWeekNumberAvailable(model.Number))
                        {
                            db.Weeks.Add(model);
                            //MessageBox.Show("تمت الإضافة بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن تكرار رقم الأسبوع");
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
                MessageBox.Show("أدخل رقم الأسبوع");
            }
        }

        public bool IsWeekNumberAvailable(string num)
        {
            using (STDEntities db = new STDEntities())
            {
                bool Number = db.Weeks.Where(m => m.Number == num).Any();

                return !Number;

            }
        }

        private void radGrid_DoubleClick(object sender, EventArgs e)
        {
            if (radGrid.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(radGrid.CurrentRow.Cells["ID"].Value);
                using (STDEntities db = new STDEntities())
                {
                    model = db.Weeks.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtweeknumber.Text = model.Number;
                    datefrom.Text = model.Start;
                    dateto.Text = model.Finish;
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
                        db.Weeks.Attach(model);
                    db.Weeks.Remove(model);
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
                            MessageBox.Show("يجب حذف كافة تعاريف السلوك والمشاركة التابعة لهذا الأسبوع");
                        }
                    }
                }
            }
        }
    }
}
