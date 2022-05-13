using ManageBook.DAO;
using ManageBook.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.BUS
{
    public class DebtBUS
    {
        public DataTable getAll(int id)
        {
            try
            {
                DebtDAO b = new DebtDAO();
                return b.getDebtSheet(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int insert(DebtDTO b)
        {
            try
            {
                DebtDAO dao = new DebtDAO();
                return dao.insert(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
