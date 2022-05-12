using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class WareHouseDTO
    {
        private int _id;
        private int _idBook;
        private int _totalQuantity;
        private int _sold;
        private int _idOrder;
        private DateTime _dateOrder;

        public int Id { get => _id; set => _id = value; }
        public int IdBook { get => _idBook; set => _idBook = value; }
        public int TotalQuantity { get => _totalQuantity; set => _totalQuantity = value; }
        public int Sold { get => _sold; set => _sold = value; }
        public int IdOrder { get => _idOrder; set => _idOrder = value; }
        public DateTime DateOrder { get => _dateOrder; set => _dateOrder = value; }
    }
}
