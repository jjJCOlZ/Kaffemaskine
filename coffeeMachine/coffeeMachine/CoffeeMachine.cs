using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeMachine
{
    public class CoffeeMachine : KitchenMachine
    {
        private IWaterSource waterSource; // Vandkilde
        private IFilterable filter; // Filter
        private ICoffeeBeans coffeeBeans; // Kaffebønner
        private bool isRunning; // Flag for om maskinen kører

        public CoffeeMachine(IWaterSource water, IFilterable filter, ICoffeeBeans beans)
        {
            waterSource = water;
            this.filter = filter;
            coffeeBeans = beans;
            isRunning = false;
        }

        public override void TurnOn()
        {
            try
            {
                Console.WriteLine("Maskinen tændes");
                isRunning = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Maskinen kunne ikke tændes {ex.Message}");
            }
        }

        public override void TurnOff()
        {
            try
            {
                Console.WriteLine("Slukker kaffemaskinen.");
                isRunning = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under slukning af kaffemaskinen: {ex.Message}");
                // Håndter eventuelle fejl eller ryd op
            }
        }

        public void Start(int cupCount)
        {
            try
            {
                waterSource.PourWater(cupCount); // Hæld vand i
                filter.InsertFilter(); // Isæt filter
                coffeeBeans.PourBeans(); // Hæld kaffebønner i
                TurnOn(); // Tænd maskinen
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under start af kaffemaskinen: {ex.Message}");
                // Håndter eventuelle fejl eller ryd op
            }
        }

        public void Stop()
        {
            try
            {
                TurnOff(); // Sluk maskinen
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under stop af kaffemaskinen: {ex.Message}");
                // Håndter eventuelle fejl eller ryd op
            }
        }
    }
}