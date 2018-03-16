using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.User
{
    class Loan
    {
        
        public int ID { get; set; }
        public string NAME { get; set; }
        public Loan(int id, string name)
        {
            ID = id;
            NAME = name;
        }
        
    }
}
