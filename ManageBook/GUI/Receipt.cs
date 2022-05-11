using DevExpress.XtraEditors;
using ManageBook.BUS;
using ManageBook.GUI.FormFunction;
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
    public partial class Receipt : DevExpress.XtraEditors.XtraForm
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormReceipt formEdit = new FormReceipt();
            formEdit.TypeForm = "insert";
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                ReceiptBUS b = new ReceiptBUS();
                DataTable dt = b.getAllReceipt();
                dgReceipt.DataSource = dt;
                dgReceipt.Columns[0].HeaderText = "ID";
                dgReceipt.Columns[1].HeaderText = "Khách Hàng";
                dgReceipt.Columns[2].HeaderText = "Trạng Thái";
                dgReceipt.Columns[3].HeaderText = "Trả Trước";
                dgReceipt.Columns[4].HeaderText = "NV Tạo Hóa Đơn";
                dgReceipt.Columns[5].HeaderText = "Ngày Tạo Hóa Đơn";

                dgReceipt.Columns[0].Width = 30;
                dgReceipt.Columns[1].Width = 100;
                dgReceipt.Columns[2].Width = 60;
                dgReceipt.Columns[3].Width = 50;
                dgReceipt.Columns[4].Width = 90;
                dgReceipt.Columns[5].Width = 120;

                if (dt.Rows.Count > 0)
                {
                    //dgReceipt.Rows[0].Selected = true;
                    //RowSelected = new BookDTO();
                    //RowSelected.Id = Int32.Parse(dgReceipt.SelectedRows[0].Cells["id"].Value.ToString());
                    //RowSelected.NameBook = dgReceipt.SelectedRows[0].Cells["nameBook"].Value.ToString();
                    //RowSelected.Price = double.Parse(dgReceipt.SelectedRows[0].Cells["price"].Value.ToString());
                    //RowSelected.Kind = dgReceipt.SelectedRows[0].Cells["kind"].Value.ToString();
                    //RowSelected.Author = dgReceipt.SelectedRows[0].Cells["author"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
