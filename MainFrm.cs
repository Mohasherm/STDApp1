using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace STDApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

      

        private void radButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
          
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            ClassFrm classFrm = new ClassFrm();
            classFrm.ShowDialog();
        }

        private void radMenuItem15_Click(object sender, EventArgs e)
        {
            DepartmentFrm departmentFrm = new DepartmentFrm();
            departmentFrm.ShowDialog();
        }

        private void radMenuItem14_Click(object sender, EventArgs e)
        {
            SubjectFrm subjectFrm = new SubjectFrm();
            subjectFrm.ShowDialog();
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {
            StudentFrm studentFrm = new StudentFrm();
            studentFrm.ShowDialog();
        }

        private void radMenuItem12_Click(object sender, EventArgs e)
        {
            WeekFrm weekFrm = new WeekFrm();
            weekFrm.ShowDialog();
        }

        private void radMenuItem16_Click(object sender, EventArgs e)
        {
            DutyFrm duty = new DutyFrm();
            duty.ShowDialog();
        }

        private void radMenuItem17_Click(object sender, EventArgs e)
        {
            RegDutyFrm regDutyFrm = new RegDutyFrm();
            regDutyFrm.ShowDialog();
        }

        private void radMenuItem22_Click(object sender, EventArgs e)
        {
            SharingFrm sharing = new SharingFrm();
            sharing.ShowDialog();
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            RegBehaviorFrm reg = new RegBehaviorFrm();
            reg.ShowDialog();
        }

        private void radMenuItem20_Click(object sender, EventArgs e)
        {
            TaskFrm taskFrm = new TaskFrm();
            taskFrm.ShowDialog();
        }

        private void radMenuItem21_Click(object sender, EventArgs e)
        {
            RegTaskFrm regTaskFrm = new RegTaskFrm();
            regTaskFrm.ShowDialog();
        }

        private void radMenuItem18_Click(object sender, EventArgs e)
        {
            testFrm testFrm = new testFrm();
            testFrm.ShowDialog();
        }

        private void radMenuItem19_Click(object sender, EventArgs e)
        {
            RegTestFrm regTests = new RegTestFrm();
            regTests.ShowDialog();
        }

        private void radMenuItem23_Click(object sender, EventArgs e)
        {
            PointsFrm pointsFrm = new PointsFrm();
            pointsFrm.ShowDialog();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("S_N.mhbk");
            string serverName = reader.ReadLine();
            reader.Close();


            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["STDEntities"].ConnectionString = string.Format(@"metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=';data source={0};initial catalog=STD;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework';",serverName);
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private void radMenuItem24_Click(object sender, EventArgs e)
        {
            AbsenceFrm absence = new AbsenceFrm();
            absence.ShowDialog();
        }
    }
}

