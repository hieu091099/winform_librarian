using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class OrderBookDTO
    {
        private int _id;
        private int _idBook;
        private int _quantity;
        private double _price;
        private string _supplier;
        private int _userId;
        private DateTime _dateOrder;
        private DateTime _dateModify;

        public int Id { get => _id; set => _id = value; }
        public int IdBook { get => _idBook; set => _idBook = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public double Price { get => _price; set => _price = value; }
        public string Supplier { get => _supplier; set => _supplier = value; }
        public int UserId { get => _userId; set => _userId = value; }
        public DateTime DateOrder { get => _dateOrder; set => _dateOrder = value; }
        public DateTime DateModify { get => _dateModify; set => _dateModify = value; }
    }
}
