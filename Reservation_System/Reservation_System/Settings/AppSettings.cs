using Newtonsoft.Json;
using System;
using System.Web.Script.Serialization;

namespace Reservation_System
{
    public class ApplicationSettings<T> where T : new()
    {
        private const string default_name = "settings.json";

        public void SaveFile(string fileName = default_name)
        {
            string output = JsonConvert.SerializeObject(this, Formatting.Indented);
            System.IO.File.WriteAllText(fileName, output);
        }

        public static T LoadFile(string fileName = default_name)
        {
            T t = new T();
            if (System.IO.File.Exists(fileName))
                t = (new JavaScriptSerializer()).Deserialize<T>(System.IO.File.ReadAllText(fileName));
            return t;

        }

        private static void ExitProgram()
        {
            Console.WriteLine("Process has been terminated due to a exception in settings.\nPress any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void Checksettings()
        {
            string Errormessage = "";

            if (MySettings.LoadFile().English != true && MySettings.LoadFile().English != false)
                Errormessage += ("Exception: You can't leave the language setting empty\n\n");
                     
            if (Errormessage != "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Errormessage);
                Console.ForegroundColor = ConsoleColor.White;
                ExitProgram();
            }
        }
    }
}