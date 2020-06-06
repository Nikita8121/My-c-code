using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משימת_מעבדה_3___דרכון___נוסע___טיסה
{
    class Date
    {
        private int day;
        private int month;
        private int year;
        public Date(int year,int month,int day )
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
   public int GetYear()
        {
            return this.year;
        } 
    public int GetMonth()
        {
            return this.month;
                }
        public int GetDay()
        {
            return this.day;
        }
public void SetYear(int year)
        {
            this.year = year;
               }
        public void SetMonth(int month)
        {
            this.month = month;
        }
        public void SetDay(int day)
        {
            this.day =day;
        }
    public bool SameDate(Date date)
        {
            if ((this.year == date.GetYear()) && (this.day == date.GetDay()) && (this.month == date.GetMonth()))
                return true;
            else return false;       
        }
         public int CompareDate(Date date)
        {

            if ((this.year == date.GetYear()) && (this.day == date.GetDay()) && (this.month == date.GetMonth()))
                return 0;
            else if (this.year < date.GetYear())
                    return 1;
            else if (this.year < date.GetYear() && (this.day < date.GetDay()))
                return 1;
            else if (this.year < date.GetYear() && (this.day < date.GetDay()) && (this.month == date.GetMonth()))
                return 1;
        else return -1;
        }
        public override string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
              }
                }
}
