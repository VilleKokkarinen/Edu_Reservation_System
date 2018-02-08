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
        public static string _email;
        public static int _userid;

        public BindingList<LoanItem> Loans { get; set; }
        public BindingList<LoanItem> AvailableItems { get; set; }

        private User(string username, int userid)
        {
            _username = username;
            _userid = userid;
            Loans = new BindingList<LoanItem>();
            AvailableItems = new BindingList<LoanItem>();      
        }

        public string username()
        {
            return _username;
        }

        public int userid()
        {
            return _userid;
        }


        public static User CreateUser(string username, int userid)
        {
            User user = new User(username, userid);            
            return user;
        }



    }
}
