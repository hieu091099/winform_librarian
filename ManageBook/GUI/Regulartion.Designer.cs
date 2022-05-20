
namespace ManageBook.GUI
{
    partial class Regulartion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regulartion));
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dgQuyDinh = new System.Windows.Forms.DataGridView();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuyDinh = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new System.Windows.Forms.GroupBox();
            this.cboLoaiQuyDinh = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rbSuDung = new System.Windows.Forms.RadioButton();
            this.rbKhongSuDung = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuyDinh)).BeginInit();
            this.txtDiaChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(317, 30);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(99, 21);
            this.txtGiaTri.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(266, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Giá Trị:";
            // 
            // dgQuyDinh
            // 
            this.dgQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuyDinh.Location = new System.Drawing.Point(3, 159);
            this.dgQuyDinh.Name = "dgQuyDinh";
            this.dgQuyDinh.Size = new System.Drawing.Size(958, 489);
            this.dgQuyDinh.TabIndex = 5;
            this.dgQuyDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQuyDinh_CellClick);
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Location = new System.Drawing.Point(99, 69);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(83, 40);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(9, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuyDinh
            // 
            this.txtQuyDinh.Location = new System.Drawing.Point(81, 30);
            this.txtQuyDinh.Name = "txtQuyDinh";
            this.txtQuyDinh.ReadOnly = true;
            this.txtQuyDinh.Size = new System.Drawing.Size(154, 21);
            this.txtQuyDinh.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(703, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Loại Quy Định:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quy Định:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(405, 1);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 27);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Quy Định";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Controls.Add(this.rbKhongSuDung);
            this.txtDiaChi.Controls.Add(this.rbSuDung);
            this.txtDiaChi.Controls.Add(this.labelControl3);
            this.txtDiaChi.Controls.Add(this.cboLoaiQuyDinh);
            this.txtDiaChi.Controls.Add(this.txtGiaTri);
            this.txtDiaChi.Controls.Add(this.labelControl6);
            this.txtDiaChi.Controls.Add(this.btnReload);
            this.txtDiaChi.Controls.Add(this.btnSave);
            this.txtDiaChi.Controls.Add(this.txtQuyDinh);
            this.txtDiaChi.Controls.Add(this.labelControl2);
            this.txtDiaChi.Controls.Add(this.labelControl1);
            this.txtDiaChi.Location = new System.Drawing.Point(3, 34);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(958, 119);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.TabStop = false;
            this.txtDiaChi.Text = "Thông Tin";
            // 
            // cboLoaiQuyDinh
            // 
            this.cboLoaiQuyDinh.Enabled = false;
            this.cboLoaiQuyDinh.FormattingEnabled = true;
            this.cboLoaiQuyDinh.Items.AddRange(new object[] {
            "Nhập Sách",
            "Bán Sách"});
            this.cboLoaiQuyDinh.Location = new System.Drawing.Point(791, 31);
            this.cboLoaiQuyDinh.Name = "cboLoaiQuyDinh";
            this.cboLoaiQuyDinh.Size = new System.Drawing.Size(108, 21);
            this.cboLoaiQuyDinh.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(442, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Trạng Thái:";
            // 
            // rbSuDung
            // 
            this.rbSuDung.AutoSize = true;
            this.rbSuDung.Location = new System.Drawing.Point(509, 32);
            this.rbSuDung.Name = "rbSuDung";
            this.rbSuDung.Size = new System.Drawing.Size(65, 17);
            this.rbSuDung.TabIndex = 22;
            this.rbSuDung.TabStop = true;
            this.rbSuDung.Text = "Sử dụng";
            this.rbSuDung.UseVisualStyleBackColor = true;
            // 
            // rbKhongSuDung
            // 
            this.rbKhongSuDung.AutoSize = true;
            this.rbKhongSuDung.Location = new System.Drawing.Point(580, 32);
            this.rbKhongSuDung.Name = "rbKhongSuDung";
            this.rbKhongSuDung.Size = new System.Drawing.Size(99, 17);
            this.rbKhongSuDung.TabIndex = 23;
            this.rbKhongSuDung.TabStop = true;
            this.rbKhongSuDung.Text = "Không Sử Dụng";
            this.rbKhongSuDung.UseVisualStyleBackColor = true;
            // 
            // Regulartion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 650);
            this.Controls.Add(this.dgQuyDinh);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtDiaChi);
            this.Name = "Regulartion";
            this.Text = "Regulartion";
            this.Load += new System.EventHandler(this.Regulartion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuyDinh)).EndInit();
            this.txtDiaChi.ResumeLayout(false);
            this.txtDiaChi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.TextBox txtGiaTri;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DataGridView dgQuyDinh;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtQuyDinh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.GroupBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboLoaiQuyDinh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RadioButton rbKhongSuDung;
        private System.Windows.Forms.RadioButton rbSuDung;
    }
}