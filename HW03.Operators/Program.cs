using System;
using System.Diagnostics;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            ReadInteger(out int a);
            Console.Write("Enter Operator: ");
            ReadOperator(out char operators);
            Console.Write("Enter Second Number: ");
            ReadInteger(out int b);
            Console.Write("Enter Result of operation: ");
            ReadInteger(out int resultFromInput);
            
            int addresult = 0;
            int subresult = 0;
            
            switch (operators)
            {
                case '+':
                    addresult = AddTwoNumbers(a, b);
                    break;
                case '-':
                    subresult = SubstractTwoNumbers(a, b);
                    break;
                default:
                    Console.Write("No Action");
                    break;
            }

            if ( subresult == 0 )
            {
                while (addresult != resultFromInput ||
                       addresult == resultFromInput)
                {
                    if (addresult == Convert.ToInt32(resultFromInput))
                    {
                        Console.WriteLine("\nCorrect! The sum of two numbers is : {0} \n", addresult);
                        break;
                    }
                    else if (addresult > resultFromInput)
                    {
                        Console.WriteLine("\nThe answer should be greater, try again\n");
                        ReadInteger(out resultFromInput);
                    }
                    else if (addresult < resultFromInput)
                    {
                        Console.WriteLine("\nThe answer should be less, try again\n");
                        ReadInteger(out resultFromInput);
                    }
                }
            }
            else if(addresult == 0)
            {
                while (subresult != resultFromInput ||
                       subresult == resultFromInput)
                {
                    if (subresult == Convert.ToInt32(resultFromInput))
                    {
                        Console.WriteLine("\nCorrect! The sum of two numbers is : {0} \n", subresult);
                        break;
                    }
                    else if (subresult > resultFromInput)
                    {
                        Console.WriteLine("\nThe answer should be greater, try again\n");
                        ReadInteger(out resultFromInput);
                    }
                    else if (subresult < resultFromInput)
                    {
                        Console.WriteLine("\nThe answer should be less, try again\n");
                        ReadInteger(out resultFromInput);
                    }
                }
            }

            static void ReadOperator(out char input)
            {
                
                input = Convert.ToChar(Console.ReadLine());
                char i;
                while (!Char.TryParse(input.ToString(), out i))
                {
                    Console.WriteLine("Input is not a valid operator; enter valid");
                    input = Convert.ToChar(Console.ReadLine());
                }
                
            }

            static void ReadInteger(out int input)
            {
                
                input = Convert.ToInt32(Console.ReadLine());
                int n;
                while (!Int32.TryParse(input.ToString(), out n))
                {
                    Console.WriteLine("Input is not a valid number; enter valid number");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                
            }

            static int AddTwoNumbers(int num1, int num2)
            {
                
                return num1 + num2;
                
            }

            static int SubstractTwoNumbers(int num1, int num2)
            {
                
                return num1 - num2;
                
            }
        }
    }
}