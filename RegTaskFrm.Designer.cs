
namespace STDApp
{
    partial class RegTaskFrm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radDropTaskTitle = new Telerik.WinControls.UI.RadDropDownList();
            this.lblweek = new System.Windows.Forms.Label();
            this.radDropSubject = new Telerik.WinControls.UI.RadDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.radDropDepartment = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.radDropclasses = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.registerTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.chkearly = new Telerik.WinControls.UI.RadCheckBox();
            this.chkattend = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.numdegree = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropTaskTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerTaskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkearly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkattend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdegree)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radDropTaskTitle);
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
            this.radPanel1.Size = new System.Drawing.Size(881, 53);
            this.radPanel1.TabIndex = 2;
            // 
            // radDropTaskTitle
            // 
            this.radDropTaskTitle.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropTaskTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropTaskTitle.Location = new System.Drawing.Point(3, 12);
            this.radDropTaskTitle.Name = "radDropTaskTitle";
            this.radDropTaskTitle.Size = new System.Drawing.Size(150, 27);
            this.radDropTaskTitle.TabIndex = 41;
            this.radDropTaskTitle.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropTaskTitle_SelectedIndexChanged);
            // 
            // lblweek
            // 
            this.lblweek.AutoSize = true;
            this.lblweek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblweek.Location = new System.Drawing.Point(155, 14);
            this.lblweek.Name = "lblweek";
            this.lblweek.Size = new System.Drawing.Size(94, 21);
            this.lblweek.TabIndex = 40;
            this.lblweek.Text = "عنوان المهمة";
            // 
            // radDropSubject
            // 
            this.radDropSubject.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropSubject.Location = new System.Drawing.Point(253, 12);
            this.radDropSubject.Name = "radDropSubject";
            this.radDropSubject.Size = new System.Drawing.Size(150, 27);
            this.radDropSubject.TabIndex = 39;
            this.radDropSubject.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropSubject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(409, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "المادة";
            // 
            // radDropDepartment
            // 
            this.radDropDepartment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDepartment.Location = new System.Drawing.Point(463, 12);
            this.radDropDepartment.Name = "radDropDepartment";
            this.radDropDepartment.Size = new System.Drawing.Size(150, 27);
            this.radDropDepartment.TabIndex = 37;
            this.radDropDepartment.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(612, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "الفصل";
            // 
            // radDropclasses
            // 
            this.radDropclasses.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropclasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropclasses.Location = new System.Drawing.Point(672, 12);
            this.radDropclasses.Name = "radDropclasses";
            this.radDropclasses.Size = new System.Drawing.Size(150, 27);
            this.radDropclasses.TabIndex = 35;
            this.radDropclasses.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropclasses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(828, 14);
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
            this.radGridView.Location = new System.Drawing.Point(424, 53);
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
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Student_Id";
            gridViewDecimalColumn3.HeaderText = "Student_Id";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "Student_Id";
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Task_Id";
            gridViewDecimalColumn4.HeaderText = "Task_Id";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Task_Id";
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "IsEarly";
            gridViewCheckBoxColumn2.HeaderText = "مبكر";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "IsEarly";
            gridViewCheckBoxColumn2.Width = 55;
            gridViewTextBoxColumn1.DataType = typeof(STDApp.Student);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Student";
            gridViewTextBoxColumn1.HeaderText = "Student";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Student";
            gridViewTextBoxColumn2.DataType = typeof(STDApp.Task);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Task";
            gridViewTextBoxColumn2.HeaderText = "Task";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Task";
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewCheckBoxColumn1,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView.MasterTemplate.DataSource = this.registerTaskBindingSource;
            this.radGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView.MasterTemplate.EnableGrouping = false;
            this.radGridView.MasterTemplate.EnableSorting = false;
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView.Size = new System.Drawing.Size(457, 396);
            this.radGridView.TabIndex = 3;
            this.radGridView.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.radGridView_UserDeletingRow);
            this.radGridView.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView_CellValueChanged);
            // 
            // registerTaskBindingSource
            // 
            this.registerTaskBindingSource.DataSource = typeof(STDApp.RegisterTask);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(318, 401);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 39);
            this.AddBtn.TabIndex = 52;
            this.AddBtn.Text = " إضافة >";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ID";
            gridViewTextBoxColumn3.HeaderText = "ID";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ID";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Name";
            gridViewTextBoxColumn4.HeaderText = "الطالب";
            gridViewTextBoxColumn4.Name = "Name";
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "DepartmentId";
            gridViewTextBoxColumn5.HeaderText = "DepartmentId";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "DepartmentId";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "DepartmentName";
            gridViewTextBoxColumn6.HeaderText = "الفصل";
            gridViewTextBoxColumn6.Name = "DepartmentName";
            gridViewTextBoxColumn6.Width = 200;
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
            this.radGridView1.Size = new System.Drawing.Size(424, 342);
            this.radGridView1.TabIndex = 53;
            // 
            // chkearly
            // 
            this.chkearly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkearly.Location = new System.Drawing.Point(253, 408);
            this.chkearly.Name = "chkearly";
            this.chkearly.Size = new System.Drawing.Size(52, 25);
            this.chkearly.TabIndex = 54;
            this.chkearly.Text = "مبكر";
            // 
            // chkattend
            // 
            this.chkattend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chkattend.Location = new System.Drawing.Point(160, 408);
            this.chkattend.Name = "chkattend";
            this.chkattend.Size = new System.Drawing.Size(73, 25);
            this.chkattend.TabIndex = 55;
            this.chkattend.Text = "الحضور";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 408);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 25);
            this.radLabel1.TabIndex = 56;
            this.radLabel1.Text = "الدرجة";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // numdegree
            // 
            this.numdegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdegree.Location = new System.Drawing.Point(68, 409);
            this.numdegree.Name = "numdegree";
            this.numdegree.Size = new System.Drawing.Size(77, 26);
            this.numdegree.TabIndex = 57;
            // 
            // RegTaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 449);
            this.Controls.Add(this.numdegree);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.chkattend);
            this.Controls.Add(this.chkearly);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.radGridView);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegTaskFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل نتائج المهام الأدائية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegTaskFrm_FormClosed);
            this.Load += new System.EventHandler(this.RegTaskFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropTaskTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerTaskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkearly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkattend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList radDropTaskTitle;
        private System.Windows.Forms.Label lblweek;
        private Telerik.WinControls.UI.RadDropDownList radDropSubject;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList radDropDepartment;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList radDropclasses;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView radGridView;
        private System.Windows.Forms.BindingSource registerTaskBindingSource;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadCheckBox chkearly;
        private Telerik.WinControls.UI.RadCheckBox chkattend;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown numdegree;
    }
}