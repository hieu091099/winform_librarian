using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBook.DAO
{
    public class Common
    {
        private static int _currentUserId;
        private static string _typeUser;

        public static int CurrentUserId { get => _currentUserId; set => _currentUserId = value; }
        public static string TypeUser { get => _typeUser; set => _typeUser = value; }
    }
}
