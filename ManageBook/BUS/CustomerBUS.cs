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
        public DataTable getCustomers(string fullName,string email,string birthday,int gender,string address,string phone)
        {
            try
            {
                CustomerDAO b = new CustomerDAO();
                return b.getCustomers(fullName, email, birthday, gender, address, phone);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        public DataTable reportDebt()
        {
            try
            {
                CustomerDAO b = new CustomerDAO();
                return b.reportDebt();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable reportDebtQuery(string tenKhachHang)
        {
            try
            {
                CustomerDAO b = new CustomerDAO();
                return b.reportDebtQuery(tenKhachHang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getOwn()
        {
            try
            {
                CustomerDAO b = new CustomerDAO();
                return b.getOwn();
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
