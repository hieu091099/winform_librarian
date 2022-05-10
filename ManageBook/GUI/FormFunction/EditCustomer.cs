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
    public partial class EditCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerDTO _customer;
        public EditCustomer()
        {
            InitializeComponent();
           
        }

        public CustomerDTO Customer { get => _customer; set => _customer = value; }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDTO b = new CustomerDTO();
                b.Id = Customer.Id;
                b.FullName = txtHoTen.Text;
                if (cboGioiTinh.SelectedItem == "Nam")
                {
                    b.Gender = true;
                }
                else
                {
                    b.Gender = false;
                }
                b.Birthday = deNgaySinh.DateTime;
                b.Email = txtEmail.Text;
                b.Address = rtDiaChi.Text;
                b.Phone = txtSDT.Text;

                CustomerBUS bus = new CustomerBUS();
                if (bus.editCustomer(b) == 1)
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

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = Customer.FullName;
            txtEmail.Text = Customer.Email;
            txtSDT.Text = Customer.Phone.ToString();
            deNgaySinh.EditValue = Customer.Birthday;
            rtDiaChi.Text = Customer.Address;
            if (Customer.Gender == false)
            {
                cboGioiTinh.SelectedIndex = 1;
            }
            else
            {
                cboGioiTinh.SelectedIndex = 0;

            }
        }
    }
}
