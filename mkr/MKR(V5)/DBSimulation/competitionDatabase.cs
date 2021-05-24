using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class competitionDatabase
    {
        private List<competition> _Db = new List<competition>();

        //додати
        public void Add(competition competition)
        {
            _Db.Add(competition);
        }

        //вилучити
        public void Remove(competition competition)
        {
            _Db.Remove(competition);
        }

        //дізнатись кількість записів в базі
        public int Count
        {
            get
            {
                return _Db.Count;
            }
        }

        public List<competition> Query(Func<competition, bool> condition)
        {
            return _Db.Where(condition).ToList();
        }

        public List<competition> GetAll()
        {
            return this._Db;
        }

        public competition GetByIndex(int index)
        {
            return this._Db[index];
        }
        public double medRating()
        {
            int sum = 0;
            for (int i = 0; i < _Db.Count; i++)
            {
                sum += _Db[i].rating;

            }
            double k = sum / _Db.Count;
            return k;
        }
    }
}
