using System;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T3-Kulutus
 * Programmed: Joonas Pietilä 03.06.2020
 */

namespace T3_Kulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give distance in km:");
            int distance = Convert.ToInt32(Console.ReadLine());
            Kulutus(distance);
        }
        

        public static void Kulutus(int distance) { 
          
            
            float consumePerKm = 0.075f;
            float gasPrice = 1.55f;

            float consumeTotal = distance * consumePerKm;
            float gasTotal = consumeTotal * gasPrice;

            Console.Write("Gasoline consume is " + gasTotal + " liters and the cost is " + consumeTotal + " euros.");
        }
    }
}
