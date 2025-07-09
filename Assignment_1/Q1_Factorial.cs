using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q1_Factorial
    {

        private int number { get; set; }

        public void setNumber(int num)
        {
            if (number >= 0)
                number = num;

            else throw new Exception("Can't work with negative number :(");
        }
        public void factorial()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Please enter the number to get it's factorial: ");
            int input = int.Parse(Console.ReadLine());
            setNumber(input);

            if (number >= 0)
            {
                for (int i = number; i > 1; i--)
                {

                    input *= i - 1;


                }
                Console.WriteLine($"Thank you! Your result is {input} ");
                Console.Write("\n======================================================================\n");
            }
            else Console.WriteLine("Sorry, can't work with negative numbers :(");
            Console.Write("\n======================================================================\n");


        }

    }
}
