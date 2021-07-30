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

namespace STDApp
{
    public partial class PointsFrm : Form
    {
        STDEntities dbContext = new STDEntities();
        
        Student model = new Student();
        public PointsFrm()
        {
            InitializeComponent();
        }

        void clear()
        {
            radDropDepartment.SelectedIndex = -1;
            radDropclasses.SelectedIndex = -1;
            lstweek.SelectedIndex = -1;
        }

        void PopulateDataGridView()
        {
            radDropDepartment.SelectedIndexChanged -= radDropDepartment_SelectedIndexChanged;
            var x = Convert.ToInt32(radDropDepartment.SelectedValue);
            radDropDepartment.SelectedIndexChanged += radDropDepartment_SelectedIndexChanged;
            radGridView1.AutoGenerateColumns = false;
            radGridView1.DataSource = (from std in dbContext.Student
                                       where std.Department_Id == x
                                       select new
                                       {
                                           ID = std.ID,
                                           Name = std.Name,
                                           Points = std.Points
                                       }).ToList();
            radGridView1.Refresh();
        }
        private void PointsFrm_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = dbContext.Student.Where(a => a.Department_Id == -1).ToList();
            dbContext.Week.Load();
            weekBindingSource.DataSource = dbContext.Week.Local.ToBindingList();
            lstweek.DataSource = weekBindingSource;
            using (STDEntities db = new STDEntities())
            {
                radDropclasses.ValueMember = "ID";
                radDropclasses.DisplayMember = "Name";
                radDropclasses.DataSource = db.Class.ToList<Class>().OrderBy(a => a.ID);
                radDropclasses.SelectedIndex = -1;
            }
            model.ID = 0;
            clear();
        }


        private void radDropclasses_SelectedIndexChanged_1(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //studentBindingSource.DataSource = dbContext.Students.Where(a => a.Department_Id == -1).ToList();
            radGridView1.DataSource = null;
            radDropDepartment.SelectedIndexChanged -= radDropDepartment_SelectedIndexChanged;
           
           
            using (STDEntities db = new STDEntities())
            {
                var x = Convert.ToInt32(radDropclasses.SelectedValue);
                radDropDepartment.DataSource = db.Department
                        .Where(dep => dep.Class_Id == x).ToList().OrderBy(a => a.ID);
                radDropDepartment.ValueMember = "ID";
                radDropDepartment.DisplayMember = "Name";
                radDropDepartment.SelectedIndex = -1;
            }
            radDropDepartment.SelectedIndexChanged += radDropDepartment_SelectedIndexChanged;
        }

        string msg = "";
        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            msg = "";
            if (radDropDepartment.SelectedIndex == -1)
            {
                msg = "- اختر الفصل ";
            }
            if (lstweek.SelectedItems.Count == 0)
            {
                msg += "- اختر اسبوع واحد على الأقل ";
            }
            if (MessageBox.Show("سوف يتم تصفير النقاط واعادة الحساب من جديد", "اعادة حساب النقاط", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (msg == "")
                {
                    var x = Convert.ToInt32(radDropDepartment.SelectedValue);
                    var std = dbContext.Student.Where(a => a.Department_Id == x).ToList();
                    foreach (var data in std)
                    {
                        model.ID = data.ID;
                        model.CivilNumber = data.CivilNumber;
                        model.Department_Id = data.Department_Id;
                        model.Mobile = data.Mobile;
                        model.Name = data.Name;
                        model.Points = 0;
                        using (STDEntities db = new STDEntities())
                        {
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }

                    }
                    CalcTestPoints(std);
                    ClacDutiesPoints(std);
                    ClacSharingPoints(std);
                    ClacTaskPoints(std);
                    ClacBehavoirPoints(std);
                    PopulateDataGridView();
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            
        }

        private void radDropDepartment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            PopulateDataGridView();
        }

        void  CalcTestPoints(List<Student> std)
        {
                     
            foreach (var data in std)
            {
                model.ID = data.ID;
                model.Points = dbContext.RegisterTest.Where(a => a.Student_Id == data.ID).Select(a => a.Degree).FirstOrDefault();
               
                model.CivilNumber = data.CivilNumber;
                model.Department_Id = data.Department_Id;
                model.Mobile = data.Mobile;
                model.Name = data.Name;
               
                using (STDEntities db = new STDEntities())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
               
            }           
        }

        void ClacDutiesPoints(List<Student> std)
        {
            List<Student_Duty> lst = new List<Student_Duty>();
            foreach (var data in std)
            {

                lst.Add(dbContext.Student_Duty.Where(a => a.Student_Id == data.ID).FirstOrDefault());
            }
            foreach (var item in lst)
            {
                if (item != null)
                {
                    model.CivilNumber = item.Student.CivilNumber;
                    model.Department_Id = item.Student.Department_Id;
                    model.Mobile = item.Student.Mobile;
                    model.Name = item.Student.Name;

                    if (item.IsSolved)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 10 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }

                    }
                    if (item.IsEarly)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 5 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    if (item.Memorized == 0)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 5 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    if (item.Memorized == 1)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 8 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    if (item.Memorized == 2)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 10 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    if (item.Reading == 0)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 5 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    if (item.Reading == 1)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 8 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    if (item.Reading == 2)
                    {
                        model.ID = item.Student_Id;
                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                            model.Points = 10 + i;
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
                             
            }           
        }

        void ClacSharingPoints(List<Student> std)
        {
            List<Sharing> lst = new List<Sharing>();
            foreach (var data in std)
            {
                foreach (var item in lstweek.SelectedItems)
                {
                    lst.Add(dbContext.Sharing.Where(a => a.Student_Id == data.ID && a.Week_Id == (int)item.Value).FirstOrDefault());
                }
            }
           
                foreach (var item in lst)
                {
                if (item != null)
                {
                    if (item.Sharing1 == 2)
                    {
                    model.ID = item.Student_Id;
                    using (STDEntities db = new STDEntities())
                    {
                        int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                        model.Points = 5 + i;
                    }
                }
                    if (item.Sharing1 == 1)
                    {
                    model.ID = item.Student_Id;
                    using (STDEntities db = new STDEntities())
                    {
                        int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                        model.Points = 8 + i;
                    }
                }
                    if (item.Sharing1 == 0)
                    {
                    model.ID = item.Student_Id;
                    using (STDEntities db = new STDEntities())
                    {
                        int i = db.Student.Where(a => a.ID == item.Student_Id).Select(a => a.Points).FirstOrDefault();
                        model.Points = 10 + i;
                    }
                }
               
                    model.CivilNumber = item.Student.CivilNumber;
                    model.Department_Id = item.Student.Department_Id;
                    model.Mobile = item.Student.Mobile;
                    model.Name = item.Student.Name;
                    using (STDEntities db = new STDEntities())
                    {
                        db.Entry(model).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                    
                }          
          
        }

        void ClacTaskPoints(List<Student> std)
        {
           
            foreach (var data in std)
            {
                model.ID = data.ID;
                int y=dbContext.RegisterTask.Where(a => a.Student_Id == data.ID).Select(a => a.Degree).FirstOrDefault();
                var x = dbContext.RegisterTask.Where(a => a.Student_Id == data.ID).Select(a => a.IsEarly).FirstOrDefault();
                if (x)
                {                  
                    using (STDEntities db = new STDEntities())
                    {
                        int i = db.Student.Where(a => a.ID == data.ID).Select(a => a.Points).FirstOrDefault();
                        model.Points = 5 + i + y;
                    }
                }
                model.CivilNumber = data.CivilNumber;
                model.Department_Id = data.Department_Id;
                model.Mobile = data.Mobile;
                model.Name = data.Name;
                using (STDEntities db = new STDEntities())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        void ClacBehavoirPoints(List<Student> std)
        {
            List<Behavior> lst = new List<Behavior>();
            foreach (var data in std)
            {
                foreach (var item in lstweek.SelectedItems)
                {
                    lst.Add(dbContext.Behavior.Where(a => a.Sudent_Id == data.ID && a.Week_Id == (int)item.Value).FirstOrDefault());
                }
            }
            if (lst.Count != 0)
            {
                foreach (var item in lst)
                {
                    if (item != null)
                    {
                        model.ID = item.Student.ID;

                        using (STDEntities db = new STDEntities())
                        {
                            int i = db.Student.Where(a => a.ID == item.Student.ID).Select(a => a.Points).FirstOrDefault();
                            model.Points = (item.Ok * 2) + i;
                        }
                        model.CivilNumber = item.Student.CivilNumber;
                        model.Department_Id = item.Student.Department_Id;
                        model.Mobile = item.Student.Mobile;
                        model.Name = item.Student.Name;
                        using (STDEntities db = new STDEntities())
                        {
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                   
                }
            }
        }

        private void PointsFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbContext.Dispose();
        }
    }
}