using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.User
{
    class User
    {
        public static string _username;        
        public static int _userid;
        private static int _Accounttype;

     
        public User(string username, int userid, int accounttype)
        {
            _username = username;
            _userid = userid;
            _Accounttype = accounttype;
        }

        public string username()
        {
            return _username;
        }

        public int userid()
        {
            return _userid;
        }
        public int accounttype()
        {
            return _Accounttype;
        }

        public static User CreateUser(string username, int userid, int accounttype)
        {
            User user = new User(username, userid, accounttype);            
            return user;
        }
    }
}