using System;
using HW08.ITDEPARTMENT.Employees;

namespace HW08.ITDEPARTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            JuniorDeveloper juniorDeveloper = new JuniorDeveloper(new Guid(), "John", "Doe", 2, "","", 0, 1);
Console.WriteLine(juniorDeveloper);
        }
    }
}