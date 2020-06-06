using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משימת_מעבדה_3___דרכון___נוסע___טיסה
{
    class passport
    {
       private string name;
        private string passportid;
    Date expirydate;
      public passport(string name,string passId,Date expirydate)
        {
            this.name = name;
            this.passportid = passId;
            this.expirydate = expirydate;
        }
        public string GetName()
        {
            return this.name; 
        }
       public string GetPassId()
        {
            return this.passportid;
        }
            public void SetExpiryDate(Date date)
        {
            this.expirydate.SetDay(date.GetDay());
            this.expirydate.SetMonth(date.GetMonth());
            this.expirydate.SetYear(date.GetYear());
        }
        public bool IsValid(Date date)
        {
            if ((this.expirydate.GetDay() == date.GetDay()) && (this.expirydate.GetMonth() == date.GetMonth()) && (this.expirydate.GetYear() == date.GetYear()))
        return true;
            else return false;            
        }
    public int GetExDAY()
        {
        return expirydate.GetDay();
        }
        public int GetExMonth()
        {
            return expirydate.GetMonth();
        }
        public int GetExYear()
        {
            return expirydate.GetYear();
        }



        public override string ToString()
        {
            return "name " + name + " passport Id " + " expiry date " + expirydate.ToString() ;
        }


    }
}
