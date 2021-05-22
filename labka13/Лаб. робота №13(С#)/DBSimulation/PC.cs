using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class PC
    {
        
        public string mail { get; set; }
        public string countFaculty { get; set; }

        public double lvlAccreditation;
        public double rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value >= 0)
                    rating = value;
                else
                    throw new Exception("Рівень акредитації не може бути відємним");
            }
        }

  

      

        public PC(string mail, string countFaculty, double lvlAccreditation, double rating)
        {
            this.mail = mail;
            this.countFaculty = countFaculty;
            this.lvlAccreditation = lvlAccreditation;
            this.rating = rating;

        }

    }
}
