using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinTest
{
    class JoinTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeLine(0, 5, ","));
            Console.WriteLine(MakeLine(1, 6, " "));
            Console.WriteLine(MakeLine(9, 9, ":"));
            Console.WriteLine(MakeLine(4, 7, "< "));

            byte[] values = { Byte.MinValue, 12, 100, 179, Byte.MaxValue };

            foreach (var value in values)
            {
                Console.WriteLine("{0,3} ({1}) --> {2}", value,
                                  value.GetType().Name,
                                  Convert.ToString(value));
            }

            Console.ReadKey();
        }

        private static string MakeLine(int initVal, int multVal, string sep)
        {
            string[] sArr = new string[10];

            for (int i = initVal; i < initVal + 10; i++)
                sArr[i - initVal] = String.Format("{0,-3}", i * multVal);

            return String.Join(sep, sArr);
        }
    }
}
