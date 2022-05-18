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
    public partial class Report : DevExpress.XtraEditors.XtraUserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        public void LoadDataTonSach()
        {
            try
            {
                BookBUS b = new BookBUS();
                DataTable dt = b.reportBook();
                dgReportBook.DataSource = dt;
                dgReportBook.Columns[0].HeaderText = "Mã Sách";
                dgReportBook.Columns[1].HeaderText = "Tên Sách";
                dgReportBook.Columns[2].HeaderText = "Tác Giả";
                dgReportBook.Columns[3].HeaderText = "Thể Loại";
                dgReportBook.Columns[4].HeaderText = "Tồn Đầu";
                dgReportBook.Columns[5].HeaderText = "Phát Sinh";
                dgReportBook.Columns[6].HeaderText = "Tồn Cuối";


                dgReportBook.Columns[0].Width = 40;
                dgReportBook.Columns[1].Width = 360;
                dgReportBook.Columns[2].Width = 150;
                dgReportBook.Columns[3].Width = 100;
                dgReportBook.Columns[4].Width = 80;
                dgReportBook.Columns[5].Width = 80;
                dgReportBook.Columns[6].Width = 80;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LoadDataCongNo()
        {
            try
            {
                CustomerBUS b = new CustomerBUS();
                DataTable dt = b.reportDebt();
                dgCongNo.DataSource = dt;
                dgCongNo.Columns[0].HeaderText = "Mã KH";
                dgCongNo.Columns[1].HeaderText = "Họ Tên";
                dgCongNo.Columns[2].HeaderText = "Nợ Đầu";
                dgCongNo.Columns[3].HeaderText = "Phát Sinh";
                dgCongNo.Columns[4].HeaderText = "Nợ Cuối";
                dgCongNo.Columns[5].HeaderText = "Ngày Sinh";
                dgCongNo.Columns[6].HeaderText = "Địa Chỉ";
                dgCongNo.Columns["NoDau"].DefaultCellStyle.Format = "N2";
                dgCongNo.Columns["PhatSinh"].DefaultCellStyle.Format = "N2";
                dgCongNo.Columns["TongNo"].DefaultCellStyle.Format = "N2";



                dgCongNo.Columns[0].Width = 40;
                dgCongNo.Columns[1].Width = 130;
                dgCongNo.Columns[2].Width = 100;
                dgCongNo.Columns[3].Width = 100;
                dgCongNo.Columns[4].Width = 100;
                dgCongNo.Columns[5].Width = 120;
                dgCongNo.Columns[6].Width = 300;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            LoadDataTonSach();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadDataTonSach();
            LoadDataCongNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                var tenSach = txtTenSach.Text;
                var dateFrom = "";
                var dateTo = "";
                if (deDateFromBook.EditValue != null)
                {
                    dateFrom = deDateFromBook.EditValue.ToString();
                }
                if (deDateToBook.EditValue != null)
                {
                    dateTo = deDateToBook.EditValue.ToString();
                }

                BookBUS bus = new BookBUS();
                DataTable dt = bus.reportBookQuery(tenSach, dateFrom, dateTo);
                //dgCustomers.DataSource = dt;
                dgReportBook.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                var tenKhachHang = txtTenKhachHang.Text;
                var dateFrom = "";
                var dateTo = "";
                if (deDateFromDebt.EditValue != null)
                {
                    dateFrom = deDateFromDebt.EditValue.ToString();
                }
                if (deDateToDebt.EditValue != null)
                {
                    dateTo = deDateToDebt.EditValue.ToString();
                }

                CustomerBUS bus = new CustomerBUS();
                DataTable dt = bus.reportDebtQuery(tenKhachHang, dateFrom, dateTo);
                //dgCustomers.DataSource = dt;
                dgCongNo.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
