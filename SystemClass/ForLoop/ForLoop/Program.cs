using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = 1;
            while (w <= 3)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                w++;
            }

            for (int i = 1; i <= 5; i++)
            {
                for(int j = 10; j >= 1; j--)
                {
                    if (i == 4)
                    {
                        if(j == 2 || j== 1)
                            continue;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i++)
            {
                if(i == 8)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.ReadKey();


        }
    }
}
