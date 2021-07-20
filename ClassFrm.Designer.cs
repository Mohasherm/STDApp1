
namespace STDApp
{
    partial class ClassFrm
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.RadGrid = new Telerik.WinControls.UI.RadGridView();
            this.radPanel = new Telerik.WinControls.UI.RadPanel();
            this.DeleteBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.txtclass = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RadGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel)).BeginInit();
            this.radPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtclass)).BeginInit();
            this.SuspendLayout();
            // 
            // RadGrid
            // 
            this.RadGrid.BackColor = System.Drawing.SystemColors.Control;
            this.RadGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RadGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RadGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RadGrid.Location = new System.Drawing.Point(0, 71);
            // 
            // 
            // 
            this.RadGrid.MasterTemplate.AllowAddNewRow = false;
            this.RadGrid.MasterTemplate.AllowDeleteRow = false;
            this.RadGrid.MasterTemplate.AllowEditRow = false;
            this.RadGrid.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "#";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "الصف";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 210;
            this.RadGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.RadGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.RadGrid.MasterTemplate.EnableFiltering = true;
            this.RadGrid.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "ID";
            this.RadGrid.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.RadGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RadGrid.Name = "RadGrid";
            this.RadGrid.ReadOnly = true;
            this.RadGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadGrid.Size = new System.Drawing.Size(537, 306);
            this.RadGrid.TabIndex = 8;
            this.RadGrid.DoubleClick += new System.EventHandler(this.RadGrid_DoubleClick);
            // 
            // radPanel
            // 
            this.radPanel.Controls.Add(this.DeleteBtn);
            this.radPanel.Controls.Add(this.CancelBtn);
            this.radPanel.Controls.Add(this.AddBtn);
            this.radPanel.Controls.Add(this.txtclass);
            this.radPanel.Controls.Add(this.label1);
            this.radPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel.Location = new System.Drawing.Point(0, 0);
            this.radPanel.Name = "radPanel";
            this.radPanel.Size = new System.Drawing.Size(537, 65);
            this.radPanel.TabIndex = 9;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteBtn.Location = new System.Drawing.Point(103, 12);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 42);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(12, 12);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(85, 42);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(194, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(85, 42);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "إضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // txtclass
            // 
            this.txtclass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtclass.Location = new System.Drawing.Point(285, 20);
            this.txtclass.Name = "txtclass";
            // 
            // 
            // 
            this.txtclass.RootElement.Shape = null;
            this.txtclass.ShowClearButton = true;
            this.txtclass.Size = new System.Drawing.Size(176, 27);
            this.txtclass.TabIndex = 4;
            this.txtclass.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم الصف";
            // 
            // ClassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 377);
            this.Controls.Add(this.radPanel);
            this.Controls.Add(this.RadGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClassFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصفوف";
            this.Load += new System.EventHandler(this.ClassFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel)).EndInit();
            this.radPanel.ResumeLayout(false);
            this.radPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView RadGrid;
        private Telerik.WinControls.UI.RadPanel radPanel;
        private Telerik.WinControls.UI.RadButton DeleteBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadTextBox txtclass;
        private System.Windows.Forms.Label label1;
    }
}