using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q7_Palindrome
    {
        private string word { get; set; }

        public void SetWord(string word)
        {
            if (word != null) this.word = word;
        }

        public void Palindrome()
        {
            Console.WriteLine("Enter a word to check if it is a Palindrome: ");
            string input = Console.ReadLine();



            if (isPalindrome(input) == true)
            {
                Console.WriteLine("Word is a Palindrome :)");
            }
            else Console.WriteLine("Word is NOT a Palindrome :(");
        }
        static bool isPalindrome(string checkedWord)
        {
            string cleaned = "";
            foreach (char c in checkedWord)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleaned += char.ToLower(c);
                }
            }
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
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
