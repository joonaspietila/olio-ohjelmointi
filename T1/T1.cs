using System;

/* TTOS0200-Olio-ohjelmointi Kevät 2020
 * Kurssin aikataulu: 20.05.2020 - ?.09.2020
 * 
 * T1-Koulunumero
 * programmed: Joonas Pietilä 03.06.2020
 */

namespace T1_Koulunumero
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your points:");
            int points = Convert.ToInt32(Console.ReadLine());
            GiveExamPoints(points);
        }



        public static void GiveExamPoints(int points)
        {
            int number;
            if (points >= 10)
            {
                number = 5;
            }
            else if (points >= 8)
            {
                number = 4;
            }
            else if (points >= 6)
            {
                number = 3;
            }
            else if (points >= 4)
            {
                number = 2;
            }
            else if (points >= 2)
            {
                number = 1;
            }
            else
            {
                number = 0;
            }
            Console.WriteLine("Your number is: " + number);

        }
    }
}