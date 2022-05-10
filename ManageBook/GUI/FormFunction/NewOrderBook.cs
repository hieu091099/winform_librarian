using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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

namespace ManageBook.GUI.FormFunction
{
    public partial class NewOrderBook : DevExpress.XtraEditors.XtraForm
    {
        public NewOrderBook()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NewOrderBook_Load(object sender, EventArgs e)
        {
            // fill data books to combobox
            BookBUS bus = new BookBUS();
            DataTable dt = bus.getAllBooks();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            luSach.Properties.DataSource = ds.Tables[0].DefaultView;
            luSach.Properties.ForceInitialize();
            luSach.Properties.PopulateColumns();
            luSach.Properties.ValueMember = "id";
            luSach.Properties.DisplayMember = "nameBook";
            luSach.Properties.Columns[0].Caption = "Tên Sách";
            this.luSach.Properties.SearchMode = SearchMode.AutoComplete;
            foreach (DataRow row in dt.Rows)
            {
                cboSach.Properties.Items.Add(row["nameBook"]);
                
            }

           
        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtGia.Text = this.txtSoLuong.Text;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "")
            {
                txtGia.Text = "";
            }
            else
            {
                this.txtGia.Text = string.Format("{0:#,##0}", (Int32.Parse(this.txtSoLuong.Text) * 200000));

            }
        }
    }
}
