using DevExpress.XtraEditors;
using ManageBook.BUS;
using ManageBook.DAO;
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
       
        Common c = new Common();
        
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
                DataTable dt = new DataTable();
                dt = bus.Login(user.Username, user.Password);
                if(dt!= null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        Dashboard db = new Dashboard();
                       
                        Common.CurrentUserId = dt.Rows[0].Field<int>("id");
                        Common.TypeUser = dt.Rows[0].Field<string>("type");

                        db.StartPosition = FormStartPosition.CenterScreen;
                        db.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login fail!");
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
