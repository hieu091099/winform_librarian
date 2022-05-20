using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManageBook.DAO;


namespace ManageBook.GUI
{
    public partial class Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public string typeUser = Common.TypeUser;
        public Dashboard()
        {
            InitializeComponent();
            ManageBook frm = new ManageBook();
            frm.TopLevel = false;
            //frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            ManageBook frm = new ManageBook();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(62, 91, 135);
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            ManageSheet frm = new ManageSheet();
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            Receipt frm = new Receipt();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            WareHouse frm = new WareHouse();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {

            CustomerDebt frm = new CustomerDebt();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Common.TypeUser);
           if(Common.TypeUser == "Nhân Viên")
            {
                accordionControlElement6.Visible = false;
                accordionControlElement8.Visible = false;
                accordionControlElement9.Visible = false;

            }
           else if(Common.TypeUser == "Quản Lý")
            {
                accordionControlElement8.Visible = false;

            }

        }

        private void accordionControlElement10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            Regulartion frm = new Regulartion();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pContainerP.Controls.Clear();
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }
    }
}
