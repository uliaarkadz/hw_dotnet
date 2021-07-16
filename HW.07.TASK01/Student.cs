using System;
using System.Reflection.Metadata;

namespace HW._07.TASK01
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class");
        }
        
        public void  ShowAge(int age)
        {
            SetAge(age);
        }
    }
}