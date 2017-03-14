using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDBOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HotelContext())
            {
                Console.WriteLine("Alt info om hotellerne: ");
                /*var name = Console.ReadLine();*/

                var query = from b in db.Hotel
                            select b;

              
                foreach (var item in query)
                {
                    Console.WriteLine("Hotel no: " + item.Hotel_No + " Navn: " + item.Name + " Address: " + item.Address);
                }

                Console.WriteLine("Press any key to go to Guest...");
                Console.ReadKey();

                var query2 = from g in db.Guest
                    select g;
                Console.WriteLine("Gæster:");
                foreach (var item in query2)
                {
                    Console.WriteLine("Guest no; " + item.Guest_No + " Guest Navn: " + item.Name + " Guest Adress " + item.Address);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
