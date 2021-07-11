using System;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const ushort MaxSpeed = 200;
        string vinNumber = "4Y1SL65848Z411439";
        private int odometer = 35_200;

        void StartEnginePrivate()
        {
            Console.WriteLine("Start Engine");
        }
        
        public void MaxSpeedInternal()
        {
            Console.WriteLine("Set Max speed" + MaxSpeed);
        }

        protected void GetOdometerMilesProtected()
        {
            Console.WriteLine("Add Miles to odometer" + odometer);
        }
        
        protected internal void ResetSpeedProtectedInternal()
        {
            Console.WriteLine("Reset current speed");
        }

        private protected void AddVinNumberPrivateProtected()
        {
            Console.WriteLine("Get Vin Number" + vinNumber);
        }
    }
}