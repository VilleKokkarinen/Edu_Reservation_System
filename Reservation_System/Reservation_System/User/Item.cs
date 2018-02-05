using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System.User
{
    class Item
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int TYPE { get; set; }
        public int STATE { get; set; }
        public Item(int id, string name, int type, int state)
        {
            ID = id;
            NAME = name;
            TYPE = type;
            STATE = state;
        }
    }
}