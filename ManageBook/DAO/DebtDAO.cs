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
                string strSql = "SELECT  a.debtMoney, a.collectionDate, a.[status], b.fullName, a.createdDate FROM debt_sheet a LEFT JOIN users b ON a.userId = b.id WHERE a.idCus = @idCus";
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
                                                            "(@idCus, @collectionDate, @debtMoney, N'Chờ Trả', 1, getdate())";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@idCus", Value = b.IdCus },
                            new SqlParameter { ParameterName = "@collectionDate", Value = b.CollectionDate },
                            new SqlParameter { ParameterName = "@debtMoney", Value = b.DebtMoney }
                           
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
        public int edit(DebtDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE debt_sheet SET status = N'Hoàn tất' WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id }
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

                string strSql = "DELETE FROM debt_sheet WHERE id = @id";
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
