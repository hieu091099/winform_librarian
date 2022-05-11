using DevExpress.XtraEditors;
using ManageBook.BUS;
using ManageBook.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBook.GUI.FormFunction
{
    public partial class FormReceipt : DevExpress.XtraEditors.XtraForm
    {
        private string _typeForm;
        public int seletedCus;
        public FormReceipt()
        {
            InitializeComponent();
        }

        public string TypeForm { get => _typeForm; set => _typeForm = value; }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            CustomerBUS bus = new CustomerBUS();
            DataTable dt = bus.getAllCustomers();
            dt.Columns.Remove("gender");
            dt.Columns.Remove("birthday");
            dt.Columns.Remove("email");
            dt.Columns.Remove("phone");
            dt.Columns.Remove("address");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            luKhachHang.Properties.DataSource = ds.Tables[0].DefaultView;
            luKhachHang.Properties.ForceInitialize();
            luKhachHang.Properties.PopulateColumns();
            luKhachHang.Properties.ValueMember = "id";
            luKhachHang.Properties.DisplayMember = "fullName";
            luKhachHang.Properties.Columns[1].Caption = "Họ Tên";
            luKhachHang.Properties.Columns[0].Width = 30;
            luKhachHang.Properties.Columns[1].Width = 200;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeForm == "insert")
                {
                    ReceiptDTO b = new ReceiptDTO();
                    b.IdCus = seletedCus;
                    b.Status = cboTrangThai.SelectedItem.ToString();
                    if (txtPayCus.Text != "")
                    {
                        b.PayCus = Convert.ToDouble(txtPayCus.Text);
                    }

                    ReceiptBUS bus = new ReceiptBUS();
                    if (bus.insertReceipt(b) == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!", ex.Message);
            }
        }

        private void luKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookUp = sender as LookUpEdit;
            // Access the currently selected data row
            DataRowView dataRow = lookUp.GetSelectedDataRow() as DataRowView;
            // Assign the row's Picture field value to the PictureEdit control
            if (dataRow != null)
            {
                seletedCus = Int32.Parse(dataRow["id"].ToString());
            }
            
            
        }

        private void cboTrangThai_TextChanged(object sender, EventArgs e)
        {
            if(cboTrangThai.SelectedItem == "Hoàn Tất")
            {
                txtPayCus.ReadOnly = true;
            }
        }
    }
}
