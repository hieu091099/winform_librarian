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
    public partial class Regulartion : DevExpress.XtraEditors.XtraForm
    {
        RegulartionDTO RowSelected;
        public Regulartion()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                RegulartionBUS b = new RegulartionBUS();
                DataTable dt = b.getAll();
                dgQuyDinh.DataSource = dt;
                dgQuyDinh.Columns[0].HeaderText = "ID";
                dgQuyDinh.Columns[1].HeaderText = "Tên Quy Định";
                dgQuyDinh.Columns[2].HeaderText = "Giá Trị";
                dgQuyDinh.Columns[3].HeaderText = "Trạng Thái";
                dgQuyDinh.Columns[4].HeaderText = "Loại Quy Định";


                dgQuyDinh.Columns[0].Width = 40;
                dgQuyDinh.Columns[1].Width = 300;
                dgQuyDinh.Columns[2].Width = 90;
                dgQuyDinh.Columns[3].Width = 80;
                dgQuyDinh.Columns[4].Width = 100;


                if (dt.Rows.Count > 0)
                {
                    dgQuyDinh.Rows[0].Selected = true;
                    RowSelected = new RegulartionDTO();
                    RowSelected.Id = Int32.Parse(dgQuyDinh.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.Name = dgQuyDinh.SelectedRows[0].Cells["name"].Value.ToString();
                    RowSelected.Value = Int32.Parse(dgQuyDinh.SelectedRows[0].Cells["value"].Value.ToString());
                    RowSelected.Type = dgQuyDinh.SelectedRows[0].Cells["type"].Value.ToString();
                    RowSelected.Status = bool.Parse(dgQuyDinh.SelectedRows[0].Cells["status"].Value.ToString());


                    txtQuyDinh.Text = RowSelected.Name;
                    txtGiaTri.Text = RowSelected.Value.ToString();
                    cboLoaiQuyDinh.SelectedItem = RowSelected.Type;
                    if (RowSelected.Status == true)
                    {
                        rbSuDung.Checked = true;
                    }
                    else
                    {
                        rbKhongSuDung.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Regulartion_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                int index = e.RowIndex;
                DataGridViewRow row = dgQuyDinh.Rows[index];
                RowSelected = new RegulartionDTO();
                RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                RowSelected.Name = row.Cells["name"].Value.ToString();
                RowSelected.Value = Int32.Parse(row.Cells["value"].Value.ToString());
                RowSelected.Type = row.Cells["type"].Value.ToString();
                RowSelected.Status = bool.Parse(row.Cells["status"].Value.ToString());

                txtQuyDinh.Text = RowSelected.Name;
                txtGiaTri.Text = RowSelected.Value.ToString();
                cboLoaiQuyDinh.SelectedItem = RowSelected.Type;
                if(RowSelected.Status == true)
                {
                    rbSuDung.Checked = true;
                }
                else
                {
                    rbKhongSuDung.Checked = true;
                }
                
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RowSelected != null)
            {
                try
                {
                    RegulartionDTO b = new RegulartionDTO();
                    b.Value = Int32.Parse(txtGiaTri.Text);
                    b.Id = RowSelected.Id;
                    if(rbSuDung.Checked == true)
                    {
                        b.Status = true;
                    }
                    if(rbKhongSuDung.Checked == true)
                    {
                        b.Status = false;

                    }
                    if(rbSuDung.Checked == false && rbKhongSuDung.Checked == false)
                    {
                        b.Status = true;
                    }

                    RegulartionBUS bus = new RegulartionBUS();
                    int check = bus.editRegulartion(b);
                    if(check == 1)
                    {
                        MessageBox.Show("Cập Nhật Thành Công!!");
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại!!");
                    }

                    LoadData();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
