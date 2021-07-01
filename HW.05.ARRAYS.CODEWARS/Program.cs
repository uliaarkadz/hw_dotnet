using System;
using System.Threading.Tasks;

namespace HW._05.ARRAYS.CODEWARS
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        public static void Task1()

        {
            string str1 = "gdfgdf234dg54gf*23oP42";
            char[] textChar = str1.ToCharArray();
            string str2 = string.Empty;
            int number1 = 0;
            int number2 = 0;
            char sep = '\0';
            int result = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                if (!Char.IsLetterOrDigit(str1[i]))
                    sep = str1[i];
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (!Char.IsLetter(str1[i]))
                    str2 += str1[i];
            }

            string[] array = str2.Split(sep);
            number1 = Convert.ToInt32(array[0]);
            number2 = Convert.ToInt32(array[1]);

            switch (sep)
            {
                case '+':
                    result = number2 + number1;
                    break;
                case '-':
                    result = number2 - number1;
                    break;
                case '*':
                    result = number2 * number1;
                    break;
                case '/':
                    result = number2 / number1;
                    break;
                default:
                    Console.WriteLine("No action for that operator");
                    break;
            }

            Console.WriteLine($"Result is : {result}");
        }
    }
}