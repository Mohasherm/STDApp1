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
    public partial class SharingFrm : Form
    {
        Sharing model = new Sharing();
        STDEntities dbContext = new STDEntities();
        public SharingFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
          
            radDropSubject.SelectedIndex = -1;
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            radDropweek.SelectedIndex = -1;
            radDropShare.SelectedIndex = 0;
            model.ID = 0;            
        }
        void PopulateDataGridView()
        {
           
            var x = Convert.ToInt32(radDropweek.SelectedValue);
            var z = Convert.ToInt32(radDropSubject.SelectedValue);
            var v = Convert.ToInt32(radDropDepartment.SelectedValue);
            dbContext.Sharing.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                sharingBindingSource.DataSource = dbContext.Sharing
                          .Where(a => a.Week_Id == x && a.Subject_Id == z && a.Student.Department_Id == v).ToList();
                //sharingBindingSource.DataSource = (from shar in dbContext.Sharings
                //     .Where(a => a.Week_Id == x && a.Subject_Id == z && a.Student.Department_Id == v)
                //                                   select new
                //                                   {
                //                                       ID = shar.ID,
                //                                       Sharing1 = shar.Sharing1,
                //                                       Student_Id = shar.Student_Id,
                //                                       StudentName = shar.Student.Name,
                //                                       Subject_Id = shar.Subject_Id,
                //                                       SubjectName = shar.Subject.Name
                //                                   }).ToList();  
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            
        }

        private void SharingFrm_FormClosed(object sender, EventArgs e)
        {
            dbContext.Dispose();
        }
        private void SharingFrm_Load(object sender, EventArgs e)
        {
            
            sharingBindingSource.DataSource = dbContext.Sharing.Where(a => a.Week_Id == -1).ToList();

            GridViewTextBoxColumn txtstudent = new GridViewTextBoxColumn("StudentName");
            txtstudent.ReadOnly = true;
            txtstudent.FieldName = "Student.Name";
            txtstudent.Name = "Student.Name";
            txtstudent.HeaderText = "الطالب";
            txtstudent.PinPosition = PinnedColumnPosition.Left;
            radGridView.Columns.Add(txtstudent);

            GridViewComboBoxColumn dropSharing = new GridViewComboBoxColumn("Sharing1");
            dropSharing.HeaderText = "المشاركة";
            dropSharing.FieldName = "Sharing1";
            dropSharing.ValueMember = "Id";
            dropSharing.DisplayMember = "MyString";
            BindingList<ComboBoxDataSourceObject> list = new BindingList<ComboBoxDataSourceObject>();
            ComboBoxDataSourceObject object3 = new ComboBoxDataSourceObject();
            object3.Id = 0;
            object3.MyString = "ممتاز";
            list.Add(object3);
            ComboBoxDataSourceObject object2 = new ComboBoxDataSourceObject();
            object2.Id = 1;
            object2.MyString = "جيد جداً";
            list.Add(object2);
            ComboBoxDataSourceObject object1 = new ComboBoxDataSourceObject();
            object1.Id = 2;
            object1.MyString = "جيد";
            list.Add(object1);
            ComboBoxDataSourceObject object4 = new ComboBoxDataSourceObject();
            object4.Id = 3;
            object4.MyString = "ضعيف";
            list.Add(object4);       
           
           
           
            dropSharing.DataSource = list;
            radGridView.Columns.Add(dropSharing);
            radGridView.BestFitColumns();

            using (STDEntities db = new STDEntities())
            {
                radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Class.ToList<Class>().OrderBy(a => a.ID);
                radDropclasses.SelectedIndex = -1;

                db.Sharing.Load();

                radDropweek.SelectedIndexChanged -= radDropweek_SelectedIndexChanged;
                radDropweek.DataSource = db.Week.ToList<Week>().OrderBy(a => a.ID);
                radDropweek.ValueMember = "ID";
                radDropweek.DisplayMember = "Number";
                radDropweek.SelectedIndex = -1;
                radDropweek.SelectedIndexChanged += radDropweek_SelectedIndexChanged;
            }

            clear();
        }

        private void radDropclasses_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            sharingBindingSource.DataSource = dbContext.Sharing.Where(a => a.Week_Id == -1).ToList();
            radGridView1.DataSource = null;
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.SelectedIndexChanged -= radDropDepartment_SelectedIndexChanged;
                radDropDepartment.DataSource = db.Department
                        .Where(dep => dep.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;
                radDropDepartment.SelectedIndexChanged += radDropDepartment_SelectedIndexChanged;
                radDropSubject.SelectedIndexChanged -= radDropSubject_SelectedIndexChanged;
                radDropSubject.DataSource = db.Subject
                       .Where(sub => sub.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropSubject.ValueMember = "ID";
                radDropSubject.DisplayMember = "Name";
                radDropSubject.SelectedIndex = -1;
                radDropSubject.SelectedIndexChanged += radDropSubject_SelectedIndexChanged;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
                    
        }

        void Generate()
        {
            if (radDropclasses.SelectedIndex == -1 || radDropDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الصف والفصل");
            }
            else
            {
                radGridView1.AutoGenerateColumns = false;
                var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                var y = Convert.ToInt32(radDropweek.SelectedValue);
                var z = Convert.ToInt32(radDropSubject.SelectedValue);

                using (STDEntities db = new STDEntities())
                {
                    List<int> result = db.Sharing
                        .Where(a => a.Week_Id == y && a.Subject_Id == z && a.Student.Department_Id == x)
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
                    radGridView.Columns[7].Width = 150;
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
            if (radDropweek.SelectedIndex == -1)
            {
                msg = "- اختر الاسبوع ";
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
                            model.Sharing1 = radDropShare.SelectedIndex;
                            model.Subject_Id = (int)radDropSubject.SelectedValue;
                            model.Week_Id = (int)radDropweek.SelectedValue;
                            db.Sharing.Add(model);
                            db.SaveChanges();                           
                        }
                    }
                    model.ID = 0;
                    radDropShare.SelectedIndex = 0;
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

        private void radGridView_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
                var result = dbContext.Sharing.Find(ID);
                dbContext.Sharing.Remove(result);
                dbContext.SaveChanges();
                Generate();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                Generate();
            }
        }

        private void radGridView_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int ID = (int)radGridView.CurrentRow.Cells["ID"].Value;
            var result = (from x in dbContext.Sharing where x.ID == ID select x).FirstOrDefault();
            result.Sharing1 = (int)e.Value;            
            dbContext.SaveChanges();
        }

        private void radDropDepartment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            sharingBindingSource.DataSource = dbContext.Sharing.Where(a => a.Week_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDropSubject.SelectedIndex = -1;
            radDropweek.SelectedIndex = -1;
        }

        private void radDropSubject_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            sharingBindingSource.DataSource = dbContext.Sharing.Where(a => a.Week_Id == -1).ToList();
            radGridView1.DataSource = null;
        }

        private void radDropweek_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Generate();
        }
    }
}

