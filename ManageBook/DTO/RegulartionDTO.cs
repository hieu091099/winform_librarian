using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class RegulartionDTO
    {
        private int _id;
        private string _name;
        private Boolean _status;
        private string _type;
        private int _value; 

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public int Value { get => _value; set => _value = value; }
        public bool Status { get => _status; set => _status = value; }
    }
}
