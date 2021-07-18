using System;

namespace HW._07.TASK02
{
    public class Person
    {
        protected string name;
        public House house { get; set; }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"My name is {name}.");
            house.ShowData();
            house.GetDoor();
        }
        
    }
}