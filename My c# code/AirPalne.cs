using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משימת_מעבדה_3___דרכון___נוסע___טיסה
{
    class AirPlane
    {
        private string nameofairplane;
        private Date date;
        private int capacity;
     public AirPlane(string nameofairplane,Date date,int capacity) 
        {
            this.nameofairplane = nameofairplane;
            this.date = date;
            this.capacity = capacity;
        }
    public string GetAirplaneName()
        {
            return nameofairplane;
        }
    public string GetRealeseDateOfAirplane() 
        {
            return date.ToString();
        }
           public int GetCapacity()
        {
            return this.capacity;
        }
        public override string ToString()
        {
            return "The " + this.nameofairplane + " has " + this.capacity + " seats and was realesed in " + date.ToString()+".";
        
        }

    }
}
