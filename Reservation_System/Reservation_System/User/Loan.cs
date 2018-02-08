using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.User
{
    class LoanItem
    {
        private Item _details;

        public Item Details
        {
            get { return _details; }
            set
            {
                _details = value;               
            }
        }
        public int ItemID
        {
            get { return Details.ID; }
            
        }
        public string Description
        {
            get { return Details.NAME; }
        }

        public LoanItem(Item details)
        {
            Details = details;
        }
    }
}
