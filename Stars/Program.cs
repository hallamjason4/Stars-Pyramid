using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < n-i; j++)
                    Console.Write(" ");
                for (int k = 0; k < 2*i-1; k++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
