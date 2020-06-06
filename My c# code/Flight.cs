using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משימת_מעבדה_3___דרכון___נוסע___טיסה
{
    class Flight
    {
              private AirPlane airplane;
           private Traveler[] traveler;
        private string flightnumber;
        private int passengers;
        private Date date;
        
        public Flight(AirPlane airplane,string flightnumber,Date date)
        {
            this.airplane = airplane;
            this.date = date;
            this.traveler = new Traveler[airplane.GetCapacity()];
            this.flightnumber = flightnumber;
            this.passengers = 0;
        }
  //Class airplane methods start
        public string GetAirplaneName()
        {
            return airplane.GetAirplaneName();
        }
        public string GetRealeseDateOfAirplane()
        {
            return airplane.GetRealeseDateOfAirplane();
        }
        public int GetCapacity()
        {
            return airplane.GetCapacity();
        }
        // class airplane methods end
        //class traveler methods
        public void  SetTraveler(Traveler traveler)
        {
            this.traveler[passengers] = traveler;
            passengers++;
        }
      public int[] GetTravelersExYear()
        {
            int[] ExYear = new int[this.passengers];
        for(int i=0;i<this.passengers;i++)
            {
                ExYear[i] = traveler[i].GetExYear();
            }
            return ExYear;            
        }
        public int[] GetTravelersExMonth()
        {
            int[] ExMonth = new int[this.passengers];
            for (int i = 0; i < this.passengers; i++)
            {
                ExMonth[i] = traveler[i].GetExMonth();
            }
            return ExMonth;
        }
        public int[] GetTravelersExDAY()
        {
            int[] ExDay = new int[this.passengers];
            for (int i = 0; i < this.passengers; i++)
            {
                ExDay[i] = traveler[i].GetExYear();
            }
            return ExDay;
        }
        public string[] GetTravelrsPassId()
        {
            string[] passid = new string[this.passengers];
            for (int i = 0; i < this.passengers; i++)
            {
                passid[i] = traveler[i].GetPassId();
                        }
            return passid;    
        }


        //class traveler methods end
        //class date
        public int GetYear()
        {
            return date.GetYear();
        }
        public int GetMonth()
        {
            return date.GetMonth();
        }
        public int GetDay()
        {
            return date.GetDay();
        }
        public string GetFlightDate()
        {
            return date.ToString();
        }
            //class date end
public int GetPassengers()
        {
            return passengers;
        }
public override string ToString()
        {
            return airplane.ToString() + "Flight number of this flight is " + this.flightnumber + " and date of this flight is " + date + " and on this flight will be " + this.passengers + " passengers.";
        }





















    }
}
