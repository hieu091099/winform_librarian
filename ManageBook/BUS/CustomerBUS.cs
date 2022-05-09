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
    public class CustomerBUS
    {
        public DataTable getAllCustomers()
        {
            try
            {
                CustomerDAO b = new CustomerDAO();
                return b.getAllCustomers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insertCustomer(CustomerDTO b)
        {
            try
            {
                CustomerDAO dao = new CustomerDAO();
                return dao.insertCustomer(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editCustomer(CustomerDTO b)
        {
            try
            {
                CustomerDAO dao = new CustomerDAO();
                return dao.editCustomer(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int removeCustomer(int id)
        {
            try
            {
                CustomerDAO dao = new CustomerDAO();
                return dao.removeCustomer(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
