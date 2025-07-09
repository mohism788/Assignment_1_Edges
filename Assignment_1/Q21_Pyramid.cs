using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q21_Pyramid
    {
        private int number { get; set; }

        public void setNumber(int num)
        {
            if (num > 0)
            {
                number = num;
            }
            else
                Console.WriteLine("Number must be postive");
        }

        public void Pyramid()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Please enter the number of rows: ");
            int input = int.Parse(Console.ReadLine());

            setNumber(input);

            for (int i = 0; i < number; i++)
            {
                for (int j = number-1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int u = 0; u < i; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n======================================================================\n");
        }
    }
}
