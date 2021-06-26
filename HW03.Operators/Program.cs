using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            ReadInteger(out string a);
            Console.Write("Enter Second Number: ");
            ReadInteger(out string b);
            Console.Write("Enter Result of addition of two numbers: ");
            ReadInteger(out string resultFromInput);
            int result = AddTwoNumbers(Convert.ToInt32(a),Convert.ToInt32(b));
            
            while (result != Convert.ToInt32(resultFromInput) || result == Convert.ToInt32(resultFromInput))
            {

                if (Convert.ToInt32(resultFromInput) == result)
                {
                    Console.WriteLine("\nCorrect! The sum of two numbers is : {0} \n", result);
                    break;
                }

                
                else if (Convert.ToInt32(resultFromInput) < result)
                {
                    Console.WriteLine("\nThe answer should be greater, try again\n");
                    ReadInteger(out resultFromInput);

                }
                else if (Convert.ToInt32(resultFromInput) > result)
                {
                    Console.WriteLine("\nThe answer should be less, try again\n");
                    ReadInteger(out resultFromInput);
                }
                
            }
        }

        static void ReadInteger(out string input)
        {
            input = Console.ReadLine();
            int n;
            while (!Int32.TryParse(input, out n))
            {
                Console.WriteLine("Input is not a valid number; enter valid number");
                input = Console.ReadLine();
            }
        }

        static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        }
    }
