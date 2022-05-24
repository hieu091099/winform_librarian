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
        public bool checkRegulartion(ReceiptDetailDTO b)
        {
            Provider provider = new Provider();
            provider.Connect();

            string checkTonKho = "SELECT CONVERT(INT,SUM(totalQuantity) - SUM(sold)) [Ton] FROM warehouse WHERE idBook = @idBook";
            DataTable dtTonKho = provider.Select(CommandType.Text, checkTonKho, new SqlParameter { ParameterName = "@idBook", Value = b.IdBook });
            int tonKho = dtTonKho.Rows[0].Field<int>("Ton");


            string sqlTonKhoQuyDinh = "SELECT value FROM regulartion WHERE id=4";
            DataTable dtTonKhoQuyDinh = provider.Select(CommandType.Text, sqlTonKhoQuyDinh);
            int tonKhoQuyDinh = dtTonKhoQuyDinh.Rows[0].Field<int>("value");

            if (tonKho - b.Quantity >= tonKhoQuyDinh)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int insert(ReceiptDetailDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();

            try
            {

                provider.Connect();


               if(checkRegulartion(b))
                {
                    string strSql = "INSERT INTO receipt_detail (idReceipt, idBook, price, quantity) VALUES " +
                                                            "(@idReceipt, @idBook, @price, @quantity)";
                   
                    nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                                new SqlParameter { ParameterName = "@idReceipt", Value = b.IdReceipt },
                                new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                                new SqlParameter { ParameterName = "@price", Value = b.Price },
                                new SqlParameter { ParameterName = "@quantity", Value = b.Quantity }
                        );
                    string strSqlGetSold = "SELECT sold, id  FROM warehouse WHERE idBook = @idBook AND totalQuantity >= sold ORDER BY dateImport ASC";
                    DataTable dt = provider.Select(CommandType.Text, strSqlGetSold, new SqlParameter { ParameterName = "@idBook", Value = b.IdBook });
                    int quantity = dt.Rows[0].Field<int>("sold") + b.Quantity;
                    int idRW = dt.Rows[0].Field<int>("id");

                    string strSqlUpdateWareHouse = "UPDATE warehouse SET sold = @quantity WHERE id = @id ";
                    int nRowW = provider.ExecuteNonQuery(CommandType.Text, strSqlUpdateWareHouse,
                                new SqlParameter { ParameterName = "@id", Value = idRW },
                                new SqlParameter { ParameterName = "@quantity", Value = quantity }
                        );
                }
                else
                {
                    nRow = 0;
                }

                
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
                string strSqlGetSold = "SELECT sold, id  FROM warehouse WHERE id = @id AND totalQuantity >= sold ORDER BY dateImport ASC";
                DataTable dt = provider.Select(CommandType.Text, strSqlGetSold, new SqlParameter { ParameterName = "@id", Value = b.Id });
                int quantity = dt.Rows[0].Field<int>("sold") + b.Quantity;
                int idRW = dt.Rows[0].Field<int>("id");

                string strSqlUpdateWareHouse = "UPDATE warehouse SET sold = @quantity WHERE id = @id ";
                int nRowW = provider.ExecuteNonQuery(CommandType.Text, strSqlUpdateWareHouse,
                            new SqlParameter { ParameterName = "@id", Value = idRW },
                            new SqlParameter { ParameterName = "@quantity", Value = quantity }
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
                provider.Connect();
                string strSqlGetSold = "SELECT quantity, idBook  FROM receipt_detail WHERE id = @id ";
                DataTable dt = provider.Select(CommandType.Text, strSqlGetSold, new SqlParameter { ParameterName = "@id", Value = id });
                int quantity = dt.Rows[0].Field<int>("quantity");
                int idBook = dt.Rows[0].Field<int>("idBook");



                string strSqlUpdateWareHouse = "UPDATE warehouse SET sold = sold - @quantity WHERE id = (SELECT TOP 1 id FROM warehouse WHERE idBook = @idBook ORDER BY warehouse.dateImport asc) ";
                int nRowW = provider.ExecuteNonQuery(CommandType.Text, strSqlUpdateWareHouse,
                            new SqlParameter { ParameterName = "@idBook", Value = idBook },
                            new SqlParameter { ParameterName = "@quantity", Value = quantity }
                    );

                string strSql = "DELETE FROM receipt_detail WHERE id = @id";
                
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
