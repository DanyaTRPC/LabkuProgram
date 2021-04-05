using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9t2
{
    class TDate
    {
        public int days;
        public int month;
        public int year;
        public int addDays;
        public int addMonth;
        public int addYear;

        TDate()
        {
            this.days = 0;
            this.month = 0;
            this.year = 0;
            this.addDays = 0;
            this.addMonth = 0;
            this.addYear = 0;
        }
        public TDate(int days, int month, int year, int addDays, int addMonth, int addYear)
        {
            this.days = days;
            this.month = month;
            this.year = year;
            this.addDays = addDays;
            this.addMonth = addMonth;
            this.addYear = addYear;


        }

        public string magnificationDays()
        {
            DateTime date1 = new DateTime(year, month, days);
            return $"{date1.AddDays(addDays)}";
        }
        public string magnificationMonth()
        {
            DateTime date1 = new DateTime(year, month, days);
            return $"{date1.AddMonths(addMonth)}"; 
        }
        public string magnificationYear()
        {
            DateTime date1 = new DateTime(year, month, days);
            return $"{date1.AddYears(addYear)}";
        }
        public string Tostring()
        {
            return $"days: {days}, month:{month}, year:{year}";
        }

    }
}
