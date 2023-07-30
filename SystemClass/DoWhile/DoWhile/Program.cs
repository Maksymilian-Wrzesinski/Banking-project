using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 9;
            do
            {
                Console.WriteLine(j);
                j--;

            }
            while (j >= 0);
            Console.ReadKey();
        }
    }
}
