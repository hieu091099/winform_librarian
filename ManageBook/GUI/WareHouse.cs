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
    public partial class WareHouse : DevExpress.XtraEditors.XtraForm
    {
        public WareHouse()
        {
            InitializeComponent();
        }

        private void WareHouse_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                WareHouseBUS b = new WareHouseBUS();
                DataTable dt = b.getAll();
                dgWarehouse.DataSource = dt;
                
                dgWarehouse.Columns[0].HeaderText = "Tên Sách";
                dgWarehouse.Columns[1].HeaderText = "Tác Giả";
                dgWarehouse.Columns[2].HeaderText = "Giá";
                dgWarehouse.Columns[3].HeaderText = "Tổng Số Lượng";
                dgWarehouse.Columns[4].HeaderText = "Đã Bán";
                dgWarehouse.Columns[5].HeaderText = "Tồn Kho";
               
              
                dgWarehouse.Columns["price"].DefaultCellStyle.Format = "N2";


                
                dgWarehouse.Columns[0].Width = 300;
                dgWarehouse.Columns[1].Width = 120;
                dgWarehouse.Columns[2].Width = 90;
                dgWarehouse.Columns[3].Width = 60;
                dgWarehouse.Columns[4].Width = 60;
                dgWarehouse.Columns[5].Width = 60;
                

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var tenSach = txtTenSach.Text;
            var tacGia = txtTacGia.Text;
            var tuNgay = "";
            var denNgay = "";
            if (deTuNgay.EditValue != null)
            {
                tuNgay = deTuNgay.EditValue.ToString();
            }
            if (deDenNgay.EditValue != null)
            {
                denNgay = deDenNgay.EditValue.ToString();
            }

            WareHouseBUS bus = new WareHouseBUS();
            DataTable dt = bus.query(tenSach, tacGia, tuNgay, denNgay);
            //dgCustomers.DataSource = dt;
            dgWarehouse.DataSource = dt;
        }
    }
}
