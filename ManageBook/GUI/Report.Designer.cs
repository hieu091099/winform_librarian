
namespace ManageBook.GUI
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateReportBook = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.deDateToBook = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deDateFromBook = new DevExpress.XtraEditors.DateEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgReportBook = new System.Windows.Forms.DataGridView();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateReportDebt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.deDateToDebt = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.deDateFromDebt = new DevExpress.XtraEditors.DateEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgCongNo = new System.Windows.Forms.DataGridView();
            this.btnSearchDebt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToBook.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToBook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromBook.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromBook.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportBook)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToDebt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToDebt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromDebt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromDebt.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(960, 681);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panel1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(958, 637);
            this.xtraTabPage1.Text = "Báo Cáo Tồn Sách";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCreateReportBook);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.deDateToBook);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.deDateFromBook);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 637);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCreateReportBook
            // 
            this.btnCreateReportBook.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateReportBook.ImageOptions.SvgImage")));
            this.btnCreateReportBook.Location = new System.Drawing.Point(772, 47);
            this.btnCreateReportBook.Name = "btnCreateReportBook";
            this.btnCreateReportBook.Size = new System.Drawing.Size(104, 30);
            this.btnCreateReportBook.TabIndex = 29;
            this.btnCreateReportBook.Text = "Tạo Báo Cáo";
            this.btnCreateReportBook.Click += new System.EventHandler(this.btnCreateReportBook_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(461, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Đến Ngày:";
            // 
            // deDateToBook
            // 
            this.deDateToBook.EditValue = null;
            this.deDateToBook.Location = new System.Drawing.Point(524, 53);
            this.deDateToBook.Name = "deDateToBook";
            this.deDateToBook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateToBook.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateToBook.Size = new System.Drawing.Size(134, 20);
            this.deDateToBook.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Từ Ngày:";
            // 
            // deDateFromBook
            // 
            this.deDateFromBook.EditValue = null;
            this.deDateFromBook.Location = new System.Drawing.Point(300, 52);
            this.deDateFromBook.Name = "deDateFromBook";
            this.deDateFromBook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFromBook.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFromBook.Size = new System.Drawing.Size(134, 20);
            this.deDateFromBook.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgReportBook);
            this.panel3.Location = new System.Drawing.Point(5, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 533);
            this.panel3.TabIndex = 24;
            // 
            // dgReportBook
            // 
            this.dgReportBook.AllowUserToAddRows = false;
            this.dgReportBook.AllowUserToDeleteRows = false;
            this.dgReportBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportBook.Location = new System.Drawing.Point(3, 3);
            this.dgReportBook.Name = "dgReportBook";
            this.dgReportBook.Size = new System.Drawing.Size(945, 527);
            this.dgReportBook.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Location = new System.Drawing.Point(676, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Tên Sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(77, 52);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(154, 21);
            this.txtTenSach.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(353, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(178, 27);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Báo Cáo Tồn Sách";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panel2);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(958, 637);
            this.xtraTabPage2.Text = "Báo Cáo Công Nợ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCreateReportDebt);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.deDateToDebt);
            this.panel2.Controls.Add(this.labelControl8);
            this.panel2.Controls.Add(this.deDateFromDebt);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnSearchDebt);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.txtTenKhachHang);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 637);
            this.panel2.TabIndex = 0;
            // 
            // btnCreateReportDebt
            // 
            this.btnCreateReportDebt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateReportDebt.ImageOptions.SvgImage")));
            this.btnCreateReportDebt.Location = new System.Drawing.Point(807, 39);
            this.btnCreateReportDebt.Name = "btnCreateReportDebt";
            this.btnCreateReportDebt.Size = new System.Drawing.Size(104, 30);
            this.btnCreateReportDebt.TabIndex = 37;
            this.btnCreateReportDebt.Text = "Tạo Báo Cáo";
            this.btnCreateReportDebt.Click += new System.EventHandler(this.btnCreateReportDebt_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(492, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Đến Ngày:";
            // 
            // deDateToDebt
            // 
            this.deDateToDebt.EditValue = null;
            this.deDateToDebt.Location = new System.Drawing.Point(555, 44);
            this.deDateToDebt.Name = "deDateToDebt";
            this.deDateToDebt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateToDebt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateToDebt.Size = new System.Drawing.Size(134, 20);
            this.deDateToDebt.TabIndex = 35;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(280, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Từ Ngày:";
            // 
            // deDateFromDebt
            // 
            this.deDateFromDebt.EditValue = null;
            this.deDateFromDebt.Location = new System.Drawing.Point(331, 43);
            this.deDateFromDebt.Name = "deDateFromDebt";
            this.deDateFromDebt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFromDebt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFromDebt.Size = new System.Drawing.Size(134, 20);
            this.deDateFromDebt.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgCongNo);
            this.panel4.Location = new System.Drawing.Point(4, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(951, 547);
            this.panel4.TabIndex = 32;
            // 
            // dgCongNo
            // 
            this.dgCongNo.AllowUserToAddRows = false;
            this.dgCongNo.AllowUserToDeleteRows = false;
            this.dgCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCongNo.Location = new System.Drawing.Point(3, 3);
            this.dgCongNo.Name = "dgCongNo";
            this.dgCongNo.Size = new System.Drawing.Size(948, 541);
            this.dgCongNo.TabIndex = 0;
            // 
            // btnSearchDebt
            // 
            this.btnSearchDebt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearchDebt.ImageOptions.SvgImage")));
            this.btnSearchDebt.Location = new System.Drawing.Point(711, 39);
            this.btnSearchDebt.Name = "btnSearchDebt";
            this.btnSearchDebt.Size = new System.Drawing.Size(90, 30);
            this.btnSearchDebt.TabIndex = 28;
            this.btnSearchDebt.Text = "Search";
            this.btnSearchDebt.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 13);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Tên Khách Hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(108, 43);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(154, 21);
            this.txtTenKhachHang.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(354, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 27);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Báo Cáo Công Nợ";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(960, 681);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToBook.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToBook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromBook.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromBook.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReportBook)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToDebt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateToDebt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromDebt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFromDebt.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCongNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgReportBook;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgCongNo;
        private DevExpress.XtraEditors.SimpleButton btnSearchDebt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deDateToBook;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deDateFromBook;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit deDateToDebt;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit deDateFromDebt;
        private DevExpress.XtraEditors.SimpleButton btnCreateReportBook;
        private DevExpress.XtraEditors.SimpleButton btnCreateReportDebt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
