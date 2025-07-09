using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q15_NumberPalindrome
    {
        private int number { get; set; }
        List<int> elements = new List<int>();

        public void SetNumber(int num)
        {
            if (num>0) number = num;
        }
        
      

        public void numberPalindrome()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Enter a number to check if it is a Palindrome: ");
            int input = int.Parse(Console.ReadLine());
            SetNumber(input);
            ElementInList();

            if (isPalindrome(number) == true)
            {
                
                Console.WriteLine("Number is a Palindrome :)");
                
                
            }
            else Console.WriteLine("Number is NOT a Palindrome :(");

            elements.Clear();
            Console.Write("\n======================================================================\n");
        }

        public void ElementInList()
        {
            while (number != 0)
            {

                elements.Add(number % 10);
                number /= 10;

            }
        }
         bool isPalindrome(int checkedNumber)
        {
          
            int left = 0;
            int right = elements.Count - 1;


            while (left < right)
            {
                if (elements[left] != elements[right])
                {
                    return false;
                }
                left++;
                right--;

            }
            return true;


        }
    }
}

