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
                string strSql = @"SELECT b.nameBook, b.author, b.price,SUM(a.totalQuantity) totalQuantity,
                                 (SELECT CASE WHEN  SUM(c.quantity) IS NOT NULL THEN SUM(c.quantity) ELSE 0 END value FROM receipt_detail c WHERE c.idBook = a.idBook) sold, 
                                SUM(a.totalQuantity) - (SELECT CASE WHEN  SUM(c.quantity) IS NOT NULL THEN SUM(c.quantity) ELSE 0 END value FROM receipt_detail c WHERE c.idBook = a.idBook) [else]
                                FROM warehouse a LEFT JOIN books b ON a.idBook = b.id
                                GROUP BY  b.nameBook, b.author, b.price, a.idBook, a.totalQuantity ";
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
                string strSql = @"SELECT b.nameBook, b.author, b.price,SUM(a.totalQuantity) totalQuantity,
                                 (SELECT CASE WHEN  SUM(c.quantity) IS NOT NULL THEN SUM(c.quantity) ELSE 0 END value FROM receipt_detail c WHERE c.idBook = a.idBook) sold, 
                                SUM(a.totalQuantity) - (SELECT CASE WHEN  SUM(c.quantity) IS NOT NULL THEN SUM(c.quantity) ELSE 0 END value FROM receipt_detail c WHERE c.idBook = a.idBook) [else]
                                FROM warehouse a LEFT JOIN books b ON a.idBook = b.id WHERE  1=1 ";
                if (tenSach != "")
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
                strSql += "GROUP BY  b.nameBook, b.author, b.price, a.idBook, a.totalQuantity ";
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
