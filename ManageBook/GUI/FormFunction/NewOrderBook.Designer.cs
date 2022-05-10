
namespace ManageBook.GUI.FormFunction
{
    partial class NewOrderBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderBook));
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboSach = new DevExpress.XtraEditors.ComboBoxEdit();
            this.luSach = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tạo Phiếu Nhập Sách";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(153, 234);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(118, 36);
            this.simpleButton2.TabIndex = 37;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(35, 234);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 36);
            this.simpleButton1.TabIndex = 36;
            this.simpleButton1.Text = "Save";
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Items.AddRange(new object[] {
            "NXB Kim Đồng",
            "NXB Tư Pháp",
            "NXB Công An Nhân Dân",
            "NXB Quan Đội",
            "NXB Thanh Niên",
            "NXB Lao Động"});
            this.cboSupplier.Location = new System.Drawing.Point(103, 185);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(156, 21);
            this.cboSupplier.TabIndex = 35;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(103, 120);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 21);
            this.txtSoLuong.TabIndex = 34;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyUp);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 188);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Nhà Cung Ứng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Số Lượng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Tên Sách:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(103, 153);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(156, 21);
            this.txtGia.TabIndex = 41;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(72, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Giá:";
            // 
            // cboSach
            // 
            this.cboSach.Location = new System.Drawing.Point(103, 88);
            this.cboSach.Name = "cboSach";
            this.cboSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSach.Size = new System.Drawing.Size(156, 20);
            this.cboSach.TabIndex = 42;
            // 
            // luSach
            // 
            this.luSach.Location = new System.Drawing.Point(103, 62);
            this.luSach.Name = "luSach";
            this.luSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luSach.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luSach.Size = new System.Drawing.Size(156, 20);
            this.luSach.TabIndex = 43;
            // 
            // NewOrderBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 300);
            this.Controls.Add(this.luSach);
            this.Controls.Add(this.cboSach);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "NewOrderBook";
            this.Text = "NewOrderBook";
            this.Load += new System.EventHandler(this.NewOrderBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSach.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.TextBox txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtGia;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboSach;
        private DevExpress.XtraEditors.LookUpEdit luSach;
    }
}