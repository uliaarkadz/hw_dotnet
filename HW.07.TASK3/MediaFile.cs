using System;

namespace HW._07.TASK3
{
    public class MediaFile
    {
        private string name;
        private Guid code; 
        private string category;
        private double size;

        public MediaFile(string name, Guid code, string category, double size)
        {
            this.name = name;
            this.code = code;
            this.category = category;
            this.size = size;
        }

        public void Play()
        {
        }

        public void RetrieveInformation(){}
        
    }
}