using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DAO
{
    class Provider
    {
        static string conString = @"Data Source=192.168.18.172;Initial Catalog=QLThuVien;User ID=lacty;Password=wu0g3tp6";
        SqlConnection Connection { get; set; }

        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(conString);
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public int ExecuteNonQuery(CommandType cmtType, string strSql,
                            params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ExecuteScalar(CommandType cmtType, string strSql,
                            params SqlParameter[] parameters)
        {
            int returnId = -1;
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                object returnObj = command.ExecuteScalar();

                if (returnObj != null)
                {
                    int.TryParse(returnObj.ToString(), out returnId);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return returnId;
        }

        public DataTable Select(CommandType cmtType, string strSql,
                            params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
