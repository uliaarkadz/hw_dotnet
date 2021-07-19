using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();
            
            //caling private method
            // 'Motorcycle' does not contain a definition for 'StartEnginePrivate' and no accessible extension method
            // 'StartEnginePrivate' accepting a first argument of type 'Motorcycle' could be found (are you missing a using directive or an assembly reference?)
           // motorcycle.StartEnginePrivate();
            
            //calling public method
            motorcycle.MaxSpeedInternal();
            
            //calling protected method   Pr
            //'Motorcycle.AddMilesProtected()' is inaccessible due to its protection level
           // motorcycle.GetOdometerMilesProtected();
            
            // calling protected internal
            //'Motorcycle.ResetSpeedProtectedInternal()' is inaccessible due to its protection level
            //motorcycle.ResetSpeedProtectedInternal();
           
            // calling private protected
            //  'Motorcycle' does not contain a definition for 'AddVinNumberPrivateProtected' and no accessible extension method
            // 'AddVinNumberPrivateProtected' accepting a first argument of type 'Motorcycle' could be found (are you missing a using directive or an assembly reference?)
            //motorcycle.AddVinNumberPrivateProtected();
        }
    }
}