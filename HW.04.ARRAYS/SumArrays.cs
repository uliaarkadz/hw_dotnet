using System;

namespace HW._04.ARRAYS
{
    public class SumArrays
    {
        public void SumOfTwoArrays()
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
                Console.Write("\n Enter number \n");

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