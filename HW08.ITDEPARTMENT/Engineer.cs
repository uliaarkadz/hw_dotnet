using System;

namespace HW08.ITDEPARTMENT
{
    public class Engineer : SalaryCalculator
    {
        private Guid id;
        private string firstName;
        private string lastName;
        private double experience;
        //private string responsibilities;
        private string technologies;
        private string gitHub;

        public Engineer(Guid id, string firstName, string lastName, double experience, string technologies, string gitHub, double bonus, double multiplier) : base( bonus, multiplier)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.experience = experience;
            //this.responsibilities = responsibilities;
            this.technologies = technologies;
            this.gitHub = gitHub;
        }

        public SalaryCalculator SalaryCalculator { get; set; }

        protected internal void GetSalary()
        {
            SalaryCalculator.GetSalary();
        }
        
               protected internal void DevelopingSystems()
                {
                    
                }
                protected internal void FarameworksKnoledge()
                {
                    
                }
                protected internal void DebuggingCode()
                {
                    
                }
                protected internal void DatabaseDesign()
                {
                    
                }
                protected internal void DevelopDocumentation()
                {
                    
                }
                protected internal void WriteCode()
                {
                    
                }
                protected internal void UnitTesting()
                {
                    
                }
                protected internal void RefactorCode()
                {
                    
                }
                protected internal void RequirementsAnalysis()
                {
                    
                }

                protected internal void EnglishKnowledge ()
                {
                }
        
        
        
        
    }
}