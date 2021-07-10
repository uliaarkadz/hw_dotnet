using System;
using System.Linq;
using System.Text;

namespace HW._05.ARRAYS.CODEWARS
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();
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

        public static void Task2()
        {
            /*Дана символьная строка, содержащая хотя бы один символ '?'.
             Удалить все символы '!' или '.', расположенные до первого символа '?' и 
             заменить все пробелы, расположенные за первым символом '?', на символ подчёркивания '_'.*/
            
            string myString = "1a!2.3!!.. 4.!.?6 7! ?..?";
            
            StringBuilder sb = new StringBuilder(myString);
            
            int index;
            int pos;
            
            for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == '!')
                    {
                        index = i;
                        sb.Remove(i,1);
                    }else if(sb[i] == '?')
                        break;
                    }
            for (int i = 0; i < sb.Length; i++)
            { 
                if (sb[i] == '?')
                {
                    pos = i;
                    for (int j = i; j < sb.Length; j++)
                        {
                            if (sb[j] == ' ')
                            {
                                sb.Replace(' ', '_',j,1);
                            }
                        }
                }
            }
            Console.WriteLine("My string is: " + sb);
        }

        public static void Task3()
        
        {

            String[] a1 = {"tarp", "mice", "bull"};
            String[] a2 = {"lively", "alive", "harp", "sharp", "armstrong"};

            String[] newArray = new string[] { };

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a2[j].Contains(a1[i]))
                    { 
                        Array.Resize(ref newArray, newArray.Length+1);
                        newArray[newArray.Length - 1] = a1[i];
                    }
                }
            }
            
            string[]  dist = newArray.Distinct().ToArray();
           
            Console.WriteLine("My string similar items is: " + string.Join(",", dist));
            
        }
    }
}