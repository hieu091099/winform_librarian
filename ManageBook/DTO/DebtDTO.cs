using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DTO
{
    public class DebtDTO
    {
        private int _id;
        private int _idCus;
        private DateTime _collectionDate;
        private double _debtMoney;
        private string _status;
        private int _userId;
        private DateTime _createdDate;

        public int Id { get => _id; set => _id = value; }
        public int IdCus { get => _idCus; set => _idCus = value; }
        public DateTime CollectionDate { get => _collectionDate; set => _collectionDate = value; }
        public double DebtMoney { get => _debtMoney; set => _debtMoney = value; }
        public string Status { get => _status; set => _status = value; }
        public int UserId { get => _userId; set => _userId = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
    }
}
