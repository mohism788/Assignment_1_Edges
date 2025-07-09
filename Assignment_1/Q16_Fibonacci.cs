using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q16_Fibonacci
    {

        public int number { get; set; }

        List<int> FibonacciList = new List<int>();
        public void setNumber(int num)
        {
            if (num > 0)
            {
                number = num;
            }
            else Console.WriteLine("Please enter a number bigger than 0");
        }



        public void Fibonacci()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Please enter the number of terms for Fibonacci: ");
            int input = int.Parse(Console.ReadLine());

            setNumber(input);
            int nextFib = 1;

            FibonacciList.Add(0);
            for (int i = 0; i < number-1 ; i++)
            {
                FibonacciList.Add(nextFib);
                nextFib = nextFib + FibonacciList[i];
                


            }

            Console.WriteLine($"Fibonacci's List with {number} terms is: ");
            foreach (var item in FibonacciList)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            FibonacciList.Clear();
            Console.Write("\n======================================================================\n");

        }

    }
}
