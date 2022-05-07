using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class BookDTO
    {
        private int _id;
        private string _nameBook;
        private string _image;
        private string _kind;
        private string _author;
        private double _price;

        public int Id { get => _id; set => _id = value; }
        public string NameBook { get => _nameBook; set => _nameBook = value; }
        public string Image { get => _image; set => _image = value; }
        public string Kind { get => _kind; set => _kind = value; }
        public string Author { get => _author; set => _author = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
