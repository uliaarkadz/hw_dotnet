using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();
            
            //caling private method
            //'Motorcycle.StartEnginePrivate()' is inaccessible due to its protection level
            //motorcycle.StartEnginePrivate();
            
            //calling public method
            motorcycle.MaxSpeedInternal();
            
            //calling protected method   Pr
            //'Motorcycle.AddMilesProtected()' is inaccessible due to its protection level
            //motorcycle.GetOdometerMilesProtected();
            
           // calling protected internal
           motorcycle.ResetSpeedProtectedInternal();
           
           // calling private protected
           // 'Motorcycle.AddVinNumberPrivateProtected()' is inaccessible due to its protection level
           //motorcycle.AddVinNumberPrivateProtected();

           SportBike sb = new SportBike();
           
           //caling private method
           //  'Motorcycle.StartEnginePrivate()' is inaccessible due to its protection level
          // sb.StartEnginePrivate();
            
           //calling public method
           sb.MaxSpeedInternal();
            
           //calling protected method  
           // 'Motorcycle.AddMilesProtected()' is inaccessible due to its protection level
          // sb.GetOdometerMilesProtected();
            
           // calling protected internal
           sb.ResetSpeedProtectedInternal();
           
           // calling private protected
          //  Program.cs(47, 15): [CS0122] 'Motorcycle.AddVinNumberPrivateProtected()' is inaccessible due to its protection level
           //sb.AddVinNumberPrivateProtected();
        }
    }
}