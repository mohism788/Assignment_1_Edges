using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q14_VowelConsonant
    {

        private char letter { get; set; }

        public void setChar(char ch)
        {
            if (char.IsLetter(ch))
            {
                letter = ch;
            }
            else
                Console.WriteLine("What you have entered is not a character");
        }


        public void CheckVowel()
        {
            Console.Write("\n======================================================================\n");
            Console.Write("Please insert a letter to check: ");
            char input = Console.ReadKey().KeyChar;
            setChar(input);
            
            char chLower = char.ToLower(letter);

            if (chLower == 'a' || chLower == 'o' || chLower == 'u' || chLower == 'e' || chLower == 'i')
            {
                Console.WriteLine($"\n{letter} is a Vowel :)\n");
            }
            else
                Console.WriteLine($"\n{letter} is a Consonant :)\n");

            Console.Write("\n======================================================================\n");

        }
    }
}
