using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeMachine
{
    public interface IWaterSource
    {
        void PourWater(int cupCount); // Hælder vand i
    }
}