using System;

namespace T3_Kulutus
{
    class Program
    {
        static void Main(string[] args)
        {


            float consumePerKm = 0.075f;
            float gasPrice = 1.55f;

            float consumeTotal = distance * consumePerKm;
            float gasTotal = consumeTotal * gasPrice;

            Console.Write("Gasoline consume is " + gasTotal + " liters and the cost is " + consumeTotal + " euros.");
        }
    }
}
