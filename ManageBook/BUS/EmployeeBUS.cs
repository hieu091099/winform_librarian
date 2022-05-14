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
    public class EmployeeBUS
    {
        public DataTable getEmployee(string taiKhoan, string hoTen, string loaiNguoiDung)
        {
            try
            {
                EmployeeDAO b = new EmployeeDAO();
                return b.getEmployee(taiKhoan, hoTen, loaiNguoiDung);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getAllEmployee()
        {
            try
            {
                EmployeeDAO b = new EmployeeDAO();
                return b.getAllEmployee();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insertEmployee(EmployeeDTO b)
        {
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                return dao.insertEmployee(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editEmployee(EmployeeDTO b)
        {
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                return dao.editEmployee(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int removeEmployee(int id)
        {
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                return dao.removeEmployee(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
