using System;
using InputReader;

namespace HW._06.TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            string make;
            InputReader ir = new InputReader();
            Motorcycle motorcycle = new Motorcycle();
            
            motorcycle.GetYear();
            Console.WriteLine("Enter motorcycle make:");
            motorcycle.GetMake(ir.InputReaderText(out make));
            
            motorcycle.GetModel("mototpe");
            motorcycle.GetOdometer(160);
            motorcycle.GetVinNumber(new Guid());
            Motorcycle.Engine engine = new Motorcycle.Engine();
            engine.GetPower(1000);
            engine.GetVolume(75);
            engine.GetEngineType("Gasoline");
        }

        private class InputReader
        {
        }
    }
}