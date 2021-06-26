using System;

namespace HW03.Calculator
{
    public class Calculator
    {
        public double AddNumbers(double a, double b)
        {
            return a+b;
        }
        public double SubstractNumbers(double a, double b)
        {
            return a-b;
        }
        
        public double MultiplyNumbers(double a, double b)
        {
            return a*b;
        }
        
        public double DivideNumbers(double a, double b)
        {
            return a/b;
        }
        
        public double Reminder(double a, double b)
        {
            return a%b;
        }
        
        public double CircleArea(double pi, double radius)
        {
             pi = Math.PI;
            return pi*radius*radius;
        }
    }
}