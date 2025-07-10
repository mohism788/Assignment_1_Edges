using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1
{
    public class Q5_PerfectNumber
    {
        private int number { get; set; }

        public void SetNumber(int Number)
        {
            if (Number > 0)
            {
                number = Number;
            }
            else
                Console.WriteLine("Number must be positive integer");
        }

        public void PerfectNumberChecker()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Please enter the number to check for a Perfect number: ");
            int input = int.Parse(Console.ReadLine());
            SetNumber(input);
            List<int> Divisors= new List<int>();
    
      int sumDiv = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    Divisors.Add(i);
            }

            foreach (var item in Divisors)
            {
                sumDiv += item;
            }

            if (sumDiv == number)
                Console.WriteLine($"{number} is a perfect number! :)");

            else
                Console.WriteLine($"{number} is NOT a perfect number! :(");

            Console.Write("\n======================================================================\n");

        }

    }
}
