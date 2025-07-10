using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Menu
    {
        private int choice { get; set; }

        Q1_Factorial Q1 = new Q1_Factorial();   
        Q2_Reverse Q2 = new Q2_Reverse();
        Q3_Armstrong Q3 = new Q3_Armstrong();
        Q4_PrimeNumber Q4 = new Q4_PrimeNumber();
        Q5_PerfectNumber Q5 = new Q5_PerfectNumber();
        Q7_Palindrome Q7 = new Q7_Palindrome();
        Q8_SeparateSum Q8 = new Q8_SeparateSum();
        Q10_StrongNumber Q10 = new Q10_StrongNumber();
        Q11_ArithmaticOperation Q11 = new Q11_ArithmaticOperation();
        Q12_LeapYear Q12 = new Q12_LeapYear();
        Q13_FindMaximum Q13 = new Q13_FindMaximum();
        Q14_VowelConsonant Q14 = new Q14_VowelConsonant();  
        Q15_NumberPalindrome Q15 = new Q15_NumberPalindrome();  
        Q16_Fibonacci Q16 = new Q16_Fibonacci();    
        Q19_RightAngledTriangle Q19 = new Q19_RightAngledTriangle();
        Q20_InvertedRightAngledTriangle Q20 = new Q20_InvertedRightAngledTriangle();
        Q21_Pyramid Q21 = new Q21_Pyramid();
        public void setChoice(int _choice)
        {
            if (_choice > 0 && choice < 22)
            {
                choice = _choice;
            }
            else
                Console.WriteLine("No available questions with that number, please try again!");
        }

        public void menu()
        {
            Console.WriteLine("Welcome to the assignment #1 project");
            Console.WriteLine("------------------------------------\n\n");
            
           

            while (true)
            {
                Console.Write("     Available questions are from 1 to 21" +
                    "\n>>> Please enter the number of the Question you want to test: ");
                int input = int.Parse(Console.ReadLine());
                setChoice(input);
                switch (choice)
                {
                    case 1:
                            Q1.factorial();
                        break;
                    case 2:
                            Q2.Reverse();
                        break;

                    case 3:
                            Q3.Armstrong();
                        break;
                    case 4:
                            Q4.PrimeFinder();
                        break;
                    case 5:
                            Q5.PerfectNumberChecker();
                        break;
                    case 7:
                            Q7.Palindrome();
                        break;
                    case 8:
                            Q8.SeparateAndSum();
                        break;
                    case 10:
                            Q10.SeparateAndSumFactorials();
                        break;
                    case 11:
                            Q11.Operation();
                        break;
                    case 12:
                            Q12.CheckLeapYear();
                        break;
                    case 13:
                            Q13.CheckMaximum();
                        break;
                    case 14:
                        while (true)
                            Q14.CheckVowel();
                        break;
                    case 15:
                            Q15.numberPalindrome();
                        break;
                    case 16:
                            Q16.Fibonacci();
                        break;
                    case 19:
                            Q19.Triangle();
                        break;
                    case 20:
                            Q20.InvertedTriangle();
                        break;
                    case 21:
                            Q21.Pyramid();
                        break;
                    default:
                        Console.WriteLine("This question is not available, try another one please!");
                        Console.Write("\n======================================================================\n");
                        choice = 0;
                        break;
                    
                }

            }
        }
    }
}
