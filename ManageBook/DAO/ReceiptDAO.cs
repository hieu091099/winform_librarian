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
                    DateTime tuNgay = DateTime.Parse(dateFrom);
                    DateTime denNgay = DateTime.Parse(dateTo);

                    strSql += $" AND a.dateReceipt BETWEEN '{tuNgay.ToString("yyyyMMdd")}' AND '{denNgay.ToString("yyyyMMdd")}'";
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
        public bool checkRegulartionCustomer(ReceiptDTO b)
        {
            Provider provider = new Provider();
            try {
                provider.Connect();

                string sqlNoKhachHang = "SELECT CASE WHEN  CONVERT(INT,SUM(b.price * b.quantity)) IS NOT NULL THEN CONVERT(INT,SUM(b.price * b.quantity)) ELSE 0 END   [total]  FROM receipt a LEFT JOIN receipt_detail b ON a.id = b.idReceipt WHERE a.[status] = N'Trả Trước' AND a.idCus =@idCus";
                DataTable dtNo = provider.Select(CommandType.Text, sqlNoKhachHang, new SqlParameter { ParameterName = "@idCus", Value = b.IdCus });
                int no = dtNo.Rows[0].Field<int>("total");


                string sqlQuyDinhNo = "SELECT value, status FROM regulartion WHERE id=3";
                DataTable dtQuyDinhNo = provider.Select(CommandType.Text, sqlQuyDinhNo);
                int quyDinhNo = dtQuyDinhNo.Rows[0].Field<int>("value");
                bool status = dtQuyDinhNo.Rows[0].Field<bool>("status");


                if (status == true)
                {
                    if (no <= quyDinhNo)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
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
                

                if(checkRegulartionCustomer(b))
                {
                    string strSql = "INSERT INTO receipt ( idCus, status, payCus, userId, dateReceipt) " +
                                               "VALUES(@idCus, @status, @payCus, @userId, getdate())";
                    provider.Connect();
                    nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                                new SqlParameter { ParameterName = "@idCus", Value = b.IdCus },
                                new SqlParameter { ParameterName = "@status", Value = b.Status },
                                new SqlParameter { ParameterName = "@userId", Value = Common.CurrentUserId },
                                new SqlParameter { ParameterName = "@payCus", Value = b.PayCus }
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
                
                string strSql = "DELETE FROM receipt WHERE id = @id";
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
