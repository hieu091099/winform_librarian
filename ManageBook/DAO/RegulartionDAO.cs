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
    public class RegulartionDAO
    {
        public DataTable getAll()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT id, name, value, status, type FROM regulartion";
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
        public int editRegulartion(RegulartionDTO b)
        {
            int nRow = 0;
            Provider provider = new Provider();
            try
            {
                string strSql = "UPDATE regulartion SET value = @value, status = @status WHERE id = @id";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@id", Value = b.Id },
                            new SqlParameter { ParameterName = "@value", Value = b.Value },
                            new SqlParameter { ParameterName = "@status", Value = b.Status }


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
