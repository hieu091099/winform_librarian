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
    public class BookDAO
    {
        public DataTable getAllBooks()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM books";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql);
                return dt;

            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public DataTable getBookInWareHouse()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT a.* FROM books a, warehouse b WHERE a.id = b.idBook";
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
        public DataTable reportBook()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "IF OBJECT_ID(N'Tempdb..#tempA') IS NOT  NULL  DROP TABLE #tempA SELECT b.id, a.totalQuantity, a.sold, a.dateImport INTO #tempA FROM warehouse a LEFT JOIN books b ON a.idBook = b.id GROUP BY b.id, a.totalQuantity, a.sold, a.dateImport SELECT b.id, b.nameBook, b.author, b.kind, (SELECT TOP 1 totalQuantity - sold FROM #tempA WHERE id = a.idBook ORDER BY dateImport ASC ) [TonDau] ,SUM(a.totalQuantity - a.sold) - (SELECT TOP 1 totalQuantity - sold FROM #tempA WHERE id = a.idBook ORDER BY dateImport ASC ) [PhatSinh] ,SUM(a.totalQuantity - a.sold)[TonCuoi]  FROM warehouse a LEFT JOIN books b ON a.idBook = b.id GROUP BY b.id, b.nameBook, a.idBook, b.author, b.kind";
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
        public DataTable reportBookQuery(string tenSach, string dateFrom, string dateTo)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "IF OBJECT_ID(N'Tempdb..#tempA') IS NOT  NULL  DROP TABLE #tempA " +
                    "SELECT b.id, a.totalQuantity, a.sold, a.dateImport " +
                    "INTO #tempA FROM warehouse a " +
                    "LEFT JOIN books b ON a.idBook = b.id " +
                    "GROUP BY b.id, a.totalQuantity, a.sold, a.dateImport " +
                    "SELECT b.id, b.nameBook, b.author, b.kind" +
                    ",(SELECT TOP 1 totalQuantity - sold FROM #tempA WHERE id = a.idBook ORDER BY dateImport ASC ) [TonDau] " +
                    ",SUM(a.totalQuantity - a.sold) - (SELECT TOP 1 totalQuantity - sold FROM #tempA WHERE id = a.idBook ORDER BY dateImport ASC ) [PhatSinh] " +
                    ",SUM(a.totalQuantity - a.sold)[TonCuoi]  " +
                    "FROM warehouse a " +
                    "LEFT JOIN books b ON a.idBook = b.id WHERE 1=1 ";
                if(tenSach != "")
                {
                    strSql += $" AND b.nameBook LIKE N'%{tenSach}%'";
                }
                if (dateFrom != "" && dateTo != "")
                {
                    DateTime tuNgay = DateTime.Parse(dateFrom);
                    DateTime denNgay = DateTime.Parse(dateTo);

                    strSql += $" AND a.dateImport BETWEEN '{tuNgay.ToString("yyyyMMdd")}' AND '{denNgay.ToString("yyyyMMdd")}'";
                }
                strSql +=  "GROUP BY b.id, b.nameBook, a.idBook, b.author, b.kind";

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
        public DataTable queryBook(string nameBook, string author, string kind, double price)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM books WHERE 1=1 ";

                if (nameBook != "")
                {
                    strSql += $" AND  nameBook LIKE '%{nameBook}%'";
                }
                if (author != "")
                {
                    strSql += $" AND  author LIKE '%{nameBook}%'";
                }
                if (kind != "")
                {
                    strSql += $" AND  kind= '{kind}'";
                }
                if(price != 0)
                {
                    strSql += $" AND  price= '{price}'";

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

        public int insertBook(BookDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO books (nameBook, kind, author, price) VALUES(@nameBook, @kind, @author, @price)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@nameBook", Value = b.NameBook },
                            new SqlParameter { ParameterName = "@kind", Value = b.Kind },
                            new SqlParameter { ParameterName = "@author", Value = b.Author },
                            new SqlParameter { ParameterName = "@price", Value = b.Price }
                    );

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
        public int editBook(BookDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE books SET nameBook = @nameBook, kind = @kind, author = @author, price = @price WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@nameBook", Value = b.NameBook },
                            new SqlParameter { ParameterName = "@kind", Value = b.Kind },
                            new SqlParameter { ParameterName = "@author", Value = b.Author },
                            new SqlParameter { ParameterName = "@price", Value = b.Price }
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
        public bool checkConditionDelete(int id)
        {
            Provider provider = new Provider();
            provider.Connect();
            string check = "SELECT COUNT(*) FROM order_book WHERE idBook=@id ";
            DataTable dt = provider.Select(CommandType.Text, check, new SqlParameter { ParameterName = "@id", Value = id });
            int result = (int)dt.Rows[0][0];

            string checks = "SELECT COUNT(*) FROM receipt_detail WHERE idBook=@id ";
            DataTable dts = provider.Select(CommandType.Text, checks, new SqlParameter { ParameterName = "@id", Value = id });
            int results = (int)dts.Rows[0][0];
            if (result == 0 && results == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public int removeBook(int id)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                
                if(checkConditionDelete(id)) {
                    string strSql = "DELETE FROM books WHERE id = @id";
                    nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                                new SqlParameter { ParameterName = "@id", Value = id }

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
    }
}
