using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q8_SeparateSum
    {
        private int number { get; set; }

        public void SetNumber(int num)
        {   if (number > 0)
                number = num;
            else Console.WriteLine("The number must be bigger than 0");
        }

        List<int> separates = new List<int>();
        int sum = 0;    
        public void SeparateAndSum()
        {
            Console.Write("\t\t\tThis program helps separating the digits of a number and sum these digits to eachother" +
                "\n\t\t\tlike 1234 >> 1+2+3+4=10" +
                "\n\nPlease enter a number: ");
            int input = int.Parse(Console.ReadLine());
            SetNumber(input);
            while (number != 0)
            {
                
                separates.Add(number % 10);
                number /= 10;
            }

            foreach (int number in separates)
            {
                sum+= number;
            }

            Console.WriteLine($"The Sum of the separate is {sum}");

        }


    }
}
