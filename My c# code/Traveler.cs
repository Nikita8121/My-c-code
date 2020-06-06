using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משימת_מעבדה_3___דרכון___נוסע___טיסה
{
    class Traveler
    {
    private passport pass;
        private string meal;
        bool paid;
    public Traveler(passport pass,string meal, bool haspaid)
        {
            this.pass = pass;
            this.meal = meal;
            this.paid = haspaid;
                }
        public string GetName()
        {
            return pass.GetName();
        }
        public string GetPassId()
        {
            return pass.GetPassId();
        }
        public int GetExDAY()
        {
            return pass.GetExDAY();
        }
        public int GetExMonth()
        {
            return pass.GetExMonth();
        }
        public int GetExYear()
        {
            return pass.GetExYear();
        }

        public bool GetHasPaid()
        {
            if (this.paid == true)
                return true;
            else return false;            
        }
   public void  SetExpiryDate(Date date)
        {
            this.pass.SetExpiryDate(date);
        }
        public bool IsValid(Date date)
        {
            return pass.IsValid(date);
        }
            public void SetHasPaid()
        {
            this.paid = true;
        }
      
        public bool CheckTravel(int day,int month,int year)
        {
            if ((this.pass.GetExDAY() == day) && (this.pass.GetExMonth() == month) && (this.pass.GetExYear() == year))
                return true;
            else return false;            
        }
        public override string ToString()
        {
            if (paid == true)
            {
                return this.pass.ToString() + " meal type- " + this.meal + ", you paid for travel.";
            }
        else return this.pass.ToString() +  ", you haven't paid for travel.";
        }

    }
}
