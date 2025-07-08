using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1
{
    public class Q4_PrimeNumber
    {
        private int range_1 { get; set; }
        private int range_2 { get; set; }

        public void SetRange(int Range_1, int Range_2)
        {
            if (Range_1 > 1)
                range_1 = Range_1;
            else
                throw new Exception("Range must start with a number bigger than 1");

            if (Range_2 > Range_1)
                range_2 = Range_2;
            else
                throw new Exception("Range limit must be bigger than the starting range!");
        }

        public void PrimeFinder()
        {
            Console.Write("Please enter range 1: ");
            int input_1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter range 2: ");
            int input_2 = int.Parse(Console.ReadLine());

            SetRange(input_1, input_2);
            List<int> primes = new List<int>();

            for (int current = range_1; current <= range_2; current++)
            {
                if (IsPrime(current))
                {
                    primes.Add(current);
                }
            }

            if (primes.Any())
            {
                foreach (var prime in primes)
                {
                    Console.WriteLine($"{prime} is a prime number");
                }
            }
            else
            {
                throw new Exception("This Range has no prime numbers");
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}