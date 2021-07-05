using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW._04.ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            
        /*    SumOfTwoArrays();
            
            InsertNewArrayElemet();
          
          Stopwatch sw = new Stopwatch();
          sw.Start();
          ReverseArray();
          ReverseArrayWithReverse(); 
          sw.Stop();
          Console.Write("\nRunTime 1 \n" + sw.Elapsed+"\n");
          sw.Start();
          ReverseArray();
          ReverseArrayWithReverse();
          sw.Stop();
          Console.Write("\nRunTime 2 \n" + sw.Elapsed +"\n");

           InputSeparate();*/
         
         string phrase = "Lorem ipsum dolor sit amet, consectetuyututututu adipiscing elit," +
                  " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim " +
                  "ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex" +
                  " ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit " +
                  "esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non" +
                  " proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
         
         string [] myArray = ArraySorting(phrase);
         
         DeleteMaxValue(myArray);
         
         SwapMaxMinValues(myArray);
         
         CountLettersSpecialChar(phrase);
         
         SortArray(myArray);
         
        }

        private static string [] ArraySorting(string phrase)
        {
            string[] array = phrase.Split(' ');
            
            Console.WriteLine("\nMy array is:  \n" + string.Join(",", array));
            
            return array;
            
        }

        public static void DeleteMaxValue(string [] array)
        {
            
            string max = FindMaxValue(array);
            int index =  Array.IndexOf(array, max);
            array = array.Where(w => w != array[index]).ToArray();
            
            Console.WriteLine("\nArray with deleted max string: \n" + string.Join(",", array));
            
        }

        public static void SwapMaxMinValues( string [] array)
        {  
            
            int max = Array.IndexOf(array,FindMaxValue(array));
            int min = Array.IndexOf(array,FindMinValue(array));
            string temp = array[min];
            
            array[min] = array[max];
            array[max] = temp;
            
            Console.WriteLine("\nArray with swapped max and min values: \n" + string.Join(",", array));
            
        }
        public static string FindMaxValue(string [] array)
        {
            
            int max = 0;
            string maxValue = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxValue.Length)
                    max = i;
                maxValue = array[max];
            }
            
            return maxValue;
        }
        
        public static string FindMinValue(string [] array)
        {
            
            int min = 0;
            string minValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < minValue.Length)
                    min = i;
                minValue = array[min];
            }

            return minValue;
        }

        public static void CountLettersSpecialChar(string phrase)
        {
            
            int count = 0;
            int countLetters = Regex.Matches(phrase, "[a-z, A-Z]").Count;

            foreach (char c in phrase)
            {
                if (!char.IsLetterOrDigit(c.ToString(), 0))
                {
                    count++;
                }
            }

            Console.WriteLine("\nSpecial characters count: \n" + count);
            Console.WriteLine("\nLetters count: \n" + countLetters);
            
        }

        public static void SortArray(string [] array)
            {
                
                array = array.OrderBy(aux => aux.Length).ToArray();
                Array.Reverse(array);
                Console.WriteLine("\nArray sorted descending: \n" + string.Join(",", array));
                
            }

        private static void InputSeparate()
        {
            
            string text;
            string temp;
            text = Console.ReadLine();
            if (text != null)
            {
                string[] splitinput = text.Split(';');
            
                Console.WriteLine("Reversed array: " + string.Join(",", splitinput));

                for (int i = 0; i < splitinput.Length; i++)
                {
                    temp = splitinput[i];
                    if (temp.ToLower().Contains('o'))
                    {
                        temp = temp.Replace('o','a');
                        splitinput[i] = temp;
                    }
                }
                Console.WriteLine("Reversed array: " + string.Join(",", splitinput));
            }
            
        }

        private static void ReverseArray()
        { 
            
            Random randNum = new Random();
            int[] array = new int[1_000_000];
            int i, j, temp;

            for ( i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next();
            }

            j = i - 1;
            for (i = 0; i < j; i++)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                j--;
            }
            Console.WriteLine("Reversed array: " + string.Join(",", array));
            
        }

        public static void ReverseArrayWithReverse()
        {
            
            Random randNum = new Random();
            int[] array = new int[1_000_000];
            Array.Reverse(array);
           
        }

        private static void InsertNewArrayElemet()
        {
            
            int size = 4;
            int[] array = new int[size];
            int element;
            int index;
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\n Enter number for index: {i} \n");
                array[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            }

            Console.Write("\n Enter element value: \n");
            element = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("\n Enter element position: \n");
            index = int.Parse(Console.ReadLine() ?? string.Empty);

            int[] newarr = new int[size + 1];

            for (int i = 0; i < size + 1; i++)
            {
                if (i < index - 1)
                    newarr[i] = array[i];
                else if (i == index - 1)
                    newarr[i] = element;
                else
                    newarr[i] = array[i - 1];
            }

            Console.WriteLine("Array elements after insertion : ");
            for (int i = 0; i < size + 1; i++)
                Console.Write(newarr[i] + " ");
            
        }

        private static void SumOfTwoArrays()
        {
            
            Random randNum = new Random();
            int size = 10;
            int[] random = new int[size];
            int[] input = new int[size];
            int[] sum = new int[size];

            for (int i = 0; i < random.Length; i++)
            {
                random[i] = randNum.Next(0, 9);
            }
            
            for (int i = 0; i < size; i++)
            {
                Console.Write($"\n Enter number for index: {i} \n");
                input[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = random[i] + input[i];
            }

            Console.WriteLine("Random numbers array: " + string.Join(",", input));
            Console.WriteLine("Console input numbers array: " + string.Join(",", random));
            Console.WriteLine("Sum of two arrays: " + string.Join(",", sum));
            
        }
    }
}