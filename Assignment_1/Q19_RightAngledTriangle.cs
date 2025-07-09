using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q19_RightAngledTriangle
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

        public void Triangle()
        {
            Console.Write("Please enter the number of rows: ");
            int input = int.Parse(Console.ReadLine());

            setNumber(input);

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
