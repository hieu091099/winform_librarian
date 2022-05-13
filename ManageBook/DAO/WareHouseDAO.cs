using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DAO
{
    public class WareHouseDAO
    {
        public DataTable getAll()
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT a.id, b.nameBook, b.author, b.price, a.totalQuantity, a.sold, a.totalQuantity - a.sold [else], a.dateImport  FROM warehouse a LEFT JOIN books b ON a.idBook = b.id  ";
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
        public DataTable query(string tenSach, string tacGia, string tuNgay, string denNgay)
        {
            Provider provider = new Provider();
            try
            {
                string strSql = "SELECT a.id, b.nameBook,b.author, b.price, a.totalQuantity, a.sold, a.totalQuantity - a.sold [else], a.dateImport  FROM warehouse a LEFT JOIN books b ON a.idBook = b.id WHERE 1=1 ";
                if(tenSach != "")
                {
                    strSql += $" AND b.nameBook LIKE N'%{tenSach}%'";
                }
                if (tacGia != "")
                {
                    strSql += $" AND b.author LIKE N'%{tacGia}%'";
                }
                if (tuNgay != "" & denNgay != "")
                {
                    DateTime dateFrom = DateTime.Parse(tuNgay);
                    DateTime dateTo = DateTime.Parse(denNgay);

                    strSql += $" AND a.dateImport BETWEEN '{dateFrom.ToString("yyyyMMdd")}' AND '{dateTo.ToString("yyyyMMdd")}'";
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
    }
}
