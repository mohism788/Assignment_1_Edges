using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q3_Armstrong
    {
        private int number { get; set; }

        public void setNumber(int num)
        {
            if (number > 0)
            {
                number = num;
            }
            else throw new Exception("Number must be positive!");
        }

        public static int Power(int baseNumber, int exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("Negative exponents not supported for integers", nameof(exponent));

            if (exponent == 0)
                return 1;

            int temp = Power(baseNumber, exponent / 2);

            if (exponent % 2 == 0)
            {
                return temp * temp;
            }
            else
            {
                return baseNumber * temp * temp;
            }
        }
        public void Armstrong()
        {
            int counter = 0;
            int sum = 0;


            Console.Write("\n======================================================================\n");
            Console.Write("Please enter a positive number: ");
            int input = int.Parse(Console.ReadLine());
            setNumber(input);

            while (number > 0)
            {
                number = number / 10;
                counter++;
            }
            int[] collect = new int[counter];

            for (int i = 0; i <= counter; i++)
            {
                setNumber(input);
                input = number % 10; // 153%10 = 3
                collect[i] = input;
                sum += Power(collect[i],counter);
            }

            if (sum == number)
            {
                Console.WriteLine($"Yes, {number} is an Armstrong number!");
            }
            else Console.WriteLine($"Sorry, {number} is not an Armstrong number");

            Console.Write("\n======================================================================\n");
        }
    }
}
