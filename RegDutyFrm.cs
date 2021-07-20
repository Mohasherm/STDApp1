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
using Telerik.WinForms.Documents.Model.StructuredDocumentTags.StructuredDocumentTagProperties;

namespace STDApp
{
    public partial class RegDutyFrm : Form
    {
        Student_Duty model = new Student_Duty();
        STDEntities dbContext = new STDEntities();
        public RegDutyFrm()
        {
            InitializeComponent();
        }

        private void RegDutyFrm_Load(object sender, EventArgs e)
        {
            studentDutyBindingSource.DataSource = dbContext.Student_Duty.Where(a => a.Student_Id == -1).ToList();

            GridViewTextBoxColumn txtstudent = new GridViewTextBoxColumn("StudentName");
            txtstudent.ReadOnly = true;
            txtstudent.FieldName = "Student.Name";
            txtstudent.Name = "Student.Name";
            txtstudent.HeaderText = "الطالب";
            txtstudent.PinPosition = PinnedColumnPosition.Left;
            radGridView.Columns.Add(txtstudent);

            BindingList<ComboBoxDataSourceObject> list = new BindingList<ComboBoxDataSourceObject>();
            ComboBoxDataSourceObject object1 = new ComboBoxDataSourceObject();
            object1.Id = 0;
            object1.MyString = "جيد";
            list.Add(object1);
            ComboBoxDataSourceObject object2 = new ComboBoxDataSourceObject();
            object2.Id = 1;
            object2.MyString = "جيد جداً";
            list.Add(object2);
            ComboBoxDataSourceObject object3 = new ComboBoxDataSourceObject();
            object3.Id = 2;
            object3.MyString = "ممتاز";
            list.Add(object3);

            GridViewComboBoxColumn dropmemorized = new GridViewComboBoxColumn("Memorized");
            dropmemorized.HeaderText = "حفظ";
            dropmemorized.IsVisible = false;
            dropmemorized.FieldName = "Memorized";
            dropmemorized.ValueMember = "Id";
            dropmemorized.DisplayMember = "MyString";            
            dropmemorized.DataSource = list;
            radGridView.Columns.Add(dropmemorized);

            GridViewComboBoxColumn dropReading = new GridViewComboBoxColumn("Reading");
            dropReading.HeaderText = "تلاوة";
            dropReading.IsVisible = false;
            dropReading.FieldName = "Reading";
            dropReading.ValueMember = "Id";
            dropReading.DisplayMember = "MyString";           
            dropReading.DataSource = list;
            radGridView.Columns.Add(dropReading);

            GridViewTextBoxColumn txtNote = new GridViewTextBoxColumn("Note");
            txtNote.HeaderText = "ملاحظة ولي الأمر";
            txtNote.IsVisible = false;
            txtNote.FieldName = "Note";
            txtNote.Name = "Note";            
            radGridView.Columns.Add(txtNote);
            radGridView.BestFitColumns();

            using (STDEntities db = new STDEntities())
            {
                radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Classes.ToList<Class>();
                radDropclasses.SelectedIndex = -1;
                db.RegisterTests.Load();
            }
            clear();
        }

        void clear()
        {
            lblmemory.Visible = false;
            lblread.Visible = false;
            lblnote.Visible = false;
            radDropMemory.Visible = false;
            radDropRead.Visible = false;
            txtnote.Visible = false;
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            model.Student_Id = 0;
            model.Duty_Id = 0;
        }

        void PopulateDataGridView()
        {

            var x = Convert.ToInt32(radDropDuty.SelectedValue);
            //var z = Convert.ToInt32(radDropSubject.SelectedValue);
            var v = Convert.ToInt32(radDropDepartment.SelectedValue);
            dbContext.RegisterTests.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                studentDutyBindingSource.DataSource = dbContext.Student_Duty
                          .Where(a => a.Duty_Id == x  && a.Student.Department_Id == v).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            studentDutyBindingSource.DataSource = dbContext.Student_Duty.Where(a => a.Student_Id == -1).ToList();
            radGridView1.DataSource = null;
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.DataSource = db.Departments
                        .Where(dep => dep.Class_Id == x).ToList();
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;

                radDropSubject.SelectedIndexChanged -= radDropSubject_SelectedIndexChanged;
                radDropSubject.DataSource = db.Subjects
                       .Where(sub => sub.Class_Id == x).ToList();
                radDropSubject.ValueMember = "ID";
                radDropSubject.DisplayMember = "Name";
                radDropSubject.SelectedIndex = -1;
                radDropSubject.SelectedIndexChanged += radDropSubject_SelectedIndexChanged;
            }
        }

        public void Generate()
        {
            if (radDropclasses.SelectedIndex == -1 || radDropDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الصف والفصل ");
            }
            else
            {
                radGridView1.AutoGenerateColumns = false;
                var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                var y = Convert.ToInt32(radDropDuty.SelectedValue);
                // var z = Convert.ToInt32(radDropSubject.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    List<int> result = db.Student_Duty
                        .Where(a => a.Duty_Id == y)
                        .Select(a => a.Student_Id).ToList();

                    radGridView1.DataSource = (from std in db.Students.Where(c => !result.Contains(c.ID))
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
                    radGridView.Columns[6].Width = 150;
                    radGridView.Columns[7].Width = 75;
                    radGridView.Columns[8].Width = 75;
                    radGridView.Columns[9].Width = 200;
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
            if (radDropDuty.SelectedIndex == -1)
            {
                msg = "- اختر الواجب ";
            }


            if (msg == "")
            {

                if (model.Duty_Id == 0 || model.Student_Id == 0)
                {
                    foreach (var data in radGridView1.SelectedRows)
                    {
                        using (STDEntities db = new STDEntities())
                        {

                            model.Student_Id = Convert.ToInt32(data.Cells["ID"].Value);
                            model.Duty_Id = Convert.ToInt32(radDropDuty.SelectedValue);
                            model.IsSolved = chkSolved.Checked;
                            model.IsEarly = chkEarly.Checked;
                            if (lblmemory.Visible==true)
                            {
                                model.Memorized = radDropMemory.SelectedIndex;
                                model.Reading = radDropRead.SelectedIndex;
                                model.Note = txtnote.Text;
                            }
                            else
                            {
                                model.Memorized = null;
                                model.Reading = null;
                                model.Note = "";
                            }
                           
                            db.Student_Duty.Add(model);
                            db.SaveChanges();
                           
                        }
                    }
                    model.Duty_Id = model.Student_Id = 0;
                    txtnote.Text = "";
                    chkSolved.Checked = false;
                    chkEarly.Checked = false;
                    radDropMemory.SelectedIndex = 0;
                    radDropRead.SelectedIndex = 0;
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
                int StdID = (int)radGridView.CurrentRow.Cells["Student_Id"].Value;
                int DutyID = (int)radGridView.CurrentRow.Cells["Duty_Id"].Value;
                var result = dbContext.Student_Duty.Where(a => a.Student_Id==StdID && a.Duty_Id == DutyID).FirstOrDefault();
                dbContext.Student_Duty.Remove(result);
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
            int StdID = (int)radGridView.CurrentRow.Cells["Student_Id"].Value;
            int DutyID = (int)radGridView.CurrentRow.Cells["Duty_Id"].Value;
            var result = (from x in dbContext.Student_Duty where x.Student_Id == StdID && x.Duty_Id == DutyID select x).FirstOrDefault();
            switch (e.ColumnIndex)
            {
                case 2:
                    result.IsSolved = (bool)e.Value;
                    break;
                case 3:
                    result.IsEarly = (bool)e.Value;
                    break;
                case 7:
                    result.Memorized = (int)e.Value;
                    break;
                case 8:
                    result.Reading = (int)e.Value;
                    break;
                case 9:
                    result.Note = e.Value.ToString();
                    break;
                default:
                    break;
            }

            dbContext.SaveChanges();
        }

        private void radDropDepartment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            studentDutyBindingSource.DataSource = dbContext.Student_Duty.Where(a => a.Student_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDropDuty.SelectedIndex = -1;
            radDropDuty.DataSource = null;
           
        }

        private void radDropSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            studentDutyBindingSource.DataSource = dbContext.Student_Duty.Where(a => a.Student_Id == -1).ToList();
            radGridView1.DataSource = null;
            
            if (radDropSubject.SelectedIndex != -1)
            {
                radDropDuty.ValueMember = "ID";
                radDropDuty.DisplayMember = "Name";
                var z = Convert.ToInt32(radDropSubject.SelectedValue);
                var v = Convert.ToInt32(radDropDepartment.SelectedValue);
                radDropDuty.DataSource = dbContext.Duties.Where(a => a.Department_Id == v && a.Subject_Id == z).ToList<Duty>();
               
                radDropDuty.SelectedIndex = -1;
            }

            if (radDropSubject.SelectedItem.Text.Contains("قرآن"))
            {
                lblmemory.Visible = true;
                lblread.Visible = true;
                lblnote.Visible = true;
                radDropMemory.Visible = true;
                radDropRead.Visible = true;
                txtnote.Text = "";
                radDropMemory.SelectedIndex = 0;
                radDropRead.SelectedIndex = 0;
                txtnote.Visible = true;
                radGridView.Columns[7].IsVisible = true;
                radGridView.Columns[8].IsVisible = true;
                radGridView.Columns[9].IsVisible = true;
            }
            else
            {
                lblmemory.Visible = false;
                lblread.Visible = false;
                lblnote.Visible = false;
                radDropMemory.Visible = false;
                radDropRead.Visible = false;
                txtnote.Visible = false;
                radGridView.Columns[7].IsVisible = false;
                radGridView.Columns[8].IsVisible = false;
                radGridView.Columns[9].IsVisible = false;
            }
            radDropDuty.SelectedIndex = -1;
        }

        private void radDropDuty_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            // studentDutyBindingSource.DataSource = dbContext.Student_Duty.Where(a => a.Student_Id == -1).ToList();
            // radGridView1.DataSource = null;
           
            Generate();           
        }

        private void RegDutyFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext.Dispose();
        }
    }
}
