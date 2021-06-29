using System;

namespace HW._05.QuadraticFormula
{
    static class Program
    {
        static void Main(string[] args)
        {
            int a ,b,c;
            double d, x1, x2;
            
            Console.Write(value: "Calculate root of Quadratic Equation :\n");
            Console.Write(value: "----------------------------------------\n");

            Console.Write("Input the value of a : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Input the value of b : ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Input the value of c : ");
            c = Int32.Parse(Console.ReadLine());

            // Calculating a discriminant
            d = b * b - 4 * a * c;

            if (d == 0) {
                x1 = -b / (a * 2);
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
    }
}
    
