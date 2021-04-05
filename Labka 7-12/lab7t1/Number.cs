using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace lab7t1
{
    class Number
    {
        public int a;
        public Number(int a)
        {
            this.a = a;
        }

        public int Sum()
        {
            string s = Convert.ToString(a);
            List<int> list = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(Int32.Parse(new String(arr[i], 1)));

            }
            int sum1 = list.ToArray().Sum();
            return sum1;

        }
        public int Main()
        {

            string s = Convert.ToString(a);
            List<int> list = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(Int32.Parse(new String(arr[i], 1)));
            }
            int number1 = list.Count;
            return number1;
        }
    }
}
