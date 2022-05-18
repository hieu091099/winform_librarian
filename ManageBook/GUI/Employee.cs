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
    public partial class Employee : DevExpress.XtraEditors.XtraForm
    {
        EmployeeDTO RowSelected;
        public Employee()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                EmployeeBUS b = new EmployeeBUS();
                DataTable dt = b.getAllEmployee();
                dgNhanVien.DataSource = dt;
                dgNhanVien.Columns[0].HeaderText = "ID";
                dgNhanVien.Columns[1].HeaderText = "Tài Khoản";
                dgNhanVien.Columns[2].HeaderText = "Mật Khẩu";
                dgNhanVien.Columns[3].HeaderText = "Họ Tên";
                dgNhanVien.Columns[4].HeaderText = "Loại Người Dùng";
                dgNhanVien.Columns[5].HeaderText = "Trạng Thái";

                dgNhanVien.Columns[0].Width = 40;
                dgNhanVien.Columns[1].Width = 100;
                dgNhanVien.Columns[2].Width = 80;
                dgNhanVien.Columns[3].Width = 100;
                dgNhanVien.Columns[4].Width = 250;
                dgNhanVien.Columns[5].Width = 100;

                if (dt.Rows.Count > 0)
                {
                    dgNhanVien.Rows[0].Selected = true;
                    RowSelected = new EmployeeDTO();
                    RowSelected.Id = Int32.Parse(dgNhanVien.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.FullName = dgNhanVien.SelectedRows[0].Cells["fullName"].Value.ToString();
                    RowSelected.Username = dgNhanVien.SelectedRows[0].Cells["username"].Value.ToString();
                    RowSelected.Password = dgNhanVien.SelectedRows[0].Cells["password"].Value.ToString();
                    
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
                EmployeeDTO b = new EmployeeDTO();
                b.Username = txtTaiKhoan.Text;
                b.Password = txtMatKhau.Text;
                b.FullName = txtHoTen.Text;
                b.Type = cboLoaiNhanVien.SelectedItem.ToString();
                

                EmployeeBUS bus = new EmployeeBUS();
                bus.insertEmployee(b);

                LoadData();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa người dùng '{RowSelected.FullName}!'", "Thông Báo!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (RowSelected != null)
                {
                    try
                    {

                        EmployeeBUS bus = new EmployeeBUS();
                        bus.removeEmployee(RowSelected.Id);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                int index = e.RowIndex;
                DataGridViewRow row = dgNhanVien.Rows[index];
                RowSelected = new EmployeeDTO();
                RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                RowSelected.FullName = row.Cells["fullName"].Value.ToString();
                RowSelected.Username = row.Cells["username"].Value.ToString();
                RowSelected.Password = row.Cells["password"].Value.ToString();

            }
        }
    }
}
