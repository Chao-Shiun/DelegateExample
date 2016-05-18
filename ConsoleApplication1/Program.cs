using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public delegate bool Predicate(string s);

    class Program
    {
        public delegate bool 判斷偶數(int a);

        public static IEnumerable<int> Query(List<int> list, 判斷偶數 isEven)
        {
            return list.Where(x => isEven(x));
        }

        public bool CheckEven(int x)
        {
            return x % 2 == 0;
        }

        //public delegate bool Predicate(string s);
        private static void Main(string[] args)
        {
            判斷偶數 a = (int xx) =>
            {
                if (xx % 2 == 0)
                    return true;
                else
                    return false;
            };

            List<int> list = new List<int>()
            {
                243,456,86,345,7686,345,3,80
            };

            IEnumerable<int> x = Program.Query(list, a);

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}