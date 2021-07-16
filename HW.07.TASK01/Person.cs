using System;

namespace HW._07.TASK01
{
    public class Person
    {
        protected internal int SetAge(int n)
        {
            Console.WriteLine($"My age is {n}");
            return n;
        }

        protected internal void Greet()
        {
            Console.WriteLine("Hello World!");
        }
    }
}