using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Grid(string[] args)
        {
            int count2 = 0;
            string row = "";

            for (int i = 1; i <= 8; i++)
            {
                if (i % 2 != 0)
                {
                    count2 = 1;
                }
                else
                {
                    count2 = 2;
                }
                for (int j = 0; j < 8; j++)
                {
                    if (count2 == 1)
                    {
                        row += "x";
                        count2 = 2;
                    }
                    else if (count2 == 2)
                    {
                        row += "o";
                        count2 = 1;
                    }
                }
                Console.WriteLine(row);
                row = "";
            }
            Console.WriteLine("Press Enter to Terminate");
            string input = Console.ReadLine();
        }
    }
}
