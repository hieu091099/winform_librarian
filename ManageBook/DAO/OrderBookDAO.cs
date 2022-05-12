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
                string strSql = "SELECT a.id, b.nameBook, b.author, b.kind, a.quantity, a.price, a.supplier, c.fullName,  a.dateOrder, a.dateModify , a.idBook " +
                    "FROM order_book a LEFT JOIN books b ON a.idBook = b.id LEFT JOIN users c ON a.userId = c.id ";
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
        public DataTable queryOrder(string nameBook, string author, string kind)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT a.id, b.nameBook, b.author, b.kind, a.quantity, a.price, a.supplier, c.fullName,  a.dateOrder, a.dateModify , a.idBook " +
                    "FROM order_book a LEFT JOIN books b ON a.idBook = b.id LEFT JOIN users c ON a.userId = c.id WHERE 1=1 ";

                if (nameBook != "")
                {
                    strSql += $" AND  b.nameBook LIKE '%{nameBook}%'";
                }
                if (author != "")
                {
                    strSql += $" AND  b.author LIKE '%{nameBook}%'";
                }
                if (kind != "")
                {
                    strSql += $" AND  b.kind= '{kind}'";
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
        public int insert(OrderBookDTO b)
        {
            int idInsert = 0;
            int nRowWareHouse = 0;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string strSql = "INSERT INTO order_book ( idBook, quantity, price, supplier, userId, dateOrder, dateModify) " +
                    "VALUES(@idBook, @quantity, @price, @supplier, 1, getdate(), getdate()); SELECT SCOPE_IDENTITY();";
                string insertWareHouse = "INSERT INTO warehouse (idBook, totalQuantity, sold, idOrder, dateImport) VALUES (@idBook, @quantity, 0, @id, getdate())";
                idInsert = provider.ExecuteScalar(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                            new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
                            new SqlParameter { ParameterName = "@supplier", Value = b.Supplier },
                            new SqlParameter { ParameterName = "@userId", Value = b.UserId }
                    );
                
                nRowWareHouse = provider.ExecuteNonQuery(CommandType.Text, insertWareHouse,
                            new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                            new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                            new SqlParameter { ParameterName = "@id", Value = idInsert }

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
            return nRowWareHouse;
        }
        public int edit(OrderBookDTO b)
        {
            int nRow = 0;
            int nRowWareHouse = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE order_book SET  quantity = @quantity, price = @price, supplier = @supplier " +
                    ", userId = 1,  dateModify = getdate() WHERE id = @id";
                string updateWareHouse = "UPDATE warehouse SET totalQuantity = @quantity WHERE idOrder = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
                            new SqlParameter { ParameterName = "@supplier", Value = b.Supplier }
                            
                            
                    );
                nRowWareHouse = provider.ExecuteNonQuery(CommandType.Text, updateWareHouse,
                           new SqlParameter { ParameterName = "@id", Value = b.Id },
                           new SqlParameter { ParameterName = "@quantity", Value = b.Quantity }
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
