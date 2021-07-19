using System;

namespace HW._06.TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = null;
            string model = null;
            int miles = 0;
            int power = 0;
            int vol = 0;
            string type = null;
            Guid vinnumber = default;
            
            
            Motorcycle motorcycle = new Motorcycle();
            
            motorcycle.GetYear();
            Console.WriteLine("Enter motorcycle make:");
            make = Console.ReadLine();
            motorcycle.GetMake(make);
            Console.WriteLine("Enter motorcycle model:");
            model = Console.ReadLine();
            motorcycle.GetModel(model);
            Console.WriteLine("Enter motorcycle odometer:");
            miles = Int32.Parse(Console.ReadLine());
            motorcycle.GetOdometer(miles);
            motorcycle.GetVinNumber(vinnumber);
            Motorcycle.Engine engine = new Motorcycle.Engine();
            Console.WriteLine("Enter motorcycle power:");
            power = Int32.Parse(Console.ReadLine());
            engine.GetPower(power);
            Console.WriteLine("Enter motorcycle volume:");
            vol = Int32.Parse(Console.ReadLine());
            engine.GetVolume(vol);
            Console.WriteLine("Enter motorcycle engine type:");
            type = Console.ReadLine();
            engine.GetEngineType(type);
            Console.WriteLine("Motorcycle is created with parameters: \n make: {0}\n model: {1}\n odometer: {2}\n vinnumber: {3}\n power level: {4}\n engine capacity: {5}\n engine type: {6}", make, model, miles, vinnumber, power, vol, type );
        }
    }
}