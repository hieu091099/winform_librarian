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
    public partial class FormDebt : DevExpress.XtraEditors.XtraForm
    {
        private int _idCus;
        private double _debt;
        public FormDebt(ManageSheet f)
        {
            InitializeComponent();
        }

        public int IdCus { get => _idCus; set => _idCus = value; }
        public double Debt { get => _debt; set => _debt = value; }

        private void FormDebt_Load(object sender, EventArgs e)
        {
            CustomerBUS bus = new CustomerBUS();
            DataTable dt = bus.getAllCustomers();
            dt.Columns.Remove("gender");
            dt.Columns.Remove("birthday");
            dt.Columns.Remove("email");
            dt.Columns.Remove("phone");
            dt.Columns.Remove("address");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            luKhachHang.Properties.DataSource = ds.Tables[0].DefaultView;
            luKhachHang.Properties.ForceInitialize();
            luKhachHang.Properties.PopulateColumns();
            luKhachHang.Properties.ValueMember = "id";
            luKhachHang.Properties.DisplayMember = "fullName";
            luKhachHang.Properties.Columns[1].Caption = "Họ Tên";
            luKhachHang.Properties.Columns[0].Width = 30;
            luKhachHang.Properties.Columns[1].Width = 200;
            luKhachHang.EditValue = IdCus;
            luKhachHang.Properties.ReadOnly = true;
            txtDebt.Text = string.Format("{0:#,##0}", Debt);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DebtDTO b = new DebtDTO();
            b.IdCus = IdCus;
            b.DebtMoney = Convert.ToDouble(txtGet.Text);
            b.CollectionDate = deNgayThu.DateTime;

            if(b.DebtMoney > Debt)
            {
                MessageBox.Show("Số tiền thu không được lớn hơn số tiền khách nợ!");
            }
            else
            {
                DebtBUS bus = new DebtBUS();
                if (bus.insert(b) == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
            }

            
        }

        private void txtGet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGet.Text = string.Format("{0:#,##0}", txtGet.Text);
            }
            

        }
    }
}
