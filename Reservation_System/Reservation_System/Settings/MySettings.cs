using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace Reservation_System
{
    class MySettings : ApplicationSettings<MySettings>
    {
        //default values
        public bool English = true;
        public bool RememberUserName = false;
        public string Username = "";
    }
}
