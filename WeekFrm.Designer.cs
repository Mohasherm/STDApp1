
namespace STDApp
{
    partial class WeekFrm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.datefrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateto = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtweeknumber = new Telerik.WinControls.UI.RadTextBox();
            this.radGrid = new Telerik.WinControls.UI.RadGridView();
            this.DeleteBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.datefrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtweeknumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // datefrom
            // 
            this.datefrom.Culture = new System.Globalization.CultureInfo("ar-SA");
            this.datefrom.CustomFormat = "dd / MMMM / yyyy";
            this.datefrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefrom.Location = new System.Drawing.Point(111, 82);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(208, 27);
            this.datefrom.TabIndex = 0;
            this.datefrom.TabStop = false;
            this.datefrom.Text = "11 / ذو القعدة / 1442";
            this.datefrom.Value = new System.DateTime(2021, 6, 21, 23, 0, 27, 610);
            // 
            // dateto
            // 
            this.dateto.Culture = new System.Globalization.CultureInfo("ar-SA");
            this.dateto.CustomFormat = "dd / MMMM / yyyy";
            this.dateto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateto.Location = new System.Drawing.Point(111, 140);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(208, 27);
            this.dateto.TabIndex = 1;
            this.dateto.TabStop = false;
            this.dateto.Text = "11 / ذو القعدة / 1442";
            this.dateto.Value = new System.DateTime(2021, 6, 21, 23, 0, 27, 610);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(12, 27);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(87, 25);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "رقم الأسبوع";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(12, 82);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 25);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "من تاريخ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(12, 140);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(69, 25);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "إلى تاريخ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtweeknumber
            // 
            this.txtweeknumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtweeknumber.Location = new System.Drawing.Point(111, 27);
            this.txtweeknumber.Name = "txtweeknumber";
            this.txtweeknumber.Size = new System.Drawing.Size(208, 27);
            this.txtweeknumber.TabIndex = 0;
            this.txtweeknumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtweeknumber_KeyPress);
            // 
            // radGrid
            // 
            this.radGrid.BackColor = System.Drawing.SystemColors.Control;
            this.radGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.radGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGrid.Location = new System.Drawing.Point(328, 0);
            // 
            // 
            // 
            this.radGrid.MasterTemplate.AllowAddNewRow = false;
            this.radGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn5.FieldName = "ID";
            gridViewTextBoxColumn5.HeaderText = "ID";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ID";
            gridViewTextBoxColumn6.FieldName = "Number";
            gridViewTextBoxColumn6.HeaderText = "رقم الأسبوع";
            gridViewTextBoxColumn6.Name = "Number";
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.FieldName = "Start";
            gridViewTextBoxColumn7.FormatInfo = new System.Globalization.CultureInfo("ar-SA");
            gridViewTextBoxColumn7.HeaderText = "من تاريخ";
            gridViewTextBoxColumn7.Name = "Start";
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn8.FieldName = "Finish";
            gridViewTextBoxColumn8.FormatInfo = new System.Globalization.CultureInfo("ar-SA");
            gridViewTextBoxColumn8.HeaderText = "إلى تاريخ";
            gridViewTextBoxColumn8.Name = "Finish";
            gridViewTextBoxColumn8.Width = 150;
            this.radGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.radGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGrid.MasterTemplate.EnableFiltering = true;
            this.radGrid.MasterTemplate.EnableGrouping = false;
            this.radGrid.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGrid.Name = "radGrid";
            this.radGrid.ReadOnly = true;
            this.radGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGrid.Size = new System.Drawing.Size(425, 294);
            this.radGrid.TabIndex = 5;
            this.radGrid.DoubleClick += new System.EventHandler(this.radGrid_DoubleClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteBtn.Location = new System.Drawing.Point(111, 208);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 39);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "حذف";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(226, 208);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(93, 39);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "الغاء";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddBtn.Location = new System.Drawing.Point(12, 208);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(93, 39);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "إضافة";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // WeekFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 294);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.radGrid);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.txtweeknumber);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WeekFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأسابيع الدراسية";
            this.Load += new System.EventHandler(this.WeekFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datefrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtweeknumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker datefrom;
        private Telerik.WinControls.UI.RadDateTimePicker dateto;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtweeknumber;
        private Telerik.WinControls.UI.RadGridView radGrid;
        private Telerik.WinControls.UI.RadButton DeleteBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private Telerik.WinControls.UI.RadButton AddBtn;
    }
}