using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
                
            DateTime todayDate = DateTime.Today;
            DateTime userBirthdate = default;
            bool inputValid = false;
            
            Console.Write("Please enter your date of birth (dd/mm/yy):  ");
            
            while (inputValid != true)
            {
                userBirthdate = DateTime.Parse(Console.ReadLine());
                if (userBirthdate > todayDate)
                {
                    Console.Write("Invalid Date.  Please enter your date of birth (mm/dd/yy):  ");
                }
                else
                {
                    Console.WriteLine(userBirthdate);
                    inputValid = true;
                }
            }

            //Calculate user age
            int userAge = todayDate.Year - userBirthdate.Year;
            //month validation
            if (userBirthdate.Month == todayDate.Month)
                userAge++;
            //validate leap year
            if (userBirthdate > todayDate.AddYears(-userAge)) userAge--;
            //Output
            Console.WriteLine("You are {0} years old!", userAge);
        }
    }
}