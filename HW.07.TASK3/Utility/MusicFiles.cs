using System;

namespace HW._07.TASK3.Utility
{
    public class MusicFiles : MediaFile
    {
        
        private string singer;
        private int length;

        public MusicFiles(string singer, int length, string name, Guid code, string category, double size) : base(name, code, category,size)
        {
            this.singer = singer;
            this.length = length;
        }
        
        public MediaFile mediaFile { get; set; }
        
    }
}