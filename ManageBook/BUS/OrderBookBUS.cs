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
    public class OrderBookBUS
    {
        
        public DataTable getAll()
        {
            try
            {
                OrderBookDAO b = new OrderBookDAO();
                return b.getAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable queryOrder(string nameBook, string author, string kind)
        {
            try
            {
                OrderBookDAO dao = new OrderBookDAO();
                return dao.queryOrder(nameBook, author, kind);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(OrderBookDTO b)
        {
            try
            {
                OrderBookDAO dao = new OrderBookDAO();
                return dao.insert(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int edit(OrderBookDTO b)
        {
            try
            {
                OrderBookDAO dao = new OrderBookDAO();
                return dao.edit(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int remove(int id)
        {
            try
            {
                OrderBookDAO dao = new OrderBookDAO();
                return dao.remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
