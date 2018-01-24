using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
                  
            // luo ja näyttää uuden MainScreen elementin
            Application.EnableVisualStyles();
            MainScreen _MainScreen = new MainScreen();
           

            // Application.Run(_MainScreen);

            _MainScreen.ShowDialog();
        }
    }
}
