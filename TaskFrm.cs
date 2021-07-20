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
    public partial class TaskFrm : Form
    {
        Task model = new Task();

        public TaskFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txttask.Text = "";
           
            datefrom.Value = DateTime.Now;
            dateto.Value = DateTime.Now;
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
                radGrid.DataSource = (from task in db.Tasks
                                      join dep in db.Departments on task.Department_Id equals dep.ID
                                      join clas in db.Classes on dep.Class_Id equals clas.ID
                                      join sub in db.Subjects on task.Subject_Id equals sub.ID
                                      //where condtion if any                                             
                                      select new
                                      {
                                          //Column list here
                                          ID = task.ID,
                                          Title = task.Title,
                                          Start = task.Start,
                                          Finish = task.Finish,                                          
                                          ClassId = dep.Class_Id,
                                          ClassName = clas.Name,
                                          DepartmentId = task.Department_Id,
                                          DepartmentName = dep.Name,
                                          SubjectId = task.Subject_Id,
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

        private void TaskFrm_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txttask.Text.Trim()))
            {
                msg += "- ادخل عنوان المهمة ";
            }
            if (msg == "")
            {
                model.Title = txttask.Text.Trim();
                model.Start = datefrom.Text;
                model.Finish = dateto.Text;
                model.Subject_Id = Convert.ToInt32(radDropSubject.SelectedValue);
                model.Department_Id = Convert.ToInt32(radDropDepartment.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    if (model.ID == 0)
                    {
                        db.Tasks.Add(model);
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
                        db.Tasks.Attach(model);
                    db.Tasks.Remove(model);
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
                            MessageBox.Show("يجب حذف الطلاب الذين قاموا بانهاء هذه المهمة");
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
                    model = db.Tasks.Where(x => x.ID == model.ID).FirstOrDefault();
                    txttask.Text = model.Title;
                   datefrom.Text = model.Start;
                    dateto.Text = model.Finish;
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
