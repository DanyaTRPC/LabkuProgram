using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class competition
    {
        public string surName { get; set; }
        public int age { get; set; }

        public string specialty;
        public int rating { get; set; }






        public competition(string surName, int age, string specialty, int rating)
        {
            this.surName = surName;
            this.age = age;
            this.specialty = specialty;
            this.rating = rating;

        }
        
    }
}
