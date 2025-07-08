using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q10_StrongNumber
    {
        private int number { get; set; }

        public void SetNumber(int number)
        {
            if (number > 0)
                this.number = number;
            else Console.WriteLine("The number must be bigger than 0");
        }

        List<int> separates = new List<int>();
        int sum = 0;
        public void SeparateAndSumFactorials()
        {
            Console.Write("\t\t\tThis program helps separating the digits of a number and sum these digits' factorial to eachother" +
                "\n\t\t\tlike 1234 >> 1!+2!+3!+4!=33" +
                "\n\nPlease enter a number: ");
            int input = int.Parse(Console.ReadLine());
            SetNumber(input);
            int clone = number;
            while (clone != 0)
            {

                separates.Add(clone % 10);
                clone /= 10;
            }

            foreach (int item in separates)
            {
               // int numberDash = factorial(number);
               Console.WriteLine(factorial(item));
                sum = sum + factorial(item);
            }

            if (sum == number) Console.WriteLine($"{number} is a strong number :)");
            else Console.WriteLine($"{number} is not a strong number :(");
        }


        private int factorial(int numberFactorial)
        {
           

            if (numberFactorial > 0)
            {
                for (int i = numberFactorial; i > 1; i--)
                {

                    numberFactorial *= i - 1;


                }
               
            }
            else 
                numberFactorial = 1;


                return numberFactorial;

        }
    }
}
