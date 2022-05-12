
namespace ManageBook.GUI
{
    partial class WareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouse));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgWarehouse = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(392, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(125, 27);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Quản Lý Kho";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Location = new System.Drawing.Point(486, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(335, 61);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(121, 21);
            this.txtGiaBan.TabIndex = 7;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Items.AddRange(new object[] {
            "Science Fiction",
            "Kinh Dị",
            "Trinh Thám",
            "Thiếu Nhi",
            "Kinh Tế",
            "Đời Sống",
            "Chính Trị",
            "Xã Hội",
            "Phụ Nữ",
            "Làm Đẹp"});
            this.cboTheLoai.Location = new System.Drawing.Point(335, 30);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cboTheLoai.TabIndex = 6;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(93, 57);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(154, 21);
            this.txtTacGia.TabIndex = 5;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(93, 30);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(154, 21);
            this.txtTenSach.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(272, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Giá Bán:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(272, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Thể Loại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tác Giả:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.cboTheLoai);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // dgWarehouse
            // 
            this.dgWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWarehouse.Location = new System.Drawing.Point(3, 148);
            this.dgWarehouse.Name = "dgWarehouse";
            this.dgWarehouse.Size = new System.Drawing.Size(958, 503);
            this.dgWarehouse.TabIndex = 6;
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 655);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgWarehouse);
            this.Name = "WareHouse";
            this.Text = "WareHouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgWarehouse;
    }
}