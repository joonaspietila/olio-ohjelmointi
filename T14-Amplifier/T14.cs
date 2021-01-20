using System;
using System.Dynamic;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T14-Amplifier
 * Programmed: Joonas Pietilä 04.06.2020
 */

namespace T14_Amplifier
{
    class Program
    {
        static void Main(string[] args)
        {

            Vahvistin volume = new Vahvistin()
            {
                VolumeValue = 110
            };

        }
    }
    //
    public class Vahvistin
    {
        private int volumeValue;
        public int VolumeValue
        {
            get { return volumeValue; }
            set
            {
                if (value >= 0 & value <= 100)
                {
                    volumeValue = value;
                    Console.WriteLine("Amplifier volume is set to: " + value);
                }
                if (value > 100)
                {
                    volumeValue = 100;
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : 100");
                }
                if (value < 0)
                {
                    volumeValue = 0;
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
                }

            }
        }

    }
}