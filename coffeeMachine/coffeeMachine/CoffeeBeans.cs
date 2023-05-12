using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeMachine
{
    public class CoffeeBeans : ICoffeeBeans
    {
        public void PourBeans()
        {
            try
            {
                // Der er kaffebønner i maskinen
                Console.WriteLine("Der er tilsat kaffebønner i maskinen.");
            }
            catch (Exception ex)
            {
                // Fejl under hældning af kaffebønner
                Console.WriteLine($"Fejl under hældning af kaffebønner: {ex.Message}");
            }
        }
    }
}
