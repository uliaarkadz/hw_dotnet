using System;
using System.IO;

namespace HW._01.Image
{
    class Program
    {
        static void Main(string[] args)

        {
            StreamReader textReader = new StreamReader(@"/Users/ulia/Projects/HW.01.Image/HW.01.Image/image.txt", true);

            string textReaderResult = textReader.ReadToEnd();

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            byte[] imageBytes = new Byte[arrayOfTextResult.Length - 1];
           
            
            for(int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;

            }

            File.WriteAllBytes(@"/Users/ulia/Projects/HW.01.Image/HW.01.Image/image/image.png", imageBytes);

            textReader.Dispose();




        }
    }
}
