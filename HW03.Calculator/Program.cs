using System;
using HW03.Calculator;

namespace HW03.Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            string firstNum;
            string secondNum;                
            string operation;
            double answer;
            
            
            
            Calculator cal = new Calculator();
            
            Console.Write("Enter the first number");
            ReadInteger(out firstNum);
            Console.Write("Now enter your second number: ");
            ReadInteger(out secondNum);
            Console.Write("Ok now enter your operation ( x , / , +, -, %, CA) ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    answer = cal.AddNumbers(Convert.ToDouble(firstNum),Convert.ToDouble(secondNum));
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                    break;
                case "-":
                    answer = cal.SubstractNumbers(Convert.ToDouble(firstNum),Convert.ToDouble(secondNum));
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                    break;
                case "x":
                    answer = cal.MultiplyNumbers(Convert.ToDouble(firstNum),Convert.ToDouble(secondNum));
                    Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                    break;
                case "/":
                    answer = cal.DivideNumbers(Double.Parse(firstNum),Double.Parse(secondNum));
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                    break;
                case "%":
                    answer = cal.Reminder(Double.Parse(firstNum),Double.Parse(secondNum));
                    Console.WriteLine(firstNum + " % " + secondNum + " = " + answer);
                    break;
                case "CA":
                    answer = cal.CircleArea(Double.Parse(firstNum),Double.Parse(secondNum));
                    Console.WriteLine(firstNum + " CA " + secondNum + " = " + answer);
                    break;
                default:
                    Console.WriteLine("No solution");
                    break;
            }
            
            
            
            
            
            static void ReadInteger(out string input)
            {
                 input = Console.ReadLine();
                 double n;
                 while (!double.TryParse(input, out n))
                 {
                     Console.WriteLine("Input is not a valid number; enter valid number");
                     input = Console.ReadLine();
                 }
            }
        }
    }
    
}
