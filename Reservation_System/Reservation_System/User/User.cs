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
        private string _email;
        public BindingList<Loan> Loans { get; set; }


        private User(string username)
        {
            _username = username;
            Loans = new BindingList<Loan>();            
        }

        public string username()
        {
            return _username;
        }

        public static User CreateUser(string username)
        {
            User user = new User(username);
            //user.Loans.Add();
            return user;
        }



    }
}
