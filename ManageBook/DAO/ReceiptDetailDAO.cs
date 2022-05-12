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
    public class ReceiptDetailDAO
    {
        public DataTable getReceiptDetail(int id)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT CONVERT(VARCHAR,a.id) id, b.nameBook,  a.quantity, a.price , a.price * a.quantity 'Total', a.idBook " +
                    "FROM receipt_detail a LEFT JOIN books b ON a.idBook = b.id " +
                    "WHERE a.idReceipt = @idReceipt " +
                    "UNION ALL " +
                    "SELECT 'Total' id, '' nameBook,  SUM(a.quantity) quantity,  0 price , SUM(a.price * a.quantity) Total, '' idBook " +
                    "FROM receipt_detail a " +
                    "WHERE a.idReceipt = @idReceipt";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql, new SqlParameter { ParameterName = "@idReceipt", Value = id});
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
        

        public int insert(ReceiptDetailDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO receipt_detail (idReceipt, idBook, price, quantity) VALUES " +
                                                            "(@idReceipt, @idBook, @price, @quantity)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@idReceipt", Value = b.IdReceipt },
                            new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
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
        public int edit(ReceiptDetailDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE receipt_detail SET price = @price, quantity = @quantity WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
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
                string strSql = "DELETE FROM receipt_detail WHERE id = @id";
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
