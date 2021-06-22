using System;

namespace HW._05.QuadraticFormula
{
    static class Program
    {
        static void Main(string[] args)
        {
            double a = 0,b = 0,c = 0;
            double d, x1, x2;
            
            Console.Write(value: "Calculate root of Quadratic Equation :\n");
            Console.Write(value: "----------------------------------------\n");

            Console.Write("Input the value of a : ");
            InputNumbers(a);
            Console.Write("Input the value of b : ");
            InputNumbers(b);
            Console.Write("Input the value of c : ");
            InputNumbers(c);

            // Calculating a discriminant
            d = b * b - 4 * a * c;

            if (d == 0) {
                x1 = -b / (2 * a);
                Console.WriteLine(format: "The only solution is x={0}.", arg0: x1);
                Console.ReadLine();
            }

            // If d < 0, no real solutions exist
            else if (d < 0) { 
                Console.WriteLine(value: "There are no real solutions");
                Console.ReadLine();
            }

            // If d > 0, there are two real solutions 
            else {
                x1 = (-b - Math.Sqrt(d: d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d: d)) / (2 * a);
                Console.WriteLine(format: "x1={0} and x2={1}.", arg0: x1, arg1: x2);
                Console.ReadLine();
            }
        }

        private static double InputNumbers(double number)
        {
           number = Convert.ToDouble(Console.ReadLine());
           return InputNumbers(number);
        }
    }
}
    
