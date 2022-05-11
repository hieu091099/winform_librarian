using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DAO
{
    public class Common
    {
        private string _currentUserId;

        public string CurrentUserId { get => _currentUserId; set => _currentUserId = value; }
    }
}
