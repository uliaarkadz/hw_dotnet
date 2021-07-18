using System;

namespace HW08.ITDEPARTMENT.Employees
{
    public class JuniorDeveloper : Engineer
    {
      
        public JuniorDeveloper(Guid id, string firstName, string lastName, double experience, string technologies, string gitHub, double bonus, double multiplier) : base(id, firstName, lastName, experience, technologies, gitHub, bonus, multiplier)
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