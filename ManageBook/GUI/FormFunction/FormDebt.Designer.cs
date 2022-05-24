
namespace ManageBook.GUI.FormFunction
{
    partial class FormDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebt));
            this.luKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTitle = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deNgayThu = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.luKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // luKhachHang
            // 
            this.luKhachHang.EditValue = "";
            this.luKhachHang.Location = new System.Drawing.Point(107, 91);
            this.luKhachHang.Name = "luKhachHang";
            this.luKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luKhachHang.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.luKhachHang.Size = new System.Drawing.Size(185, 20);
            this.luKhachHang.TabIndex = 66;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 62;
            this.labelControl1.Text = "Khách Hàng:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTitle.Location = new System.Drawing.Point(88, 41);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(204, 27);
            this.lbTitle.TabIndex = 61;
            this.lbTitle.Text = "Tạo Phiếu Thu Nợ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(187, 255);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(123, 36);
            this.simpleButton2.TabIndex = 60;
            this.simpleButton2.Text = "Exit";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(67, 255);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 36);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 67;
            this.labelControl2.Text = "Tổng Nợ:";
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(107, 125);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(185, 21);
            this.txtDebt.TabIndex = 68;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 69;
            this.labelControl3.Text = "Số Tiền Thu:";
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(107, 163);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(185, 21);
            this.txtGet.TabIndex = 70;
            this.txtGet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGet_KeyUp);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 204);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 71;
            this.labelControl4.Text = "Ngày Thu Tiền:";
            // 
            // deNgayThu
            // 
            this.deNgayThu.EditValue = null;
            this.deNgayThu.Location = new System.Drawing.Point(107, 201);
            this.deNgayThu.Name = "deNgayThu";
            this.deNgayThu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayThu.Size = new System.Drawing.Size(185, 20);
            this.deNgayThu.TabIndex = 72;
            // 
            // FormDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 322);
            this.Controls.Add(this.deNgayThu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.luKhachHang);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "FormDebt";
            this.Text = "FormDebt";
            this.Load += new System.EventHandler(this.FormDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayThu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit luKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lbTitle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtDebt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtGet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deNgayThu;
    }
}