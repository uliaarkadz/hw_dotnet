using System;
using System.IO;

namespace HW01IMAGE

{
    internal static class Program
    {
        private static void Main(string[] args)

        {
            //reading text file with bytes
            StreamReader textReader = new StreamReader(@"/Users/ulia/Projects/HW.01.Image/HW.01.Image/image.txt", true);

            //save file reading result into string
            string textReaderResult = textReader.ReadToEnd();

            //split string into array
            string[] arrayOfTextResult = textReaderResult.Split(' ');

            //declare bytes array
            byte [] imageBytes = new Byte[arrayOfTextResult.Length - 1];

            //loops through text array to convert it into binary code
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;

            }

            //save binary code into image file
            File.WriteAllBytes(@"/Users/ulia/Projects/HW.01.Image/HW.01.Image/image/image.png", imageBytes);

            //close streamreader
            textReader.Dispose();




        }
    }
}