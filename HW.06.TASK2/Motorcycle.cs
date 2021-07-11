using System;
using static System.DateTime;

namespace HW._06.TASK2
{
    public class Motorcycle
    {

        private DateTime year { get; set; }
        private string make { get; set; }
        private Guid vinNumber { get; set; }
        private string model { get; set; }
        private int odometer { get; set; }
   
        
        internal Motorcycle GetYear()
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.year = Now;
            return motorcycle;
        }

        internal Motorcycle GetModel(string model)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.model = model;
            return motorcycle;
        }
        
        internal Motorcycle GetMake(string make)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.make = make;
            return motorcycle;
        }
        
        internal Motorcycle GetVinNumber(Guid vin)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.vinNumber = vin;
            return motorcycle;
        }
        
        internal Motorcycle GetOdometer(int miles)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.odometer = miles;
            if (miles > 100)
            { 
                Console.WriteLine("You motorcycle is not valid as odometer is over the allowed limit");
            }
            return motorcycle;
        }

        void ResetSettings()
        {
            
        }

        internal class Engine
        {
            private int _volume;
            private int _power;
            private string _engineType;
            
            private int Volume { get; set; }
            private int Power { get; set; }
            private string EngineType { get; set; }
            
            internal Engine GetVolume(int volume)
            {
                Engine engine = new Engine();
                engine.Volume = volume;
                if (volume > 3_200 && volume < 125)
                { 
                    Console.WriteLine("We do not support that engine volume");
                }
                return engine;
            }
            
            internal Engine GetPower(int power)
            {
                Engine engine = new Engine();
                engine.Volume = power;
                if (power > 300 && power < 50)
                { 
                    Console.WriteLine("We do not support that engine power");
                }
                return engine;
            }
            
            internal Engine GetEngineType(string type)
            {
                Engine engine = new Engine();
                engine.EngineType = type;
                if (!type.ToLower().Equals("gasoline") && !type.ToLower().Equals("electric") && !type.ToLower().Equals("hybrid"))
                { 
                    Console.WriteLine("We do not support that engine type");
                }
                return engine;
            }
        }
    }
}