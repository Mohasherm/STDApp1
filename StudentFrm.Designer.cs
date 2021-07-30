
namespace STDApp
{
    partial class StudentFrm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGrid = new Telerik.WinControls.UI.RadGridView();
            this.DeleteBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radDropclasses = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radDropDepartment = new Telerik.WinControls.UI.RadDropDownList();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmobile = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcivilnumber = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcivilnumber)).BeginInit();
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
            this.radGrid.Location = new System.Drawing.Point(325, 0);
            // 
            // 
            // 
            this.radGrid.MasterTemplate.AllowAddNewRow = false;
            this.radGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "الاسم";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 300;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Mobile";
            gridViewTextBoxColumn3.HeaderText = "جوال ولي الأمر";
            gridViewTextBoxColumn3.Name = "Mobile";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CivilNumber";
            gridViewTextBoxColumn4.HeaderText = "رقم الهوية";
            gridViewTextBoxColumn4.Name = "CivilNumber";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ClassId";
            gridViewTextBoxColumn5.HeaderText = "column5";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ClassId";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ClassName";
            gridViewTextBoxColumn6.HeaderText = "الصف";
            gridViewTextBoxColumn6.Name = "ClassName";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "DepartmentId";
            gridViewTextBoxColumn7.HeaderText = "column7";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "DepartmentId";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "DepartmentName";
            gridViewTextBoxColumn8.HeaderText = "الفصل";
            gridViewTextBoxColumn8.Name = "DepartmentName";
            gridViewTextBoxColumn8.Width = 150;
            this.radGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.radGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGrid.MasterTemplate.EnableFiltering = true;
            this.radGrid.MasterTemplate.EnableGrouping = false;
            this.radGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGrid.Name = "radGrid";
            this.radGrid.ReadOnly = true;
            this.radGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGrid.Size = new System.Drawing.Size(931, 399);
            this.radGrid.TabIndex = 0;
            this.radGrid.DoubleClick += new System.EventHandler(this.radGrid_DoubleClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteBtn.Location = new System.Drawing.Point(111, 339);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 39);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(226, 339);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(93, 39);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(12, 339);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(93, 39);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "إضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // radDropclasses
            // 
            this.radDropclasses.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropclasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropclasses.Location = new System.Drawing.Point(111, 192);
            this.radDropclasses.Name = "radDropclasses";
            this.radDropclasses.Size = new System.Drawing.Size(208, 27);
            this.radDropclasses.TabIndex = 22;
            this.radDropclasses.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropclasses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "الصف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "الفصل";
            // 
            // radDropDepartment
            // 
            this.radDropDepartment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDepartment.Location = new System.Drawing.Point(111, 255);
            this.radDropDepartment.Name = "radDropDepartment";
            this.radDropDepartment.Size = new System.Drawing.Size(208, 27);
            this.radDropDepartment.TabIndex = 24;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtname.Location = new System.Drawing.Point(111, 12);
            this.txtname.Name = "txtname";
            this.txtname.ShowClearButton = true;
            this.txtname.Size = new System.Drawing.Size(208, 27);
            this.txtname.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "الاسم";
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmobile.Location = new System.Drawing.Point(111, 66);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.ShowClearButton = true;
            this.txtmobile.Size = new System.Drawing.Size(208, 27);
            this.txtmobile.TabIndex = 28;
            this.txtmobile.Text = "0";
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "جوال ولي الأمر";
            // 
            // txtcivilnumber
            // 
            this.txtcivilnumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcivilnumber.Location = new System.Drawing.Point(111, 128);
            this.txtcivilnumber.MaxLength = 10;
            this.txtcivilnumber.Name = "txtcivilnumber";
            this.txtcivilnumber.ShowClearButton = true;
            this.txtcivilnumber.Size = new System.Drawing.Size(208, 27);
            this.txtcivilnumber.TabIndex = 30;
            this.txtcivilnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcivilnumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "رقم الهوية";
            // 
            // StudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 399);
            this.Controls.Add(this.txtcivilnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radDropDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radDropclasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.radGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الطلاب";
            this.Load += new System.EventHandler(this.StudentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcivilnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGrid;
        private Telerik.WinControls.UI.RadButton DeleteBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadDropDownList radDropclasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList radDropDepartment;
        private Telerik.WinControls.UI.RadTextBox txtname;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtmobile;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtcivilnumber;
        private System.Windows.Forms.Label label5;
    }
}