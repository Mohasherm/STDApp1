
namespace STDApp
{
    partial class DepartmentFrm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.DeleteBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.radGrid = new Telerik.WinControls.UI.RadGridView();
            this.txtdepartment = new Telerik.WinControls.UI.RadTextBox();
            this.ClassDropdownlist = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDropdownlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "الصف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "الفصل";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(15, 177);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(93, 39);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "إضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteBtn.Location = new System.Drawing.Point(114, 177);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 39);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(229, 177);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(93, 39);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // radGrid
            // 
            this.radGrid.BackColor = System.Drawing.SystemColors.Control;
            this.radGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGrid.Location = new System.Drawing.Point(347, 0);
            // 
            // 
            // 
            this.radGrid.MasterTemplate.AllowAddNewRow = false;
            this.radGrid.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "DepID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "الفصل";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "ClassID";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ClassId";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ClassName";
            gridViewTextBoxColumn4.HeaderText = "الصف";
            gridViewTextBoxColumn4.Name = "ClassName";
            gridViewTextBoxColumn4.Width = 150;
            this.radGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGrid.MasterTemplate.EnableFiltering = true;
            this.radGrid.MasterTemplate.EnableGrouping = false;
            this.radGrid.MasterTemplate.EnableSorting = false;
            this.radGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGrid.Name = "radGrid";
            this.radGrid.ReadOnly = true;
            this.radGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGrid.Size = new System.Drawing.Size(323, 368);
            this.radGrid.TabIndex = 10;
            this.radGrid.DoubleClick += new System.EventHandler(this.radGrid_DoubleClick);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(114, 105);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.ShowClearButton = true;
            this.txtdepartment.Size = new System.Drawing.Size(208, 24);
            this.txtdepartment.TabIndex = 11;
            // 
            // ClassDropdownlist
            // 
            this.ClassDropdownlist.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ClassDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassDropdownlist.Location = new System.Drawing.Point(114, 30);
            this.ClassDropdownlist.Name = "ClassDropdownlist";
            this.ClassDropdownlist.Size = new System.Drawing.Size(208, 24);
            this.ClassDropdownlist.TabIndex = 12;
            // 
            // DepartmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 368);
            this.Controls.Add(this.ClassDropdownlist);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.radGrid);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DepartmentFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفصول";
            this.Load += new System.EventHandler(this.DepartmentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDropdownlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadButton DeleteBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private Telerik.WinControls.UI.RadGridView radGrid;
        private Telerik.WinControls.UI.RadTextBox txtdepartment;
        private Telerik.WinControls.UI.RadDropDownList ClassDropdownlist;
    }
}