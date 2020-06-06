using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משימת_מעבדה_3___דרכון___נוסע___טיסה
{
    class Program
    {
        static string[] ExpiryDate3month(Flight flight, int[]year,int[]month,int[]day,string[]passid)
        {
            string[] ex3mnt;
            string[] gavno = new string[0];
            int count = 0;
            int capacity = 0;
            for (int i = 0; i < flight.GetPassengers(); i++)
            {
                if ((flight.GetYear() == year[i]) && (month[i] - flight.GetMonth() <= 3) && (day[i] == flight.GetDay()))
                {
                    capacity++;
                    
                }
            }
            ex3mnt = new string[capacity];

            for (int i = 0; i < flight.GetPassengers(); i++)
            {
                if ((flight.GetYear() == year[i]) && (month[i] - flight.GetMonth() <= 3) && (day[i] == flight.GetDay()))
                {
                    ex3mnt[count] = passid[i];
                    count++;
                }
           
            }
            return ex3mnt;
      }

        static string[] CantExit(Flight flight, int[] year, int[] month, int[] day, string[] passid)
        {
            string[] cantexit;
            int count = 0;
            for (int i = 0; i < flight.GetPassengers(); i++)
            {
                if ((flight.GetYear() == year[i]) && (month[i]==flight.GetMonth()) && (day[i] == flight.GetDay()))
                {
                     count++;
                }
            }
            cantexit = new string[count];
            count = 0;
            for (int i = 0; i < flight.GetPassengers(); i++)
            {
                if ((flight.GetYear() == year[i]) && (month[i] == flight.GetMonth()) && (day[i] == flight.GetDay()))
                {
                    cantexit[count] = passid[i];
                    count++;
                }
            }

            return cantexit;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Write name of airplane");
            string airplanename = Console.ReadLine();            
            Console.WriteLine("Write realese year of airplane");
            int airplaneyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Write realese month of airplane");
            int airplanemonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Write realese day of airplane");
            int airplaneday = int.Parse(Console.ReadLine());
            Date dateairplane = new Date(airplaneyear, airplanemonth, airplaneday);
            Console.WriteLine("Write capacity of airplane");
            int capacity = int.Parse(Console.ReadLine());
            AirPlane airPlane = new AirPlane(airplanename, dateairplane, capacity);
            Console.WriteLine("Write flight number");
            string flightnumber = Console.ReadLine();
            Console.WriteLine("Write flight year of flight");
            int flightyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Write flight month of flight");
            int flightmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Write flight day of flight");
            int flightday = int.Parse(Console.ReadLine());
            Date flightdate = new Date(flightyear, flightmonth, flightday);
            Flight flight1 = new Flight(airPlane, flightnumber, flightdate);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Write name of passenger");
                string name = Console.ReadLine();
                Console.WriteLine("Write password id of passenger");
                string passid = Console.ReadLine();
                Console.WriteLine("Write Ex year of passport");
                int expiryyear = int.Parse(Console.ReadLine());
                Console.WriteLine("Write Expiry month of passport");
                int expirymonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Write expiry day of passport");
                int expiryday = int.Parse(Console.ReadLine());
                Date expirydate = new Date(expiryyear, expirymonth, expiryday);
                passport pass = new passport(name, passid, expirydate);
                Console.WriteLine("Write meal type");
                string mealtype = Console.ReadLine();
                bool paid=true;
                string paidf;
                    Console.WriteLine("Has traveler paid.Write yes or no");
                    paidf = Console.ReadLine();
                    if (paidf == "yes")
                    {
                        paid = true;
                   
                }
                    else if (paidf == "no")
                    {
                        paid = false;                        
                    }
                  
                 Traveler traveler =new Traveler(pass, mealtype, paid);
                string[] hasnotpaid = new string[airPlane.GetCapacity()];
                int count = 0;
                string check="";
                if (paid == true)
                    flight1.SetTraveler(traveler);
                
                    if (paid == false)
                    {
                        Console.WriteLine("Have you paid?Write yes or no");
                        check = Console.ReadLine();
                    }         
                            
                if (check == "yes")
                {
                    traveler.SetHasPaid();
                    flight1.SetTraveler(traveler);
                }
                else if (check == "no")
                {
                   hasnotpaid[count] = traveler.GetPassId();
                    count++;
                        }
            }
            string[] ex3mnth = ExpiryDate3month(flight1, flight1.GetTravelersExYear(), flight1.GetTravelersExMonth(), flight1.GetTravelersExDAY(), flight1.GetTravelrsPassId());
            string[] Cantexit = CantExit(flight1, flight1.GetTravelersExYear(), flight1.GetTravelersExMonth(), flight1.GetTravelersExDAY(), flight1.GetTravelrsPassId());
            if (Cantexit.Length > 0)
            {
                Console.WriteLine("Those who cant exit");
                for (int i = 0; i < Cantexit.Length; i++)
                {
                    Console.WriteLine(Cantexit);
                }
            }
            if (ex3mnth.Length > 0)
            {
                Console.WriteLine("Those who has expiry date in close 3 months");
                for (int i = 0; i < ex3mnth.Length; i++)
                {
                    Console.WriteLine(ex3mnth);
                }
                Console.WriteLine(flight1.ToString());
            }













        }
    }
}
