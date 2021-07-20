
namespace STDApp
{
    partial class PointsFrm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radDropDepartment = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new System.Windows.Forms.Label();
            this.radDropclasses = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.lblweek = new System.Windows.Forms.Label();
            this.lstweek = new Telerik.WinControls.UI.RadListView();
            this.btnCalc = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.weekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstweek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radDropDepartment);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.radDropclasses);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(679, 51);
            this.radPanel1.TabIndex = 2;
            // 
            // radDropDepartment
            // 
            this.radDropDepartment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDepartment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropDepartment.Location = new System.Drawing.Point(40, 12);
            this.radDropDepartment.Name = "radDropDepartment";
            this.radDropDepartment.Size = new System.Drawing.Size(222, 27);
            this.radDropDepartment.TabIndex = 37;
            this.radDropDepartment.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(268, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "الفصل";
            // 
            // radDropclasses
            // 
            this.radDropclasses.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropclasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radDropclasses.Location = new System.Drawing.Point(349, 12);
            this.radDropclasses.Name = "radDropclasses";
            this.radDropclasses.Size = new System.Drawing.Size(222, 27);
            this.radDropclasses.TabIndex = 35;
            this.radDropclasses.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropclasses_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(584, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "الصف";
            // 
            // lblweek
            // 
            this.lblweek.AutoSize = true;
            this.lblweek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblweek.Location = new System.Drawing.Point(12, 57);
            this.lblweek.Name = "lblweek";
            this.lblweek.Size = new System.Drawing.Size(58, 21);
            this.lblweek.TabIndex = 42;
            this.lblweek.Text = "الأسبوع";
            // 
            // lstweek
            // 
            this.lstweek.AllowColumnReorder = false;
            this.lstweek.AllowEdit = false;
            this.lstweek.AllowRemove = false;
            this.lstweek.DisplayMember = "Number";
            this.lstweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstweek.Location = new System.Drawing.Point(76, 57);
            this.lstweek.MultiSelect = true;
            this.lstweek.Name = "lstweek";
            this.lstweek.Size = new System.Drawing.Size(216, 326);
            this.lstweek.TabIndex = 0;
            this.lstweek.ValueMember = "ID";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalc.Location = new System.Drawing.Point(76, 389);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(216, 49);
            this.btnCalc.TabIndex = 43;
            this.btnCalc.Text = "حساب النقاط";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(298, 51);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "الطالب";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 225;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Points";
            gridViewTextBoxColumn3.HeaderText = "النقاط";
            gridViewTextBoxColumn3.Name = "Points";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn3.Width = 123;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Points";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(381, 399);
            this.radGridView1.TabIndex = 44;
            // 
            // weekBindingSource
            // 
            this.weekBindingSource.DataSource = typeof(STDApp.Week);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(STDApp.Student);
            // 
            // PointsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lstweek);
            this.Controls.Add(this.lblweek);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PointsFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة النقاط";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PointsFrm_FormClosed);
            this.Load += new System.EventHandler(this.PointsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropclasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstweek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDepartment;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList radDropclasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblweek;
        private Telerik.WinControls.UI.RadListView lstweek;
        private System.Windows.Forms.BindingSource weekBindingSource;
        private Telerik.WinControls.UI.RadButton btnCalc;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}