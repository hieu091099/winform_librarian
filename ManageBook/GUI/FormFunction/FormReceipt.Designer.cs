
namespace ManageBook.GUI.FormFunction
{
    partial class FormReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPayCus = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTitle = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.luKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.luKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(58, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "Trạng Thái:";
            // 
            // txtPayCus
            // 
            this.txtPayCus.Location = new System.Drawing.Point(128, 137);
            this.txtPayCus.Name = "txtPayCus";
            this.txtPayCus.Size = new System.Drawing.Size(216, 21);
            this.txtPayCus.TabIndex = 49;
            this.txtPayCus.TextChanged += new System.EventHandler(this.txtPayCus_TextChanged);
            this.txtPayCus.Enter += new System.EventHandler(this.txtPayCus_Enter);
            this.txtPayCus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPayCus_KeyUp);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "KH Trả Trước:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Khách Hàng:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTitle.Location = new System.Drawing.Point(123, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(153, 27);
            this.lbTitle.TabIndex = 44;
            this.lbTitle.Text = "Tạo Hóa Đơn";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(209, 191);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(123, 36);
            this.simpleButton2.TabIndex = 43;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(89, 191);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 36);
            this.simpleButton1.TabIndex = 42;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // luKhachHang
            // 
            this.luKhachHang.EditValue = "";
            this.luKhachHang.Location = new System.Drawing.Point(128, 79);
            this.luKhachHang.Name = "luKhachHang";
            this.luKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luKhachHang.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.luKhachHang.Size = new System.Drawing.Size(216, 20);
            this.luKhachHang.TabIndex = 57;
            this.luKhachHang.EditValueChanged += new System.EventHandler(this.luKhachHang_EditValueChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoàn Tất",
            "Trả Trước"});
            this.cboTrangThai.Location = new System.Drawing.Point(128, 110);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(216, 21);
            this.cboTrangThai.TabIndex = 58;
            this.cboTrangThai.TextChanged += new System.EventHandler(this.cboTrangThai_TextChanged);
            this.cboTrangThai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboTrangThai_KeyUp);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.luKhachHang);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPayCus);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtPayCus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lbTitle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit luKhachHang;
        private System.Windows.Forms.ComboBox cboTrangThai;
    }
}