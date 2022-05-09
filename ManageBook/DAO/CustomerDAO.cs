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
    public class CustomerDAO
    {
        public DataTable getAllCustomers()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM customers";
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

        public int insertCustomer(CustomerDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO customers (fullName, gender, birthday, email, phone, address) VALUES(@fullName, @gender, @birthday, @email, @phone, @address)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@fullName", Value = b.FullName },
                            new SqlParameter { ParameterName = "@gender", Value = b.Gender },
                            new SqlParameter { ParameterName = "@birthday", Value = b.Birthday },
                            new SqlParameter { ParameterName = "@email", Value = b.Email },
                            new SqlParameter { ParameterName = "@phone", Value = b.Phone },
                            new SqlParameter { ParameterName = "@address", Value = b.Address }

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
        public int editCustomer(CustomerDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE customers SET fullName = @fullName, gender = @gender, birthday = @birthday, email = @email , phone = @phone, address = @address WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@fullName", Value = b.FullName },
                            new SqlParameter { ParameterName = "@gender", Value = b.Gender },
                            new SqlParameter { ParameterName = "@birthday", Value = b.Birthday },
                            new SqlParameter { ParameterName = "@email", Value = b.Email },
                            new SqlParameter { ParameterName = "@phone", Value = b.Phone },
                            new SqlParameter { ParameterName = "@address", Value = b.Address }
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
        public int removeCustomer(int id)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "DELETE FROM customers WHERE id = @id";
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
