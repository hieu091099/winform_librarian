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
    public class BookBUS
    {
        public DataTable getAllBooks()
        {
            try
            {
                BookDAO b = new BookDAO();
                return b.getAllBooks();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable queryBook(string nameBook, string author, string kind, double price)
        {
            try
            {
                BookDAO b = new BookDAO();
                return b.queryBook(nameBook, author, kind, price);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insertBook(BookDTO b)
        {
            try
            {
                BookDAO dao = new BookDAO();
                return dao.insertBook(b);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public int editBook(BookDTO b)
        {
            try
            {
                BookDAO dao = new BookDAO();
                return dao.editBook(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int removeBook(int id)
        {
            try
            {
                BookDAO dao = new BookDAO();
                return dao.removeBook(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
