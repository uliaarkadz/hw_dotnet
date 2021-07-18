using System;

namespace HW._07.TASK3.Utility
{
    public class ComputerPrograms : MediaFile
    {
        public MediaFile mediaFile { get; set; }

        public ComputerPrograms(string name, Guid code, string category, double size) : base(name, code, category, size)
        {
            
        }
    }
}