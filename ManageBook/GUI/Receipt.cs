using DevExpress.XtraEditors;
using ManageBook.BUS;
using ManageBook.DTO;
using ManageBook.GUI.FormFunction;
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
    public partial class Receipt : DevExpress.XtraEditors.XtraForm
    {
        ReceiptDTO RowSelected;
        ReceiptDetailDTO RowSelectedDetail;
        public Receipt()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FormReceipt formEdit = new FormReceipt();
            formEdit.TypeForm = "edit";
            formEdit.Receipt = RowSelected;
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
            LoadData();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn '{RowSelected.Id}'!'", "Thông Báo!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (RowSelected != null)
                {
                    try
                    {
                        ReceiptBUS bus = new ReceiptBUS();
                        bus.removeReceipt(RowSelected.Id);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormReceipt formEdit = new FormReceipt();
            formEdit.TypeForm = "insert";
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                ReceiptBUS b = new ReceiptBUS();
                DataTable dt = b.getAllReceipt();
                dgReceipt.DataSource = dt;
                dgReceipt.Columns[0].HeaderText = "ID";
                dgReceipt.Columns[1].HeaderText = "Khách Hàng";
                dgReceipt.Columns[2].HeaderText = "Trạng Thái";
                dgReceipt.Columns[3].HeaderText = "Đã Trả";
                dgReceipt.Columns[4].HeaderText = "NV Tạo Hóa Đơn";
                dgReceipt.Columns[5].HeaderText = "Ngày Tạo Hóa Đơn";
                dgReceipt.Columns["idCus"].Visible = false;
                dgReceipt.Columns["payCus"].DefaultCellStyle.Format = "N2";


                dgReceipt.Columns[0].Width = 30;
                dgReceipt.Columns[1].Width = 120;
                dgReceipt.Columns[2].Width = 60;
                dgReceipt.Columns[3].Width = 80;
                dgReceipt.Columns[4].Width = 90;
                dgReceipt.Columns[5].Width = 120;

                if (dt.Rows.Count > 0)
                {
                    dgReceipt.Rows[0].Selected = true;
                    RowSelected = new ReceiptDTO();
                    RowSelected.Id = Int32.Parse(dgReceipt.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelected.IdCus = Int32.Parse(dgReceipt.SelectedRows[0].Cells["idCus"].Value.ToString());
                    RowSelected.PayCus = double.Parse(dgReceipt.SelectedRows[0].Cells["payCus"].Value.ToString());
                    RowSelected.Status = dgReceipt.SelectedRows[0].Cells["status"].Value.ToString();

                    LoadDataDetail();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LoadDataDetail()
        {
            try
            {
                ReceiptDetailBUS b = new ReceiptDetailBUS();
                DataTable dt = b.getAllReceipt(RowSelected.Id);
                dgReceiptDetail.DataSource = dt;
                dgReceiptDetail.Columns[0].HeaderText = "ID";
                dgReceiptDetail.Columns[1].HeaderText = "Tên Sách";
                dgReceiptDetail.Columns[2].HeaderText = "Số Lượng";
                dgReceiptDetail.Columns[3].HeaderText = "Đơn Giá";
                dgReceiptDetail.Columns[4].HeaderText = "Tổng Tiền";
                dgReceiptDetail.Columns["idBook"].Visible = false;
                dgReceiptDetail.Columns["price"].DefaultCellStyle.Format = "N2";
                //dgReceiptDetail.Columns["Total"].DefaultCellStyle.Format = "N2";

                



                dgReceiptDetail.Columns[0].Width = 50;
                dgReceiptDetail.Columns[1].Width = 200;
                dgReceiptDetail.Columns[2].Width = 60;
                dgReceiptDetail.Columns[3].Width = 80;
                dgReceiptDetail.Columns[4].Width = 100;


                if (dt.Rows.Count > 0)
                {
                    dgReceiptDetail.Rows[0].Selected = true;
                    RowSelectedDetail = new ReceiptDetailDTO();
                    RowSelectedDetail.Id = Int32.Parse(dgReceiptDetail.SelectedRows[0].Cells["id"].Value.ToString());
                    RowSelectedDetail.IdBook = Int32.Parse(dgReceiptDetail.SelectedRows[0].Cells["idBook"].Value.ToString());
                    RowSelectedDetail.Price = double.Parse(dgReceiptDetail.SelectedRows[0].Cells["price"].Value.ToString());
                    RowSelectedDetail.Quantity = Int32.Parse(dgReceiptDetail.SelectedRows[0].Cells["quantity"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void updateDataGridViewTotal(DataGridView dgv)
        {
            DataTable dt = (DataTable)dgv.DataSource;
            int lastRow = (dgv.Rows.Count - 1);
            if (dt.Rows[lastRow][0].ToString() == "Total")
            {
                dt.Rows.RemoveAt(lastRow);
            }
            int[] tot = new int[dt.Columns.Count];
            Array.Clear(tot, 0, tot.Length);

            foreach (DataRow row in dt.Rows)
            {
                int rowSum = 0;
                for (int i = 1; i < dt.Columns.Count - 1; i++)
                {
                    tot[i] += Convert.ToInt32(row[i]);
                    rowSum += Convert.ToInt32(row[i]);
                }
                row["Total"] = rowSum;
            }
            DataRow newRow = dt.NewRow();
            newRow["Agent"] = "Total";
            for (int i = 1; i < tot.Length; i++)
            {
                newRow[i] = tot[i];
            }
            dt.Rows.Add(newRow);
            dgv.DataSource = dt;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            LoadData();
            CustomerBUS bus = new CustomerBUS();
            DataTable dt = bus.getAllCustomers();
            dt.Columns.Remove("gender");
            dt.Columns.Remove("birthday");
            dt.Columns.Remove("email");
            dt.Columns.Remove("phone");
            dt.Columns.Remove("address");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            luKhach.Properties.DataSource = ds.Tables[0].DefaultView;
            luKhach.Properties.ForceInitialize();
            luKhach.Properties.PopulateColumns();
            luKhach.Properties.ValueMember = "id";
            luKhach.Properties.DisplayMember = "fullName";
            luKhach.Properties.Columns[1].Caption = "Họ Tên";
            luKhach.Properties.Columns[0].Width = 30;
            luKhach.Properties.Columns[1].Width = 200;
        }

        private void dgReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                int index = e.RowIndex;
                DataGridViewRow row = dgReceipt.Rows[index];
                RowSelected = new ReceiptDTO();
                RowSelected.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                RowSelected.IdCus = Int32.Parse(row.Cells["idCus"].Value.ToString());
                RowSelected.PayCus = double.Parse(row.Cells["payCus"].Value.ToString());
                RowSelected.Status = row.Cells["status"].Value.ToString();
                LoadDataDetail();
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            FormReceiptDetail formEdit = new FormReceiptDetail(this);
            formEdit.TypeForm = "insert";
            formEdit.Receipt = RowSelected;
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
            //LoadData();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FormReceiptDetail formEdit = new FormReceiptDetail(this);
            formEdit.TypeForm = "edit";
            formEdit.Receipt = RowSelected;
            formEdit.ReceiptDetail = RowSelectedDetail;
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
        }

        private void dgReceiptDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                int index = e.RowIndex;
                DataGridViewRow row = dgReceiptDetail.Rows[index];
                RowSelectedDetail = new ReceiptDetailDTO();
                RowSelectedDetail.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                RowSelectedDetail.IdBook = Int32.Parse(row.Cells["idBook"].Value.ToString());
                RowSelectedDetail.Price = double.Parse(row.Cells["price"].Value.ToString());
                RowSelectedDetail.Quantity = Int32.Parse(row.Cells["quantity"].Value.ToString());
            }

            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa khỏi hóa đơn !'", "Thông Báo!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                if (RowSelectedDetail != null)
                {
                    try
                    {
                        ReceiptDetailBUS bus = new ReceiptDetailBUS();
                        bus.removeReceipt(RowSelectedDetail.Id);
                        LoadDataDetail();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                var khachHang = luKhach.Text;
                var trangThai = cboTrangThai.SelectedIndex != -1 ? cboTrangThai.SelectedItem.ToString() : "";
                var dateFrom = "";
                var dateTo = "";
                if (deFrom.EditValue != null)
                {
                    dateFrom = deFrom.EditValue.ToString();
                }
                if (deTo.EditValue != null)
                {
                    dateFrom = deTo.EditValue.ToString();
                }
                ReceiptBUS bus = new ReceiptBUS();
                DataTable dt = bus.queryReceipt(khachHang, trangThai, dateFrom, dateTo);
                //dgCustomers.DataSource = dt;
                dgReceipt.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void luKhach_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
