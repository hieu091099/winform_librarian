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
                string strSql = "SELECT * FROM customers ";
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
        public DataTable reportDebt()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "IF OBJECT_ID(N'Tempdb..#tempN') IS NOT  NULL  DROP TABLE #tempN " +
                    "SELECT a.id, a.idCus, a.payCus, SUM(b.price * b.quantity)[TongNo], a.dateReceipt " +
                    "INTO #tempN " +
                    "FROM receipt a " +
                    "LEFT JOIN receipt_detail b ON a.id = b.idReceipt " +
                    "WHERE a.[status] = N'Trả Trước' " +
                    "GROUP BY a.id, a.idCus, a.payCus, a.dateReceipt " +
                    "SELECT b.id, b.fullName " +
                    ",(SELECT TOP 1 TongNo - payCus  FROM #tempN WHERE a.idCus = idCus ORDER BY dateReceipt ASC ) [NoDau] " +
                    ",(SUM(c.price * c.quantity) - a.payCus) - (SELECT TOP 1 TongNo - payCus  FROM #tempN WHERE a.idCus = idCus ORDER BY dateReceipt ASC ) [PhatSinh] " +
                    ",SUM(c.price * c.quantity) - a.payCus[TongNo] " +
                    ", b.birthday, b.[address]" +
                    "FROM receipt a " +
                    "LEFT JOIN customers b ON a.idCus = b.id " +
                    "LEFT JOIN receipt_detail c ON c.idReceipt = a.id " +
                    "WHERE a.[status] = N'Trả Trước' " +
                    "GROUP BY b.id, b.fullName,b.birthday,b.[address], a.idCus, a.payCus ";
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
        public DataTable reportDebtCus()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT b.fullName, a.id," +
                                "(SELECT SUM(c.price * quantity) FROM receipt_detail c WHERE c.idReceipt = a.id)[total], " +
                                "a.payCus, " +
                                "(SELECT SUM(c.price * quantity) FROM receipt_detail c WHERE c.idReceipt = a.id) -a.payCus[else], " +
                                "b.birthday, b.[address] " +
                                "FROM receipt a " +
                                "LEFT JOIN customers b ON a.idCus = b.id " +
                                "WHERE a.[status] = N'Trả Trước' GROUP BY b.fullName, a.id, a.payCus, b.birthday, b.[address] ";
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

        public DataTable reportDebtQuery(string tenKhachHang, string dateFrom, string dateTo)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "IF OBJECT_ID(N'Tempdb..#tempN') IS NOT  NULL  DROP TABLE #tempN " +
                    "SELECT a.id, a.idCus, a.payCus, SUM(b.price * b.quantity)[TongNo], a.dateReceipt " +
                    "INTO #tempN " +
                    "FROM receipt a " +
                    "LEFT JOIN receipt_detail b ON a.id = b.idReceipt " +
                    "WHERE a.[status] = N'Trả Trước' " +
                    "GROUP BY a.id, a.idCus, a.payCus, a.dateReceipt " +
                    "SELECT b.id, b.fullName " +
                    ",(SELECT TOP 1 TongNo - payCus  FROM #tempN WHERE a.idCus = idCus ORDER BY dateReceipt ASC ) [NoDau] " +
                    ",(SUM(c.price * c.quantity) - a.payCus) - (SELECT TOP 1 TongNo - payCus  FROM #tempN WHERE a.idCus = idCus ORDER BY dateReceipt ASC ) [PhatSinh] " +
                    ",SUM(c.price * c.quantity) - a.payCus[TongNo] " +
                    ", b.birthday, b.[address]" +
                    "FROM receipt a " +
                    "LEFT JOIN customers b ON a.idCus = b.id " +
                    "LEFT JOIN receipt_detail c ON c.idReceipt = a.id " +
                    "WHERE a.[status] = N'Trả Trước' ";
                if(tenKhachHang != "")
                {
                    strSql += $" AND b.fullName like '%{tenKhachHang}%'";
                }
                if (dateFrom != "" && dateTo != "")
                {
                    DateTime tuNgay = DateTime.Parse(dateFrom);
                    DateTime denNgay = DateTime.Parse(dateTo);

                    strSql += $" AND a.dateReceipt BETWEEN '{tuNgay.ToString("yyyyMMdd")}' AND '{denNgay.ToString("yyyyMMdd")}'";
                }
                strSql += "GROUP BY b.id, b.fullName,b.birthday,b.[address], a.idCus, a.payCus ";
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

        public DataTable getOwn()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT b.id, b.fullName,  SUM(c.price * c.quantity) [total], a.payCus, SUM(c.price * c.quantity) - a.payCus [else], b.phone, b.email, b.[address] FROM receipt a LEFT JOIN customers b ON a.idCus = b.id LEFT JOIN receipt_detail c ON a.id = c.idReceipt WHERE a.[status] = N'Trả Trước' GROUP BY b.id, b.fullName, b.phone, b.email, b.[address], a.payCus ";
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

        public DataTable getCustomers(string fullName, string email, string birthday, int gender, string address, string phone)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT * FROM customers WHERE 1=1 ";
                if(fullName != "")
                {
                    strSql += $" AND fullName like N'%{fullName}%'";
                }
                if(birthday != "" )
                {
                    DateTime date = DateTime.Parse(birthday);
                    strSql += $" AND birthday = '{date.ToString("yyyyMMdd")}'";
                }
                if(email != "")
                {
                    strSql += $" AND email like '{email}%'";

                }
                if (phone != "")
                {
                    strSql += $" AND phone like '{phone}%'";

                }
                if(address != "")
                {
                    strSql += $" AND address like N'%{address}%'";

                }
                if (gender != -1 )
                {
                       strSql += $" AND gender = {gender}";
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
