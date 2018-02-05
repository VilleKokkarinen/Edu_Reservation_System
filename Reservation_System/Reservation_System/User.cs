using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System
{
    class User
    {
        private string _username;

        public User(string username)
        {
            _username = username;
        }

        public string username()
        {
            return _username;
        }

    }
}
