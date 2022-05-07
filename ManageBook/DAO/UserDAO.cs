using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DAO
{
    public class UserDAO
    {
        public int Login(string username, string password)
        {

            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql, new SqlParameter { ParameterName = "@username", Value = username }
                , new SqlParameter { ParameterName = "@password", Value = password });
                return (int)dt.Rows[0][0];

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }
    }
}
