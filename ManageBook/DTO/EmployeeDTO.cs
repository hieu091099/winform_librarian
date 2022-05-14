using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class EmployeeDTO
    {
        private int _id;
        private string _username;
        private string _password;
        private string _fullName;
        private string _type;
        private Boolean _status;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Type { get => _type; set => _type = value; }
        public bool Status { get => _status; set => _status = value; }
    }
}
