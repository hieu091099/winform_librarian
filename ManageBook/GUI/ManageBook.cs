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

namespace ManageBook.GUI
{
    public partial class ManageBook : DevExpress.XtraEditors.XtraForm
    {
        BookDTO RowSelected;
        public ManageBook()
        {
            InitializeComponent();
            LoadData();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            //navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                BookDTO b = new BookDTO();
                b.NameBook = txtTenSach.Text;
                b.Author = txtTacGia.Text;
                b.Price = double.Parse(txtGiaBan.Text);
                b.Kind = cboTheLoai.SelectedItem.ToString();
                BookBUS bus = new BookBUS();
                bus.insertBook(b);

                LoadData();

            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void LoadData()
        {
            try
            {
                BookBUS b = new BookBUS();
                DataTable dt = b.getAllBooks();
                dgBooks.DataSource = dt;
                dgBooks.Columns[0].HeaderText = "ID";
                dgBooks.Columns[1].HeaderText = "Tên Sách";
                dgBooks.Columns[2].HeaderText = "Hình Ảnh";
                dgBooks.Columns[3].HeaderText = "Thể Loại";
                dgBooks.Columns[4].HeaderText = "Tác Giả";
                dgBooks.Columns[5].HeaderText = "Giá";

                dgBooks.Columns[0].Width = 40;
                dgBooks.Columns[1].Width = 300;
                dgBooks.Columns[2].Width = 80;
                dgBooks.Columns[3].Width = 80;
                dgBooks.Columns[4].Width = 250;
                dgBooks.Columns[5].Width = 100;

                if (dt.Rows.Count > 0)
                {
                    dgBooks.Rows[0].Selected = true;
                    RowSelected = new BookDTO();
                    RowSelected.Id = Int32.Parse(dgBooks.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.NameBook = dgBooks.SelectedRows[0].Cells["nameBook"].Value.ToString();
                    RowSelected.Price = double.Parse(dgBooks.SelectedRows[0].Cells["price"].Value.ToString());
                    RowSelected.Kind = dgBooks.SelectedRows[0].Cells["kind"].Value.ToString();
                    RowSelected.Author = dgBooks.SelectedRows[0].Cells["author"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pbBook.Image = new Bitmap(of.FileName);
                pbBook.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            pbBook.Image = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa quyển sách '{RowSelected.NameBook}!'", "Thông Báo!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if(RowSelected != null)
                {
                    try
                    {

                        BookBUS bus = new BookBUS();
                        bus.removeBook(RowSelected.Id);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
               
            }
            
        }
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgBooks.Rows[index];
            RowSelected = new BookDTO();
            RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
            RowSelected.NameBook = row.Cells["nameBook"].Value.ToString();
            RowSelected.Price = double.Parse(row.Cells["price"].Value.ToString());
            RowSelected.Kind = row.Cells["kind"].Value.ToString();
            RowSelected.Author = row.Cells["author"].Value.ToString();

            txtTenSach.Text = RowSelected.NameBook;
            txtTacGia.Text = RowSelected.Author;
            txtGiaBan.Text = RowSelected.Price.ToString();
            cboTheLoai.SelectedItem = RowSelected.Kind;

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (!CheckOpened("EditBook"))
            {
                if (RowSelected != null)
                {
                    EditBook formEdit = new EditBook();
                    formEdit.Book = RowSelected;
                    formEdit.StartPosition = FormStartPosition.CenterScreen;
                    formEdit.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng tắt form chỉnh sửa hiện tại!");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTacGia.Text = "";
            txtTenSach.Text = "";
            txtGiaBan.Text = "";
            cboTheLoai.SelectedItem = "";
        }

        private void dgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            //this.txtGiaBan.Text = string.Format("{0:#,##0}", (Convert.ToDouble(this.txtGiaBan.Text)));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                var nameBook = txtTenSach.Text;
                var author = txtTacGia.Text;
                double price =  0;
                var kind = "";
                if (cboTheLoai.SelectedIndex != -1)
                {
                    kind = cboTheLoai.SelectedItem.ToString();
                }
                if(txtGiaBan.Text != "")
                {
                    price = double.Parse(txtGiaBan.Text);
                }
                BookBUS bus = new BookBUS();
                DataTable dt = bus.queryBook(nameBook, author, kind, price);

                dgBooks.DataSource = dt;
                dgBooks.Columns[0].HeaderText = "ID";
                dgBooks.Columns[1].HeaderText = "Tên Sách";
                dgBooks.Columns[2].HeaderText = "Hình Ảnh";
                dgBooks.Columns[3].HeaderText = "Thể Loại";
                dgBooks.Columns[4].HeaderText = "Tác Giả";
                dgBooks.Columns[5].HeaderText = "Giá";

                dgBooks.Columns[0].Width = 40;
                dgBooks.Columns[1].Width = 300;
                dgBooks.Columns[2].Width = 80;
                dgBooks.Columns[3].Width = 80;
                dgBooks.Columns[4].Width = 250;
                dgBooks.Columns[5].Width = 100;

                if (dt.Rows.Count > 0)
                {
                    dgBooks.Rows[0].Selected = true;
                    RowSelected = new BookDTO();
                    RowSelected.Id = Int32.Parse(dgBooks.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.NameBook = dgBooks.SelectedRows[0].Cells["nameBook"].Value.ToString();
                    RowSelected.Price = double.Parse(dgBooks.SelectedRows[0].Cells["price"].Value.ToString());
                    RowSelected.Kind = dgBooks.SelectedRows[0].Cells["kind"].Value.ToString();
                    RowSelected.Author = dgBooks.SelectedRows[0].Cells["author"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

