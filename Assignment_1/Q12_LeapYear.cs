using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q12_LeapYear
    {
        private int number { get; set; }

        public void SetNumber(int year)
        {
            if (year > 0)
            {
                number = year;
            }
        }

        public void CheckLeapYear()
        {
            Console.WriteLine("Please enter a year to check if it's a leap year: ");
            int input = int.Parse(Console.ReadLine());

            SetNumber(input);

            if (isLeap(number) == true)
            {
                Console.WriteLine($"The year {number} is a Leap Year :)");
            }
            else
                Console.WriteLine($"The year {number} is NOT a Leap Year :(");
        }
        
        public bool isLeap(int num)
        {
            if (num % 4 == 0)
            {
                return true;

            }
            else if (num % 100 == 0)
            {
                if (num % 400 == 0)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                 return false;
            }

        }
    }
}
