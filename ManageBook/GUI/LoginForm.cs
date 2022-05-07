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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserDTO user = new UserDTO
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                UserBUS bus = new UserBUS();
                if (bus.Login(user.Username, user.Password) == 1)
                {
                    Dashboard db = new Dashboard();
                    this.Hide();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Login fail");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
