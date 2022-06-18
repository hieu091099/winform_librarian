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
    public class DebtDAO
    {
        public DataTable getDebtSheet(int id)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT  a.id,  a.debtMoney, a.collectionDate, a.[status], b.fullName, a.createdDate FROM debt_sheet a LEFT JOIN users b ON a.userId = b.id WHERE a.idCus = @idCus";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSql, new  SqlParameter { ParameterName = "@idCus", Value = id });
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


        public int insert(DebtDTO b)
        {
            int nRow = 0;
            
            Provider provider = new Provider();
            try
            {
                string strSql = "INSERT INTO debt_sheet (idCus, collectionDate, debtMoney, status, userId, createdDate) VALUES " +
                                                            "(@idCus, @collectionDate, @debtMoney, N'Chờ Trả', @userId, getdate())";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@idCus", Value = b.IdCus },
                            new SqlParameter { ParameterName = "@collectionDate", Value = b.CollectionDate },
                            new SqlParameter { ParameterName = "@debtMoney", Value = b.DebtMoney },
                            new SqlParameter { ParameterName = "@userId", Value = Common.CurrentUserId }

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
        public int edit(int id)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                //string sqlGetIdCus = "SELECT idCus, debtMoney FROM debt_sheet WHERE id = @id";
                //DataTable dt = provider.Select(CommandType.Text, sqlGetIdCus, new SqlParameter { ParameterName = "@id", Value = id });
                //int idCus = dt.Rows[0].Field<int>("idCus");
                //double debtMoney = dt.Rows[0].Field<double>("debtMoney");


                //string sqlGetTotalDebt = " SELECT a.id, a.idCus, a.payCus, SUM(b.price * b.quantity) [total] FROM receipt a LEFT JOIN receipt_detail b ON b.idReceipt = a.id WHERE idCus = @idCus GROUP BY a.id, a.idCus, a.payCus";
                //DataTable dts = provider.Select(CommandType.Text, sqlGetTotalDebt, new SqlParameter { ParameterName = "@idCus", Value = idCus });
                //foreach (DataRow row in dts.Rows)
                //{
                //    if (Convert.ToDouble(row["total"].ToString()) < debtMoney){
                //        string update = "update receipt set status = N'Hoàn Tất' where id = @id";
                //        provider.ExecuteNonQuery(CommandType.Text, update,
                //            new SqlParameter { ParameterName = "@id", Value = Int32.Parse(row["id"].ToString()) });
                //        debtMoney = debtMoney - Convert.ToDouble(row["total"].ToString());
                //    }
                //    else
                //    {
                //        string update = "update receipt set payCus = payCus + @money where id = @id";
                //        provider.ExecuteNonQuery(CommandType.Text, update,
                //            new SqlParameter { ParameterName = "@money", Value = debtMoney });
                //    }
                //}

                string strSql = "UPDATE debt_sheet SET status = N'Hoàn Tất' WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = id}
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
                string strSql = "DELETE FROM debt_sheet WHERE id = @id AND status = N'Chờ Trả'";
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
