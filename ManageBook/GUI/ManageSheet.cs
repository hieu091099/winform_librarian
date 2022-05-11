using DevExpress.XtraEditors;
using ManageBook.BUS;
using ManageBook.DTO;
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
    public partial class ManageSheet : DevExpress.XtraEditors.XtraUserControl
    {
        OrderBookDTO RowSelected;
        public ManageSheet()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewOrderBook formEdit = new NewOrderBook();
            formEdit.TypeForm = "insert";
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                OrderBookBUS b = new OrderBookBUS();
                DataTable dt = b.getAll();
                dgOrderBook.DataSource = dt;
                dgOrderBook.Columns[0].HeaderText = "ID";
                dgOrderBook.Columns[1].HeaderText = "Tên Sách";
                dgOrderBook.Columns[2].HeaderText = "Tác Giả";
                dgOrderBook.Columns[3].HeaderText = "Thể Loại";
                dgOrderBook.Columns[4].HeaderText = "Số Lượng";
                dgOrderBook.Columns[5].HeaderText = "Giá";
                dgOrderBook.Columns[6].HeaderText = "Nhà Cung Ứng";
                dgOrderBook.Columns[7].HeaderText = "Người Tạo Phiếu";
                dgOrderBook.Columns[8].HeaderText = "Ngày Tạo Phiếu";
                dgOrderBook.Columns[9].HeaderText = "Ngày Cập Nhật";
                dgOrderBook.Columns[10].HeaderText = "IDBook";
                dgOrderBook.Columns["idBook"].Visible = false;



                dgOrderBook.Columns[0].Width = 30;
                dgOrderBook.Columns[1].Width = 300;
                dgOrderBook.Columns[2].Width = 100;
                dgOrderBook.Columns[3].Width = 100;
                dgOrderBook.Columns[4].Width = 40;
                dgOrderBook.Columns[5].Width = 80;
                dgOrderBook.Columns[6].Width = 100;
                dgOrderBook.Columns[7].Width = 100;
                dgOrderBook.Columns[8].Width = 120;
                dgOrderBook.Columns[9].Width = 120;


                if (dt.Rows.Count > 0)
                {
                    dgOrderBook.Rows[0].Selected = true;
                    RowSelected = new OrderBookDTO();
                    RowSelected.Id = Int32.Parse(dgOrderBook.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.IdBook = Int32.Parse(dgOrderBook.SelectedRows[0].Cells["idBook"].Value.ToString());
                    RowSelected.Quantity = Int32.Parse(dgOrderBook.SelectedRows[0].Cells["quantity"].Value.ToString());
                    RowSelected.Price = Convert.ToDouble(dgOrderBook.SelectedRows[0].Cells["quantity"].Value.ToString());
                    RowSelected.Supplier = dgOrderBook.SelectedRows[0].Cells["supplier"].Value.ToString();
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //LoadData();
        }

       

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NewOrderBook formEdit = new NewOrderBook();
            formEdit.TypeForm = "edit";
            formEdit.Book = RowSelected;
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
            LoadData();
        }

        private void dgOrderBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgOrderBook.Rows[index];
            RowSelected = new OrderBookDTO();
            RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
            RowSelected.IdBook = Int32.Parse(row.Cells["idBook"].Value.ToString());
            RowSelected.Price = double.Parse(row.Cells["price"].Value.ToString());
            RowSelected.Quantity = Int32.Parse(row.Cells["quantity"].Value.ToString());
            RowSelected.Supplier = row.Cells["supplier"].Value.ToString();

            MessageBox.Show(RowSelected.Supplier);
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ManageSheet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgOrderBook_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgOrderBook.Rows[index];
            RowSelected = new OrderBookDTO();
            RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
            RowSelected.IdBook = Int32.Parse(row.Cells["idBook"].Value.ToString());
            RowSelected.Price = double.Parse(row.Cells["price"].Value.ToString());
            RowSelected.Quantity = Int32.Parse(row.Cells["quantity"].Value.ToString());
            RowSelected.Supplier = row.Cells["supplier"].Value.ToString();

           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu  '{RowSelected.Id}!'", "Thông Báo!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (RowSelected != null)
                {
                    try
                    {

                        OrderBookBUS bus = new OrderBookBUS();
                        bus.remove(RowSelected.Id);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
               
                var nameBook = txtTenSach.Text;
                var author = txtTacGia.Text;
                var kind = "";
                if(cboTheLoai.SelectedIndex != -1)
                {
                    kind = cboTheLoai.SelectedItem.ToString();
                }
                OrderBookBUS bus = new OrderBookBUS();
                DataTable dt = bus.queryOrder(nameBook, author, kind);
                
                dgOrderBook.DataSource = dt;
                dgOrderBook.Columns[0].HeaderText = "ID";
                dgOrderBook.Columns[1].HeaderText = "Tên Sách";
                dgOrderBook.Columns[2].HeaderText = "Tác Giả";
                dgOrderBook.Columns[3].HeaderText = "Thể Loại";
                dgOrderBook.Columns[4].HeaderText = "Tên Sách";
                dgOrderBook.Columns[5].HeaderText = "Số Lượng";
                dgOrderBook.Columns[6].HeaderText = "Giá";
                dgOrderBook.Columns[7].HeaderText = "Nhà Cung Ứng";
                dgOrderBook.Columns[8].HeaderText = "Người Tạo Phiếu";
                dgOrderBook.Columns[9].HeaderText = "Ngày Tạo Phiếu";
                dgOrderBook.Columns[10].HeaderText = "Ngày Cập Nhật";
                dgOrderBook.Columns[11].HeaderText = "IDBook";
                dgOrderBook.Columns["idBook"].Visible = false;



                dgOrderBook.Columns[0].Width = 30;
                dgOrderBook.Columns[1].Width = 300;
                dgOrderBook.Columns[2].Width = 100;
                dgOrderBook.Columns[3].Width = 100;
                dgOrderBook.Columns[4].Width = 40;
                dgOrderBook.Columns[5].Width = 80;
                dgOrderBook.Columns[6].Width = 100;
                dgOrderBook.Columns[7].Width = 100;
                dgOrderBook.Columns[8].Width = 120;
                dgOrderBook.Columns[9].Width = 120;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
