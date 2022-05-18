using ManageBook.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DAO
{
    public class EmployeeDAO
    {
        public DataTable getAllEmployee()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM users ";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql);
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
        

        public DataTable getEmployee(string taiKhoan, string hoTen, string loaiNguoiDung)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM users  WHERE 1=1 ";
               
                if (taiKhoan != "")
                {
                    strSql += $" AND usrename like '{taiKhoan}%'";

                }
                if (hoTen != "")
                {
                    strSql += $" AND fullName like N'%{hoTen}%'";

                }
                if (loaiNguoiDung != "")
                {
                    strSql += $" AND type = N'{loaiNguoiDung}'";
                }
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql);
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

        public int insertEmployee(EmployeeDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO users (username, password, fullName, type, status) VALUES (@username, @password, @fullName, @type, 1)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@username", Value = b.Username },
                            new SqlParameter { ParameterName = "@password", Value = b.Password },
                            new SqlParameter { ParameterName = "@fullName", Value = b.FullName },
                            new SqlParameter { ParameterName = "@type", Value = b.Type }
                            

                    );

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int editEmployee(EmployeeDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE users SET fullName = @fullName, password = @password WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@fullName", Value = b.FullName },
                            new SqlParameter { ParameterName = "@password", Value = b.Password }

                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int removeEmployee(int id)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "DELETE FROM users WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = id }

                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
    }
}
