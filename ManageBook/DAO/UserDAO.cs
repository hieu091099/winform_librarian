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
        public DataTable Login(string username, string password)
        {

            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM users WHERE username = @username AND password = @password";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql, new SqlParameter { ParameterName = "@username", Value = username }
                , new SqlParameter { ParameterName = "@password", Value = password });
                return dt;

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
