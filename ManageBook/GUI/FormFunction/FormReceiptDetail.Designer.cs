
namespace ManageBook.GUI.FormFunction
{
    partial class FormReceiptDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiptDetail));
            this.luSach = new DevExpress.XtraEditors.LookUpEdit();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTitle = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.luSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // luSach
            // 
            this.luSach.EditValue = "";
            this.luSach.Location = new System.Drawing.Point(97, 121);
            this.luSach.Name = "luSach";
            this.luSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luSach.Size = new System.Drawing.Size(216, 20);
            this.luSach.TabIndex = 66;
            this.luSach.EditValueChanged += new System.EventHandler(this.luSach_EditValueChanged);
            this.luSach.TextChanged += new System.EventHandler(this.luSach_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(97, 147);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(216, 21);
            this.txtQuantity.TabIndex = 64;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Số lượng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 124);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 62;
            this.labelControl1.Text = "Sách:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTitle.Location = new System.Drawing.Point(92, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(187, 27);
            this.lbTitle.TabIndex = 61;
            this.lbTitle.Text = "Chi tiết hóa đơn";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(190, 198);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(123, 36);
            this.simpleButton2.TabIndex = 60;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(70, 198);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 36);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 94);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(216, 21);
            this.txtId.TabIndex = 68;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "Mã HĐ:";
            // 
            // FormReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 262);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.luSach);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "FormReceiptDetail";
            this.Text = "FormReceiptDetail";
            this.Load += new System.EventHandler(this.FormReceiptDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luSach.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit luSach;
        private System.Windows.Forms.TextBox txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lbTitle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}