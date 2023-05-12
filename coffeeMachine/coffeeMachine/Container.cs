using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeMachine
{
    public class Container : IWaterSource
    {
        public void PourWater(int cupCount)
        {
            try
            {
                // hældning af vand
                Console.WriteLine($"Hældte {cupCount} kopper vand i beholderen.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under hældning af vand: {ex.Message}");
                // Håndter eventuelle fejl eller oprydning
            }
        }
    }
}