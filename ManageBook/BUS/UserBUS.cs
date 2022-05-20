using ManageBook.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.BUS
{
    public class UserBUS
    {
        public DataTable Login(string username, string password)
        {
            try
            {
                UserDAO dao = new UserDAO();
                return dao.Login(username, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
