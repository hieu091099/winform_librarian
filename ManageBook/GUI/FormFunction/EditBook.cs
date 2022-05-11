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
    public partial class EditBook : DevExpress.XtraEditors.XtraForm
    {
        BookDTO _book;
        public EditBook()
        {
            InitializeComponent();
        }

        public BookDTO Book { get => _book; set => _book = value; }

        private void EditBook_Load(object sender, EventArgs e)
        {
            txtTenSach.Text = Book.NameBook;
            txtTacGia.Text = Book.Author;
            txtGiaBan.Text = Book.Price.ToString();
            cboTheLoai.SelectedItem = Book.Kind;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                BookDTO b = new BookDTO();
                b.Id = Book.Id;
                b.NameBook = txtTenSach.Text;
                b.Author = txtTacGia.Text;
                b.Price = double.Parse(txtGiaBan.Text);
                b.Kind = cboTheLoai.SelectedItem.ToString();
                BookBUS bus = new BookBUS();
                if (bus.editBook(b) == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại !", ex.Message);
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            this.txtGiaBan.Text = string.Format("{0:#,##0}", (Convert.ToDouble(this.txtGiaBan.Text)));
        }
    }
}
