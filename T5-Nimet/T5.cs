using System;
using System.Collections.Generic;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T5-Nimet
 * Programmed: Joonas Pietilä 03.06.2020
 */

namespace T5_Nimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Names();
        }
        public static void Names()
        {

            Console.WriteLine("Please, give names of students. Empty input will stop the input.");

            List<string> nameList = new List<string>();
            bool emptyInput = false;

            while (emptyInput == false)
            {
                string inputString = Console.ReadLine();
                if (string.IsNullOrEmpty(inputString))
                {
                    emptyInput = true;
                }
                else
                {
                    nameList.Add(inputString);
                }

            }

            //check if any names were entered
            if (nameList.Count > 0)
            {
                nameList.Sort();
                Console.WriteLine("The entered names were: ");
                nameList.ForEach(i => Console.Write("{0}\t", i));
            }
            else
            {
                Console.WriteLine("No names were entered!");
            }

        }
    }
}
