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

            int result = AddTwoNumbers(Convert.ToInt32(a),Convert.ToInt32(b));
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", result );
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

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}