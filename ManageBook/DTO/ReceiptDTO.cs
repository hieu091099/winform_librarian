using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class ReceiptDTO
    {
        private int _id;
        private int _idCus;
        private string _status;
        private double _payCus;
        private int _userId;
        private DateTime _dateReceipt;
        public int Id { get => _id; set => _id = value; }
        public int IdCus { get => _idCus; set => _idCus = value; }
        public string Status { get => _status; set => _status = value; }
        public double PayCus { get => _payCus; set => _payCus = value; }
        public int UserId { get => _userId; set => _userId = value; }
        public DateTime DateReceipt { get => _dateReceipt; set => _dateReceipt = value; }
    }
}
