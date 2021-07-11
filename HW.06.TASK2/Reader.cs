using System;

namespace HW._06.TASK2
{
    internal class InputReader
    {
        public static void InputReaderNumbers(out int input)
        {
            
            input = Convert.ToInt32(Console.ReadLine());
            int n;
            while (!Int32.TryParse(input.ToString(), out n))
            {
                Console.WriteLine("Input is not a valid number; enter valid number");
                input = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        
      public  static void InputReaderText(out string input)
        {
            
            input = Console.ReadLine();
            int n;
            while (!String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not a valid input; enter valid text");
                input = Console.ReadLine();
            }
            
        }
    }
}