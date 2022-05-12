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
    public class ReceiptDetailBUS
    {
        public DataTable getAllReceipt(int id)
        {
            try
            {
                ReceiptDetailDAO b = new ReceiptDetailDAO();
                return b.getReceiptDetail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insertReceipt(ReceiptDetailDTO b)
        {
            try
            {
                ReceiptDetailDAO dao = new ReceiptDetailDAO();
                return dao.insert(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int editReceipt(ReceiptDetailDTO b)
        {
            try
            {
                ReceiptDetailDAO dao = new ReceiptDetailDAO();
                return dao.edit(b);
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
                ReceiptDetailDAO dao = new ReceiptDetailDAO();
                return dao.remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
