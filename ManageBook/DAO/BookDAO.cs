﻿using ManageBook.DTO;
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
        public DataTable reportBookQuery(string tenSach)
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
                    "LEFT JOIN books b ON a.idBook = b.id ";
                if(tenSach != "")
                {
                    strSql += $" WHERE b.nameBook LIKE N'%{tenSach}%'";
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
        public int removeBook(int id)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "DELETE FROM books WHERE id = @id";
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
