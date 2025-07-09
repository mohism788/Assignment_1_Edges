using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q13_FindMaximum
    {
        private int x { get; set; }
        private int y { get; set; }
        private int z { get; set; }


        public void setNumber(int a, int b, int c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                x = a; y = b; z = c;
            }
            else
                Console.WriteLine("All numbers must be positive or zeros");


        }


        public void CheckMaximum()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Please enter first number: ");
            int input_1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int input_2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter third number: ");
            int input_3 = int.Parse(Console.ReadLine());

            setNumber(input_1, input_2, input_3);
            int max = x;

            if (y > x && y > z)
            {
                max = y;
            }
            else if (z > x && z > y)
            {
                max = z;
            }

            Console.WriteLine($"Maximum number is {max}\n");
            Console.Write("\n======================================================================\n");


        }

    }
}
