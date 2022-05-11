using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class ReceiptDetailDTO
    {
        private int _id;
        private int _idReceipt;
        private int _idBook;
        private double _price;
        private int _quantity;

        public int Id { get => _id; set => _id = value; }
        public int IdReceipt { get => _idReceipt; set => _idReceipt = value; }
        public int IdBook { get => _idBook; set => _idBook = value; }
        public double Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
