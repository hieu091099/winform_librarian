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
    public class ReceiptDAO
    {
        public DataTable getAllReceipt()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT a.id, b.fullName, a.[status], case when a.status = N'Hoàn Tất' then 0 else a.payCus end payCus, c.fullName, a.dateReceipt, a.idCus " +
                    "FROM receipt a " +
                    "LEFT JOIN customers b ON a.idCus = b.id " +
                    "LEFT JOIN users c ON a.userId = c.id";
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
        public DataTable queryReceipt(string khachHang, string trangThai, string dateFrom, string dateTo)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT a.id, b.fullName, a.[status], case when a.status = N'Hoàn Tất' then 0 else a.payCus end payCus, c.fullName, a.dateReceipt, a.idCus " +
                    "FROM receipt a " +
                    "LEFT JOIN customers b ON a.idCus = b.id " +
                    "LEFT JOIN users c ON a.userId = c.id WHERE 1=1 ";
                if(khachHang != "")
                {
                    strSql += $" AND b.fullName like N'%{khachHang}%'";
                }
                if (trangThai != "")
                {
                    strSql += $" AND a.status = {trangThai}";
                }
                if (dateFrom != "" && dateTo != "")
                {
                    strSql += $" AND a.dateReceipt BETWEEN '{dateFrom}' AND '{dateTo}'";
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
        public DataTable queryReceipt(string nameBook, string author, string kind, double price)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM receipt WHERE 1=1 ";

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
                if (price != 0)
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

        public int insertReceipt(ReceiptDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO receipt ( idCus, status, payCus, userId, dateReceipt) " +
                                                "VALUES(@idCus, @status, @payCus, 1, getdate())";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@idCus", Value = b.IdCus },
                            new SqlParameter { ParameterName = "@status", Value = b.Status },
                            new SqlParameter { ParameterName = "@payCus", Value = b.PayCus }
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
        public int editReceipt(ReceiptDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE receipt SET status = @status, payCus = @payCus WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@status", Value = b.Status } ,
                            new SqlParameter { ParameterName = "@payCus", Value = b.PayCus }

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
        public int removeReceipt(int id)
        {
            int nRow = 0;
            int nRowDetail = 0;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string strSqlDetail = "DELETE FROM receipt_detail WHERE idReceipt = @id";
                nRowDetail = provider.ExecuteNonQuery(CommandType.Text, strSqlDetail,
                            new SqlParameter { ParameterName = "@id", Value = id }

                    );
                if(nRowDetail == 1)
                {
                    string strSql = "DELETE FROM receipt WHERE id = @id";
                    nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                                new SqlParameter { ParameterName = "@id", Value = id }

                        );
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