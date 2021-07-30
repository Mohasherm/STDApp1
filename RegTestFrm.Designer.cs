
namespace STDApp
{
    partial class RegTestFrm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radDroptestperiod = new Telerik.WinControls.UI.RadDropDownList();
            this.lblweek = new System.Windows.Forms.Label();
            this.radDropSubject = new Telerik.WinControls.UI.RadDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.radDropDepartment = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.radDropclasses = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.registerTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.numdegree = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.chkattend = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDroptestperiod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkattend)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radDroptestperiod);
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
            this.radPanel1.Size = new System.Drawing.Size(897, 53);
            this.radPanel1.TabIndex = 1;
            // 
            // radDroptestperiod
            // 
            this.radDroptestperiod.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDroptestperiod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDroptestperiod.Location = new System.Drawing.Point(12, 12);
            this.radDroptestperiod.Name = "radDroptestperiod";
            this.radDroptestperiod.Size = new System.Drawing.Size(150, 27);
            this.radDroptestperiod.TabIndex = 41;
            this.radDroptestperiod.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDroptestperiod_SelectedIndexChanged);
            // 
            // lblweek
            // 
            this.lblweek.AutoSize = true;
            this.lblweek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblweek.Location = new System.Drawing.Point(168, 14);
            this.lblweek.Name = "lblweek";
            this.lblweek.Size = new System.Drawing.Size(84, 21);
            this.lblweek.TabIndex = 40;
            this.lblweek.Text = "فترة الإختبار";
            // 
            // radDropSubject
            // 
            this.radDropSubject.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropSubject.Location = new System.Drawing.Point(258, 12);
            this.radDropSubject.Name = "radDropSubject";
            this.radDropSubject.Size = new System.Drawing.Size(150, 27);
            this.radDropSubject.TabIndex = 39;
            this.radDropSubject.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropSubject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(414, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "المادة";
            // 
            // radDropDepartment
            // 
            this.radDropDepartment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDepartment.Location = new System.Drawing.Point(468, 12);
            this.radDropDepartment.Name = "radDropDepartment";
            this.radDropDepartment.Size = new System.Drawing.Size(150, 27);
            this.radDropDepartment.TabIndex = 37;
            this.radDropDepartment.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(624, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "الفصل";
            // 
            // radDropclasses
            // 
            this.radDropclasses.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropclasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropclasses.Location = new System.Drawing.Point(684, 12);
            this.radDropclasses.Name = "radDropclasses";
            this.radDropclasses.Size = new System.Drawing.Size(150, 27);
            this.radDropclasses.TabIndex = 35;
            this.radDropclasses.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropclasses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(840, 14);
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
            this.radGridView.Location = new System.Drawing.Point(385, 53);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            this.radGridView.MasterTemplate.AllowSearchRow = true;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Degree";
            gridViewDecimalColumn2.HeaderText = "الدرجة";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn2.Name = "Degree";
            gridViewDecimalColumn2.Width = 52;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Attend";
            gridViewCheckBoxColumn1.HeaderText = "الحضور";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "Attend";
            gridViewCheckBoxColumn1.Width = 76;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "IsEarly";
            gridViewCheckBoxColumn2.HeaderText = "مبكر";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.IsVisible = false;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "IsEarly";
            gridViewCheckBoxColumn2.Width = 55;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Student_Id";
            gridViewDecimalColumn3.HeaderText = "Student_Id";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "Student_Id";
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Test_Id";
            gridViewDecimalColumn4.HeaderText = "Test_Id";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Test_Id";
            gridViewTextBoxColumn1.DataType = typeof(STDApp.Student);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Student";
            gridViewTextBoxColumn1.HeaderText = "Student";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Student";
            gridViewTextBoxColumn2.DataType = typeof(STDApp.Test);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Test";
            gridViewTextBoxColumn2.HeaderText = "Test";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Test";
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView.MasterTemplate.DataSource = this.registerTestBindingSource;
            this.radGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView.MasterTemplate.EnableGrouping = false;
            this.radGridView.MasterTemplate.EnableSorting = false;
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView.Size = new System.Drawing.Size(512, 397);
            this.radGridView.TabIndex = 43;
            this.radGridView.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.MasterTemplate_UserDeletingRow);
            this.radGridView.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellValueChanged);
            // 
            // registerTestBindingSource
            // 
            this.registerTestBindingSource.DataSource = typeof(STDApp.RegisterTest);
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
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ID";
            gridViewTextBoxColumn3.HeaderText = "ID";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ID";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Name";
            gridViewTextBoxColumn4.HeaderText = "الطالب";
            gridViewTextBoxColumn4.Name = "Name";
            gridViewTextBoxColumn4.Width = 250;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "DepartmentId";
            gridViewTextBoxColumn5.HeaderText = "DepartmentId";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "DepartmentId";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "DepartmentName";
            gridViewTextBoxColumn6.HeaderText = "الفصل";
            gridViewTextBoxColumn6.Name = "DepartmentName";
            gridViewTextBoxColumn6.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.MultiSelect = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(385, 342);
            this.radGridView1.TabIndex = 44;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(279, 399);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 39);
            this.AddBtn.TabIndex = 51;
            this.AddBtn.Text = " إضافة >";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // numdegree
            // 
            this.numdegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdegree.Location = new System.Drawing.Point(73, 411);
            this.numdegree.Name = "numdegree";
            this.numdegree.Size = new System.Drawing.Size(77, 26);
            this.numdegree.TabIndex = 61;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(18, 411);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 22);
            this.radLabel1.TabIndex = 60;
            this.radLabel1.Text = "الدرجة";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkattend
            // 
            this.chkattend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkattend.Location = new System.Drawing.Point(183, 413);
            this.chkattend.Name = "chkattend";
            this.chkattend.Size = new System.Drawing.Size(67, 22);
            this.chkattend.TabIndex = 59;
            this.chkattend.Text = "الحضور";
            // 
            // RegTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.numdegree);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.chkattend);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radGridView);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegTestFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل نتائج الإختبارات";
            this.Load += new System.EventHandler(this.RegTestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDroptestperiod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkattend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList radDroptestperiod;
        private System.Windows.Forms.Label lblweek;
        private Telerik.WinControls.UI.RadDropDownList radDropSubject;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList radDropDepartment;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList radDropclasses;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView radGridView;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.BindingSource registerTestBindingSource;
        private System.Windows.Forms.NumericUpDown numdegree;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox chkattend;
    }
}