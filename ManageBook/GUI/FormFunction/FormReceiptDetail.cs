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
    public partial class FormReceiptDetail : DevExpress.XtraEditors.XtraForm
    {
        private string _typeForm;
        ReceiptDTO _receipt;
        ReceiptDetailDTO _receiptDetail;
        double selectedBookPrice;
        int selectedBookId;
        private readonly Receipt form;
       
        public FormReceiptDetail(Receipt f)
        {
            InitializeComponent();
            form = f;
        }

        public string TypeForm { get => _typeForm; set => _typeForm = value; }
        public ReceiptDTO Receipt { get => _receipt; set => _receipt = value; }
        public ReceiptDetailDTO ReceiptDetail { get => _receiptDetail; set => _receiptDetail = value; }

        private void FormReceiptDetail_Load(object sender, EventArgs e)
        {
            BookBUS bus = new BookBUS();
            DataTable dt = bus.getBookInWareHouse();
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
            txtId.Text = Receipt.Id.ToString();

            if(TypeForm == "edit")
            {
                luSach.EditValue = ReceiptDetail.IdBook;
                txtQuantity.Text = ReceiptDetail.Quantity.ToString();
                txtId.Text = ReceiptDetail.Id.ToString();
                lbTitle.Text = "Cập Nhật Chi Tiết Hóa Đơn";
                lbTitle.Left = 100;
            }
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
                    ReceiptDetailDTO b = new ReceiptDetailDTO();
                    b.IdReceipt = Receipt.Id;
                    b.IdBook = selectedBookId;
                    b.Price = selectedBookPrice;
                    b.Quantity = Int32.Parse(txtQuantity.Text);


                    ReceiptDetailBUS bus = new ReceiptDetailBUS();
                    if (bus.insertReceipt(b) == 1)
                    {
                        MessageBox.Show("Thêm thành công!");
                        form.LoadDataDetail();
                    }
                    else
                    {
                        MessageBox.Show("Số Khách Trong Kho Không Đủ!");

                    }
                }
                else
                {
                    ReceiptDetailDTO b = new ReceiptDetailDTO();
                    b.Id = ReceiptDetail.Id;
                    b.IdBook = selectedBookId;
                    b.Price = selectedBookPrice;
                    b.Quantity = Int32.Parse(txtQuantity.Text);


                    ReceiptDetailBUS bus = new ReceiptDetailBUS();
                    if (bus.editReceipt(b) == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        form.LoadDataDetail();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!", ex.Message);
            }
        }

        private void luSach_TextChanged(object sender, EventArgs e)
        {

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
            
        }
    }
}
