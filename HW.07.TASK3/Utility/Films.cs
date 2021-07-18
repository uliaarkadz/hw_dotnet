using System;

namespace HW._07.TASK3.Utility
{
    public class Films : MediaFile
    {
        private string director;
        private string mainActor;
        private string mainActress;
        public Films(string director, string mainActor, string mainActress,  string name, Guid code, string category, double size) :base(name, code, category, size)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }
        public MediaFile MediaFile { get; set; }
        
    }
}