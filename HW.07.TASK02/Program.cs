using System;

namespace HW._07.TASK02
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment(50);
            Person person = new Person("Jhon");
            person.house = apartment;
            apartment.
           
            person.ShowData();
        }
    }
}