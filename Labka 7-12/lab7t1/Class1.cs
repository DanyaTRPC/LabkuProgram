using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace lab7t1
{
    class Class1
    {

        public static void Sum(string[] args, int a)
        {
            string s = Convert.ToString(a);
            List<int> list = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(Int32.Parse(new String(arr[i], 1)));

            }
            int sum1 = list.ToArray().Sum();

        }
        public static void Main(string[] args, int a)
        {

            string s = Convert.ToString(a);
            List<int> list = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(Int32.Parse(new String(arr[i], 1)));
                Console.WriteLine(list[i]);
            }
            List<int> list1 = new List<int>();
            int number1 = list1.Count;
        }
    }
}
