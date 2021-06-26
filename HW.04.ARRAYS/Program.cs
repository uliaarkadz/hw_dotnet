using System;
using System.Diagnostics;
using System.Linq;

namespace HW._04.ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            
           // SumOfTwoArrays();
           //InsertNewArrayElemet();
          
           sw.Start();
            ReverseArray();
            //ReverseArrayWithReverse();
           sw.Stop();
           Console.Write("\nRunTime 1 \n" + sw.Elapsed+"\n");
           
           sw.Start();
           ReverseArray();
           ReverseArrayWithReverse();
          sw.Stop();
         Console.Write("\nRunTime 2 \n" + sw.Elapsed +"\n");
           

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
          //  Console.WriteLine("Random numbers array: " + string.Join(",", array));

            j = i - 1;
            for (i = 0; i < j; i++)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                j--;
            }
          //  Console.WriteLine("Reversed array: " + string.Join(",", array));
        }

        public static void ReverseArrayWithReverse()
        {
            Random randNum = new Random();
            int[] array = new int[1_000_000];
            int i;

            for ( i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next();
            }
           // Console.WriteLine("Random numbers array: " + string.Join(",", array));
            
            //Array.Reverse(array);
            
           // Console.WriteLine("Random numbers array: " + string.Join(",", array));
            
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