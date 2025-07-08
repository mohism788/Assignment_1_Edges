using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q2_Reverse
    {

        private int number { get; set; }

        public void setNumber(int numberSet)
        {
            if (numberSet >= 0)
            {
                number = numberSet;
            }
            else
            {
                throw new ArgumentException("Cannot work with negative numbers");
            }
            
        }
        public void Reverse()
        {
            int input ;
            int reversed_number = 0;
            Console.Write("Please enter number to be reversed: ");
            input = int.Parse(Console.ReadLine());

            setNumber(input);
            if (number >= 0)
            {
                while (number != 0)
                {

                    input = number % 10; 
                    reversed_number = (reversed_number * 10) + input;
                    number = number / 10;
                }
                Console.WriteLine($"Thank you! Your result is: {reversed_number}");
            }

            else
            {
                Console.WriteLine("Can't work with negative numbers :(");
            }
            
                
        }
    }
}
