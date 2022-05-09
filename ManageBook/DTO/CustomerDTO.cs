using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class CustomerDTO
    {
        private int _id;
        private string _fullName;
        private bool _gender;
        private DateTime _birthday;
        private string _email;
        private int _phone;
        private string _address;

        public int Id { get => _id; set => _id = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public bool Gender { get => _gender; set => _gender = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public string Email { get => _email; set => _email = value; }
        public int Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
    }
}
