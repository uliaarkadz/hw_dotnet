using System;
using System.Reflection.Emit;

namespace HW08.ITDEPARTMENT.Employees
{
    public class TeamLeader : Engineer
    {
        public TeamLeader(Guid id, string firstName, string lastName, double experience, string responsibilities, string technologies, string gitHub, double salary, double bonus, double multiplier) : base(id, firstName, lastName, experience, technologies, gitHub, bonus, multiplier)
        {
        }
        
        private Engineer _engineer;
        public Engineer Engineer { get; set; }
        
        public void GetResponsibilities()
        {
            Engineer.DevelopingSystems();
            Engineer.EnglishKnowledge();
            Engineer.WriteCode();
            Engineer.FarameworksKnoledge();
            Engineer.DebuggingCode();
        }
        public void Salary()
        {
            Engineer.GetSalary();
        }
    }
}