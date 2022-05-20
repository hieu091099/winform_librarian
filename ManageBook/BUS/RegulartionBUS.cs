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
    public class RegulartionBUS
    {
        public DataTable getAll()
        {
            try
            {
                RegulartionDAO b = new RegulartionDAO();
                return b.getAll();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int editRegulartion(RegulartionDTO b)
        {
            try
            {
                RegulartionDAO dao = new RegulartionDAO();
                return dao.editRegulartion(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
