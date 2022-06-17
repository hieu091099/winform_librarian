using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ManageBook.BUS;
using ManageBook.DAO;
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
    public partial class NewOrderBook : DevExpress.XtraEditors.XtraForm
    {
        double selectedBookPrice;
        int selectedBookId;
        string _typeForm;
        OrderBookDTO _book;
        ManageSheet form;

        public string TypeForm { get => _typeForm; set => _typeForm = value; }
        public OrderBookDTO Book { get => _book; set => _book = value; }

        //Common _c;


        //public Common C { get => _c; set => _c = value; }

        public NewOrderBook( ManageSheet f)
        {
            InitializeComponent();
            form = f;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewOrderBook_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(""+_c.userId);
            // fill data books to combobox
            
            BookBUS bus = new BookBUS();
            DataTable dt = bus.getAllBooks();
            dt.Columns.Remove("image");
            dt.Columns.Remove("kind");
            dt.Columns.Remove("author");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            luSach.Properties.DataSource = ds.Tables[0].DefaultView;
            luSach.Properties.ForceInitialize();
            luSach.Properties.PopulateColumns();
            luSach.Properties.ValueMember = "id";
            luSach.Properties.DisplayMember = "nameBook";
            luSach.Properties.Columns[1].Caption = "Tên Sách";
            luSach.Properties.Columns[2].Caption = "Giá";
            luSach.Properties.Columns[0].Width = 30;
            luSach.Properties.Columns[1].Width = 200;
            luSach.Properties.Columns[2].Width = 60;
            if(TypeForm == "edit")
            {
                txtGia.Text = Book.Price.ToString();
                txtSoLuong.Text = Book.Quantity.ToString();
                luSach.EditValue = Book.IdBook;
                luSach.Properties.ReadOnly = true;
                cboSupplier.SelectedItem = Book.Supplier;
                lbTitle.Text = "Chỉnh Sửa Phiếu Nhập Sách";
                lbTitle.Left = 90;
            }
            
            //foreach (DataRow row in dt.Rows)
            //{
            //    cboSach.Properties.Items.Add(row["nameBook"]);

            //}


        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSoLuong.Text == "" && selectedBookId != null)
                {
                    txtGia.Text = "";
                }
                else
                {
                    this.txtGia.Text = string.Format("{0:#,##0}", ((double)Int32.Parse(this.txtSoLuong.Text) * selectedBookPrice));

                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "" && selectedBookId != null)
            {
                txtGia.Text = "";
            }
            else
            {
                this.txtGia.Text = string.Format("{0:#,##0}", ((double)Int32.Parse(this.txtSoLuong.Text) * selectedBookPrice));

            }
        }

        private void luSach_EditValueChanged(object sender, EventArgs e)
        {
           
            LookUpEdit lookUp = sender as LookUpEdit;
            // Access the currently selected data row
            DataRowView dataRow = lookUp.GetSelectedDataRow() as DataRowView;
            // Assign the row's Picture field value to the PictureEdit control
            if (dataRow != null)
            { 
                selectedBookPrice = Convert.ToDouble(dataRow["price"].ToString());
                selectedBookId = Int32.Parse(dataRow["id"].ToString());
                
            }
            if (txtSoLuong.Text != "")
            {
                this.txtGia.Text = string.Format("{0:#,##0}", ((double)Int32.Parse(this.txtSoLuong.Text) * selectedBookPrice));
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(TypeForm == "insert")
                {
                    OrderBookDTO b = new OrderBookDTO();
                    b.IdBook = selectedBookId;
                    b.Price = Convert.ToDouble(txtGia.Text);
                    b.Quantity = Int32.Parse(txtSoLuong.Text);
                    b.Supplier = cboSupplier.Text;

                    OrderBookBUS bus = new OrderBookBUS();
                    if (bus.insert(b) == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        form.LoadData();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vi Phạm Quy Định Nhập Sách!");
                    }
                }
                else
                {
                    OrderBookDTO b = new OrderBookDTO();
                    b.Id = Book.Id;
                    b.IdBook = selectedBookId;
                    b.Price = Convert.ToDouble(txtGia.Text);
                    b.Quantity = Int32.Parse(txtSoLuong.Text);
                    b.Supplier = cboSupplier.Text;

                    OrderBookBUS bus = new OrderBookBUS();
                    if (bus.edit(b) == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vi Phạm Quy Định Nhập Sách!");
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!", ex.Message);
            }
        }
    }
}
