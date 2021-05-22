using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7t2
{
    class BrandCar
    {
        public string brandCar;
        public string dataProducer;
        public string dataSeller;
        public string dataOwner;
        public string color;
        public int number;
        public int releaseDate;
        public int year;
        public int s;

        public BrandCar(string brandCar, string dataProducer, string dataSeller,string dataOwner,
            string color, int number, int releaseDate, int year)
        {
            this.brandCar = brandCar;
            this.dataProducer = dataProducer;
            this.dataSeller = dataSeller;
            this.dataOwner = dataOwner;
            this.color = color;
            this.number = number;
            this.releaseDate = releaseDate;
            this.year = year;
        }
        public int ageCar()
        {
            int s = year - releaseDate;
            return s;
        }
        public string seedsTriangle()
        {
            return $"s: {s}";
        }

    }
}
