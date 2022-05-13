using ManageBook.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.BUS
{
    public class WareHouseBUS
    {
        public DataTable getAll()
        {
            try
            {
                WareHouseDAO b = new WareHouseDAO();
                return b.getAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable query(string tenSach, string tacGia, string tuNgay, string denNgay)
        {
            try
            {
                WareHouseDAO b = new WareHouseDAO();
                return b.query(tenSach, tacGia, tuNgay, denNgay);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
