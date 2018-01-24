using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql;
using FirebirdSql.Data.FirebirdClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionstring = "User=SYSDBA;Password=sysdbapassword;Database=C:\\Users\\p119980\\Documents\\Kansio\\Reservationsystem.fdb;Datasource=192.168.56.1;";

            FbConnection fb = new FbConnection();
            fb.ConnectionString = connectionstring;

            fb.Open();

            FbCommand command = new FbCommand();
            command.CommandText = "select * from users";

            FbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string value = reader.GetValue(i).ToString();
                    Console.WriteLine(value);
                }
                    
            }
            

            Console.ReadLine();



        }
    }
}
