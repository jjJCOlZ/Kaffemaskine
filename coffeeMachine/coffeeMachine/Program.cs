
using coffeeMachine;
using System;

class Program
{
    static void Main(string[] args)
    {
        IWaterSource waterSource = new Container(); // Opret vandkilde (Container)
        IFilterable filter = new Filter(); // Opret filter
        ICoffeeBeans coffeeBeans = new CoffeeBeans(); // Opret kaffebønner

        CoffeeMachine coffeeMachine = new CoffeeMachine(waterSource, filter, coffeeBeans); // Opret kaffemaskine

        Console.WriteLine("Der bliver sat en kande over");

        coffeeMachine.Start(10); // Start kaffemaskinen og angiv antal kopper

        coffeeMachine.Stop(); // Stop kaffemaskinen

        Console.WriteLine("Kaffen er klar!");

        Console.ReadLine();
    }
}
