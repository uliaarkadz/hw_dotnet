using System;
using HW._07.TASK3.Utility;

namespace HW._07.TASK3
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaFile[] media = new MediaFile[3];
            media[0] = new Films("Spike Lee", "Brad Pitt", "Jeniffer Anniston", "Best Movie", new Guid(),"comedy",236);
            media[1] = new ComputerPrograms("Game", new Guid(),"adults",555);
            media[2] = new MusicFiles("Lady Gaga", 340, "", new Guid(), "", 456);
        }
    }
}