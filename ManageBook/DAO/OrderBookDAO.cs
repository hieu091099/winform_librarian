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
    public class OrderBookDAO
    {
        public DataTable getAll()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM order_book ";
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
        
        public int insert(OrderBookDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO order_book ( idBook, quantity, price, supplier, userId, dateOrder, dateModify) " +
                    "VALUES(@idBook, @quantity, @price, @supplier, @userId, @dateOrder, @dateModify)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                            new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
                            new SqlParameter { ParameterName = "@supplier", Value = b.Supplier },
                            new SqlParameter { ParameterName = "@userId", Value = b.UserId },
                            new SqlParameter { ParameterName = "@dateOrder", Value = b.DateOrder },
                            new SqlParameter { ParameterName = "@dateModify", Value = b.DateModify }
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
        public int edit(OrderBookDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE order_book SET idBook = @idBook, quantity = @quantity, price = @price, supplier = @supplier " +
                    ", userId = @userId, dateOrder = @dateOrder, dateModify = @dateModify WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                            new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
                            new SqlParameter { ParameterName = "@supplier", Value = b.Supplier },
                            new SqlParameter { ParameterName = "@userId", Value = b.UserId },
                            new SqlParameter { ParameterName = "@dateOrder", Value = b.DateOrder },
                            new SqlParameter { ParameterName = "@dateModify", Value = b.DateModify }
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
        public int remove(int id)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "DELETE FROM order_book WHERE id = @id";
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
