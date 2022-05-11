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
    public class ReceiptBUS
    {
        public DataTable getAllReceipt()
        {
            try
            {
                ReceiptDAO b = new ReceiptDAO();
                return b.getAllReceipt();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insertReceipt(ReceiptDTO b)
        {
            try
            {
                ReceiptDAO dao = new ReceiptDAO();
                return dao.insertReceipt(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editReceipt(ReceiptDTO b)
        {
            try
            {
                ReceiptDAO dao = new ReceiptDAO();
                return dao.editReceipt(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int removeReceipt(int id)
        {
            try
            {
                ReceiptDAO dao = new ReceiptDAO();
                return dao.removeReceipt(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
