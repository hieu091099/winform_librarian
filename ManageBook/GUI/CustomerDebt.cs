using DevExpress.XtraEditors;
using ManageBook.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBook.GUI
{
    public partial class CustomerDebt : DevExpress.XtraEditors.XtraForm
    {
        public CustomerDebt()
        {
            InitializeComponent();
        }

        private void CustomerDebt_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                CustomerBUS b = new CustomerBUS();
                DataTable dt = b.reportDebtCus();
                dgCustomer.DataSource = dt;
                dgCustomer.Columns[0].HeaderText = "Họ Tên";
                dgCustomer.Columns[1].HeaderText = "Mã Hóa Đơn";
                dgCustomer.Columns[2].HeaderText = "Tổng Tiền Hóa Đơn";
                dgCustomer.Columns[3].HeaderText = "Trả Trước";
                dgCustomer.Columns[4].HeaderText = "Còn Lại";
                dgCustomer.Columns[5].HeaderText = "Ngày Sinh";
                dgCustomer.Columns[6].HeaderText = "Địa Chỉ";
                dgCustomer.Columns["total"].DefaultCellStyle.Format = "N2";
                dgCustomer.Columns["payCus"].DefaultCellStyle.Format = "N2";
                dgCustomer.Columns["else"].DefaultCellStyle.Format = "N2";



                dgCustomer.Columns[0].Width = 150;
                dgCustomer.Columns[1].Width = 50;
                dgCustomer.Columns[2].Width = 100;
                dgCustomer.Columns[3].Width = 100;
                dgCustomer.Columns[4].Width = 100;
                dgCustomer.Columns[5].Width = 120;
                dgCustomer.Columns[6].Width = 300;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
