using System;

namespace HW._07.TASK02
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment(50);
            Person person = new Person("Jhon");
            apartment.door = new Door("black");
            person.house = apartment;
            person.ShowData();
        }
    }
}