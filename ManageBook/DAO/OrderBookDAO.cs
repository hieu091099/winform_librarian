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
                    strSql += $" AND  b.author LIKE '%{author}%'";
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
        public bool checkRegulartion(OrderBookDTO b)
        {
            Provider provider = new Provider();
            provider.Connect();

            string checkTonKho = "SELECT SUM(totalQuantity) - SUM(sold) [Ton] FROM warehouse WHERE idBook = @idBook";
            DataTable dtTonKho = provider.Select(CommandType.Text, checkTonKho, new SqlParameter { ParameterName = "@idBook", Value = b.IdBook });
            int tonKho = dtTonKho.Rows[0].Field<int>("Ton");
            string sqlTonKhoQuyDinh = "SELECT value FROM regulartion WHERE id=2";
            DataTable dtTonKhoQuyDinh = provider.Select(CommandType.Text, sqlTonKhoQuyDinh);
            int tonKhoQuyDinh = dtTonKhoQuyDinh.Rows[0].Field<int>("value");
            // check quy dinh so luong sach nhap it nhat
            string sqlLuongSachNhapItNhat = "SELECT value FROM regulartion WHERE id=1";
            DataTable dtLuongSachNhap = provider.Select(CommandType.Text, sqlLuongSachNhapItNhat);
            int luongSachNhap = dtLuongSachNhap.Rows[0].Field<int>("value");
            if (tonKho <= tonKhoQuyDinh && b.Quantity >= luongSachNhap)
            {
                return true;
            }
            else
            {
                return false;
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
                // check quy định tồn kho
               
                if (checkRegulartion(b) == true)
                {

                    string strSql = "INSERT INTO order_book ( idBook, quantity, price, supplier, userId, dateOrder, dateModify) " +
                        "VALUES(@idBook, @quantity, @price, @supplier, @userId, getdate(), getdate()); SELECT SCOPE_IDENTITY();";
                    string insertWareHouse = "INSERT INTO warehouse (idBook, totalQuantity, sold, idOrder, dateImport) VALUES (@idBook, @quantity, 0, @id, getdate())";
                    idInsert = provider.ExecuteScalar(CommandType.Text, strSql,
                                new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                                new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                                new SqlParameter { ParameterName = "@price", Value = b.Price },
                                new SqlParameter { ParameterName = "@supplier", Value = b.Supplier },
                                new SqlParameter { ParameterName = "@userId", Value = Common.CurrentUserId }
                        );

                    nRowWareHouse = provider.ExecuteNonQuery(CommandType.Text, insertWareHouse,
                                new SqlParameter { ParameterName = "@idBook", Value = b.IdBook },
                                new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                                new SqlParameter { ParameterName = "@id", Value = idInsert }

                        );
                }
                else
                {
                    nRowWareHouse = 0;
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
                    ", userId = @userId,  dateModify = getdate() WHERE id = @id";
                string updateWareHouse = "UPDATE warehouse SET totalQuantity = @quantity WHERE idOrder = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@quantity", Value = b.Quantity },
                            new SqlParameter { ParameterName = "@price", Value = b.Price },
                            new SqlParameter { ParameterName = "@userId", Value = Common.CurrentUserId },
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
