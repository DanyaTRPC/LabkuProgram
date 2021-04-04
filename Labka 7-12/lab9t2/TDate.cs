using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9t2
{
    class TDate
    {
        public int Date;
        public int month;
        public int year;
        public int d;
        public int m;
        public int y;
        
        public TDate(int Date, int month, int year, int d, int m, int y)
        {
            this.Date = Date;
            this.month = month;
            this.year = year;
            this.d = d;
            this.m = m;
            this.y = y;

        }

        public int magnificationDate()
        {
             Date += d;
                if (Date == 31)
                {
                    month++;
                } 
             return Date; 
        }
        public int magnificationMonth()
        {
             month += m;
                if (month == 13)
                {
                    year++;
                }
            return month; 
        }
        public int magnificationYear()
        {
             year += y; 
             return year; 
        }
        public string ToString(int Date, int month, int year)
        {
            return $"d: {Date}, m:{month}, y:{year}";
        }

    }
}
