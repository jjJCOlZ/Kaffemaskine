using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeMachine
{
    public class Filter : IFilterable
    {
        public void InsertFilter()
        {
            try
            {
                // indsættelse af filter
                Console.WriteLine("Satte filteret i.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under indsættelse af filter: {ex.Message}");
                // Håndter eventuelle fejl eller oprydning
            }
        }
    }
}