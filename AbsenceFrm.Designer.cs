
namespace STDApp
{
    partial class AbsenceFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.date = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblweek = new System.Windows.Forms.Label();
            this.radDropSubject = new Telerik.WinControls.UI.RadDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.radDropDepartment = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.radDropclasses = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.date);
            this.radPanel1.Controls.Add(this.lblweek);
            this.radPanel1.Controls.Add(this.radDropSubject);
            this.radPanel1.Controls.Add(this.label3);
            this.radPanel1.Controls.Add(this.radDropDepartment);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.radDropclasses);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(913, 53);
            this.radPanel1.TabIndex = 4;
            // 
            // date
            // 
            this.date.Culture = new System.Globalization.CultureInfo("ar-SA");
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.date.Location = new System.Drawing.Point(12, 11);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(160, 27);
            this.date.TabIndex = 41;
            this.date.TabStop = false;
            this.date.Text = "11/ذو القعدة/1442";
            this.date.Value = new System.DateTime(2021, 6, 21, 23, 0, 27, 610);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lblweek
            // 
            this.lblweek.AutoSize = true;
            this.lblweek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblweek.Location = new System.Drawing.Point(178, 13);
            this.lblweek.Name = "lblweek";
            this.lblweek.Size = new System.Drawing.Size(50, 21);
            this.lblweek.TabIndex = 40;
            this.lblweek.Text = "التاريخ";
            // 
            // radDropSubject
            // 
            this.radDropSubject.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropSubject.Location = new System.Drawing.Point(248, 11);
            this.radDropSubject.Name = "radDropSubject";
            this.radDropSubject.Size = new System.Drawing.Size(160, 27);
            this.radDropSubject.TabIndex = 39;
            this.radDropSubject.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropSubject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(414, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "المادة";
            // 
            // radDropDepartment
            // 
            this.radDropDepartment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDepartment.Location = new System.Drawing.Point(468, 11);
            this.radDropDepartment.Name = "radDropDepartment";
            this.radDropDepartment.Size = new System.Drawing.Size(160, 27);
            this.radDropDepartment.TabIndex = 37;
            this.radDropDepartment.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(634, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "الفصل";
            // 
            // radDropclasses
            // 
            this.radDropclasses.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropclasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropclasses.Location = new System.Drawing.Point(694, 11);
            this.radDropclasses.Name = "radDropclasses";
            this.radDropclasses.Size = new System.Drawing.Size(160, 27);
            this.radDropclasses.TabIndex = 35;
            this.radDropclasses.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropclasses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(860, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "الصف";
            // 
            // radGridView
            // 
            this.radGridView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGridView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView.Location = new System.Drawing.Point(350, 53);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            this.radGridView.MasterTemplate.AllowColumnReorder = false;
            this.radGridView.MasterTemplate.AllowSearchRow = true;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Date";
            gridViewTextBoxColumn1.HeaderText = "تاريخ الغياب";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Date";
            gridViewTextBoxColumn1.Width = 175;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Student_Id";
            gridViewDecimalColumn2.HeaderText = "Student_Id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Student_Id";
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Subject_Id";
            gridViewDecimalColumn3.HeaderText = "Subject_Id";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "Subject_Id";
            gridViewTextBoxColumn2.DataType = typeof(STDApp.Student);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Student";
            gridViewTextBoxColumn2.HeaderText = "Student";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Student";
            gridViewTextBoxColumn3.DataType = typeof(STDApp.Subject);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Subject";
            gridViewTextBoxColumn3.HeaderText = "Subject";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Subject";
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView.MasterTemplate.DataSource = this.absenceBindingSource;
            this.radGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView.MasterTemplate.EnableFiltering = true;
            this.radGridView.MasterTemplate.EnableGrouping = false;
            this.radGridView.MasterTemplate.EnableSorting = false;
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView.Size = new System.Drawing.Size(563, 397);
            this.radGridView.TabIndex = 42;
            this.radGridView.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.radGridView_UserDeletingRow);
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataSource = typeof(STDApp.Absence);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 53);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ID";
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ID";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Name";
            gridViewTextBoxColumn5.HeaderText = "الطالب";
            gridViewTextBoxColumn5.Name = "Name";
            gridViewTextBoxColumn5.Width = 175;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "DepartmentId";
            gridViewTextBoxColumn6.HeaderText = "DepartmentId";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "DepartmentId";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "DepartmentName";
            gridViewTextBoxColumn7.HeaderText = "الفصل";
            gridViewTextBoxColumn7.Name = "DepartmentName";
            gridViewTextBoxColumn7.Width = 145;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.MultiSelect = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(350, 337);
            this.radGridView1.TabIndex = 57;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(40, 396);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(276, 39);
            this.AddBtn.TabIndex = 58;
            this.AddBtn.Text = " إضافة >";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AbsenceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radGridView);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AbsenceFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الغياب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AbsenceFrm_FormClosing);
            this.Load += new System.EventHandler(this.AbsenceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label lblweek;
        private Telerik.WinControls.UI.RadDropDownList radDropSubject;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList radDropDepartment;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList radDropclasses;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker date;
        private Telerik.WinControls.UI.RadGridView radGridView;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.BindingSource absenceBindingSource;
    }
}