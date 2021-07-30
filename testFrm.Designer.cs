
namespace STDApp
{
    partial class testFrm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGrid = new Telerik.WinControls.UI.RadGridView();
            this.radDropSubject = new Telerik.WinControls.UI.RadDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.radDropDepartment = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.radDropclasses = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datefinal = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radDroptestperiod = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.txttest = new Telerik.WinControls.UI.RadRichTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDroptestperiod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttest)).BeginInit();
            this.SuspendLayout();
            // 
            // radGrid
            // 
            this.radGrid.BackColor = System.Drawing.SystemColors.Control;
            this.radGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGrid.Location = new System.Drawing.Point(451, 0);
            // 
            // 
            // 
            this.radGrid.MasterTemplate.AllowAddNewRow = false;
            this.radGrid.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TimePeriod";
            gridViewTextBoxColumn2.HeaderText = "فترة الإختبار";
            gridViewTextBoxColumn2.Name = "TimePeriod";
            gridViewTextBoxColumn2.Width = 125;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "FinalDate";
            gridViewTextBoxColumn3.HeaderText = "تاريخ الاختبار";
            gridViewTextBoxColumn3.Name = "FinalDate";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Test";
            gridViewTextBoxColumn4.HeaderText = "الإختبار";
            gridViewTextBoxColumn4.Name = "Test";
            gridViewTextBoxColumn4.Width = 270;
            gridViewTextBoxColumn4.WrapText = true;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ClassId";
            gridViewTextBoxColumn5.HeaderText = "ClassId";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ClassId";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ClassName";
            gridViewTextBoxColumn6.HeaderText = "الصف";
            gridViewTextBoxColumn6.Name = "ClassName";
            gridViewTextBoxColumn6.Width = 75;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "DepartmentId";
            gridViewTextBoxColumn7.HeaderText = "DepartmentId";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "DepartmentId";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "DepartmentName";
            gridViewTextBoxColumn8.HeaderText = "الفصل";
            gridViewTextBoxColumn8.Name = "DepartmentName";
            gridViewTextBoxColumn8.Width = 75;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "SubjectId";
            gridViewTextBoxColumn9.HeaderText = "SubjectId";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "SubjectId";
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "SubjectName";
            gridViewTextBoxColumn10.HeaderText = "المادة";
            gridViewTextBoxColumn10.Name = "SubjectName";
            gridViewTextBoxColumn10.Width = 75;
            this.radGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.radGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGrid.MasterTemplate.EnableFiltering = true;
            this.radGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGrid.Name = "radGrid";
            this.radGrid.ReadOnly = true;
            this.radGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGrid.Size = new System.Drawing.Size(813, 560);
            this.radGrid.TabIndex = 0;
            this.radGrid.DoubleClick += new System.EventHandler(this.radGrid_DoubleClick);
            // 
            // radDropSubject
            // 
            this.radDropSubject.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropSubject.Location = new System.Drawing.Point(102, 78);
            this.radDropSubject.Name = "radDropSubject";
            this.radDropSubject.Size = new System.Drawing.Size(342, 27);
            this.radDropSubject.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "المادة";
            // 
            // radDropDepartment
            // 
            this.radDropDepartment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDepartment.Location = new System.Drawing.Point(102, 45);
            this.radDropDepartment.Name = "radDropDepartment";
            this.radDropDepartment.Size = new System.Drawing.Size(342, 27);
            this.radDropDepartment.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "الفصل";
            // 
            // radDropclasses
            // 
            this.radDropclasses.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropclasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropclasses.Location = new System.Drawing.Point(103, 12);
            this.radDropclasses.Name = "radDropclasses";
            this.radDropclasses.Size = new System.Drawing.Size(342, 27);
            this.radDropclasses.TabIndex = 43;
            this.radDropclasses.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropclasses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "الصف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "تاريخ الاختبار";
            // 
            // datefinal
            // 
            this.datefinal.Culture = new System.Globalization.CultureInfo("ar-SA");
            this.datefinal.CustomFormat = "dd / MMMM / yyyy";
            this.datefinal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.datefinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefinal.Location = new System.Drawing.Point(102, 144);
            this.datefinal.Name = "datefinal";
            this.datefinal.Size = new System.Drawing.Size(342, 27);
            this.datefinal.TabIndex = 50;
            this.datefinal.TabStop = false;
            this.datefinal.Text = "11 / ذو القعدة / 1442";
            this.datefinal.Value = new System.DateTime(2021, 6, 21, 23, 0, 27, 610);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "فترة الاختبار";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteBtn.Location = new System.Drawing.Point(211, 505);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 39);
            this.DeleteBtn.TabIndex = 53;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(326, 505);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(93, 39);
            this.CancelBtn.TabIndex = 54;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(112, 505);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(93, 39);
            this.AddBtn.TabIndex = 52;
            this.AddBtn.Text = "إضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // radDroptestperiod
            // 
            this.radDroptestperiod.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDroptestperiod.Font = new System.Drawing.Font("Segoe UI", 12F);
            radListDataItem1.Text = "الفترة الأولى";
            radListDataItem2.Text = "الفترة الثانية";
            radListDataItem3.Text = "نهاية الفصل";
            this.radDroptestperiod.Items.Add(radListDataItem1);
            this.radDroptestperiod.Items.Add(radListDataItem2);
            this.radDroptestperiod.Items.Add(radListDataItem3);
            this.radDroptestperiod.Location = new System.Drawing.Point(103, 111);
            this.radDroptestperiod.Name = "radDroptestperiod";
            this.radDroptestperiod.Size = new System.Drawing.Size(342, 27);
            this.radDroptestperiod.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "الاختبار";
            // 
            // txttest
            // 
            this.txttest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.txttest.Location = new System.Drawing.Point(103, 177);
            this.txttest.Name = "txttest";
            this.txttest.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txttest.Size = new System.Drawing.Size(342, 316);
            this.txttest.TabIndex = 57;
            // 
            // testFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 560);
            this.Controls.Add(this.txttest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radDroptestperiod);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datefinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radDropSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radDropDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radDropclasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "testFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعريف الاختبارات";
            this.Load += new System.EventHandler(this.testFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDroptestperiod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGrid;
        private Telerik.WinControls.UI.RadDropDownList radDropSubject;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList radDropDepartment;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList radDropclasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDateTimePicker datefinal;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton DeleteBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadDropDownList radDroptestperiod;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadRichTextEditor txttest;
    }
}