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
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        CustomerDTO RowSelected;
        public CustomerForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {
                CustomerBUS b = new CustomerBUS();
                DataTable dt = b.getAllCustomers();
                dgCustomers.DataSource = dt;
                dgCustomers.Columns[0].HeaderText = "ID";
                dgCustomers.Columns[1].HeaderText = "Họ Tên";
                dgCustomers.Columns[2].HeaderText = "Giới Tính";
                dgCustomers.Columns[3].HeaderText = "Sinh Nhật";
                dgCustomers.Columns[4].HeaderText = "Email";
                dgCustomers.Columns[5].HeaderText = "Số Điện Thoại";
                dgCustomers.Columns[6].HeaderText = "Địa Chỉ";

                dgCustomers.Columns[0].Width = 40;
                dgCustomers.Columns[1].Width = 180;
                dgCustomers.Columns[2].Width = 60;
                dgCustomers.Columns[3].Width = 80;
                dgCustomers.Columns[4].Width = 120;
                dgCustomers.Columns[5].Width = 100;
                dgCustomers.Columns[6].Width = 300;


                if (dt.Rows.Count > 0)
                {
                    dgCustomers.Rows[0].Selected = true;
                    RowSelected = new CustomerDTO();
                    RowSelected.Id = Int32.Parse(dgCustomers.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.FullName = dgCustomers.SelectedRows[0].Cells["fullname"].Value.ToString();
                    RowSelected.Address = dgCustomers.SelectedRows[0].Cells["address"].Value.ToString();
                    RowSelected.Birthday = Convert.ToDateTime(dgCustomers.SelectedRows[0].Cells["birthday"].Value);
                    RowSelected.Gender = Convert.ToBoolean(dgCustomers.SelectedRows[0].Cells["gender"].Value);
                    RowSelected.Phone = dgCustomers.SelectedRows[0].Cells["phone"].Value.ToString();
                    RowSelected.Email = dgCustomers.SelectedRows[0].Cells["email"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDTO b = new CustomerDTO();
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
                bus.insertCustomer(b);

                LoadData();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng '{RowSelected.FullName}!'", "Thông Báo!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (RowSelected != null)
                {
                    try
                    {

                        CustomerBUS bus = new CustomerBUS();
                        bus.removeCustomer(RowSelected.Id);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            rtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            cboGioiTinh.SelectedItem = "";
            deNgaySinh.Text = "";
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                int index = e.RowIndex;
                DataGridViewRow row = dgCustomers.Rows[index];
                RowSelected = new CustomerDTO();
                RowSelected = new CustomerDTO();
                RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                RowSelected.FullName = row.Cells["fullname"].Value.ToString();
                RowSelected.Address = row.Cells["address"].Value.ToString();
                RowSelected.Birthday = Convert.ToDateTime(row.Cells["birthday"].Value);
                RowSelected.Gender = Convert.ToBoolean(row.Cells["gender"].Value);
                RowSelected.Phone = row.Cells["phone"].Value.ToString();
                RowSelected.Email = row.Cells["email"].Value.ToString();


                txtHoTen.Text = RowSelected.FullName;
                txtEmail.Text = RowSelected.Email;
                txtSDT.Text = RowSelected.Phone.ToString();
                deNgaySinh.EditValue = RowSelected.Birthday;
                rtDiaChi.Text = RowSelected.Address;
                if (RowSelected.Gender == false)
                {
                    cboGioiTinh.SelectedIndex = 1;
                }
                else
                {
                    cboGioiTinh.SelectedIndex = 0;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!CheckOpened("EditCustomer"))
            {
                if (RowSelected != null)
                {
                    EditCustomer formEdit = new EditCustomer();
                    formEdit.Customer = RowSelected;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                CustomerDTO b = new CustomerDTO();
                var fullName = txtHoTen.Text;
                var email = txtEmail.Text;
                var birthday= "";
                if (deNgaySinh.EditValue != null)
                {
                    birthday = deNgaySinh.EditValue.ToString();
                }
                
                var gender = -1;
                if(cboGioiTinh.SelectedItem == "Nam")
                {
                     gender = 1;
                }
                if (cboGioiTinh.SelectedItem == "Nữ")
                {
                     gender = 0;

                }
                var address = rtDiaChi.Text;
                var phone = txtSDT.Text;
                
                CustomerBUS bus = new CustomerBUS();
                DataTable dt = bus.getCustomers(fullName, email, birthday, gender, address, phone);
                dgCustomers.DataSource = dt;
               

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
