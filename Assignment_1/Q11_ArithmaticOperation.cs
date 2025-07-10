using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Q11_ArithmaticOperation
    {
        private decimal number_1 { get; set; }
        private decimal number_2 { get; set; }
        private char operation { get; set; }
        
        
        public void SetNumbers(decimal num_1, decimal num_2)
        {
            number_1 = num_1;
            number_2 = num_2;
        }

        public void setOperation(char op)
        {
            switch (op)
            {
                
                case '+':
                    operation = op;
                    break;
                case '-':
                    operation = op;
                    break;
                case '*':
                    operation = op;
                    break;
                case '/':
                    operation = op;
                    break;
                default:
                    Console.WriteLine("Please enter a valid operator!");
                    break;

            }
        }


        public void Operation ()
        {
            decimal result;
            Console.Write("\n======================================================================\n");
            Console.Write("Please enter first side number of the operation: ");
            decimal input_1 = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter Operator (+,-,/,*): ");
            char operation = Console.ReadKey().KeyChar;
            

            Console.Write("\nPlease enter second side number of the operation: ");
            decimal input_2 = decimal.Parse(Console.ReadLine());

            SetNumbers(input_1, input_2);
            setOperation(operation);
            switch(operation)
            {

                case '+': 
                    result = number_1 + number_2;
                    Console.WriteLine($"{number_1} + {number_2} = {result}");
                    Console.Write("\n======================================================================\n");
                    break;
                case '-':
                    result = number_1 - number_2;
                    Console.WriteLine($"{number_1} - {number_2} = {result}");
                    Console.Write("\n======================================================================\n");
                    break;
                case'*':
                    result = number_1 * number_2;
                    Console.WriteLine($"{number_1} * {number_2} = {result}");
                    Console.Write("\n======================================================================\n");
                    break;
                case '/':
                    result = number_1 / number_2;
                    Console.WriteLine($"{number_1} / {number_2} = {result}");
                    Console.Write("\n======================================================================\n");
                    break;
                default:
                    Console.WriteLine("Please try again!");
                    Console.Write("\n======================================================================\n");
                    break;

            }

        }
    }
}
