using System;

namespace HW._07.TASK01
{
    public class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPERSON:\n");
            Person person = new Person();
            person.Greet();
            Console.WriteLine("\nSTUDENT:\n");
            Student student = new Student();
            student.ShowAge(age: 21);
            student.Greet();
            Console.WriteLine("\nTEACHER:\n");
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Explain();

        }
        
    }
}