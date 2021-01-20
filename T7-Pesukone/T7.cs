using System;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T7-Pesukone
 * Programmed: Joonas Pietilä 03.06.2020
 */

namespace T7_Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a washing machine OOP script. \r\n\r\n" +
            "Please enter a wash program to get the machine started: \r\n1.Mix 2.Hiki, 3.Siliävät, 4.Villa");
            int washProgram = Convert.ToInt32(Console.ReadLine());

            if (washProgram > 0 && washProgram < 5)
            {
                Pesukone pesukone = new Pesukone(washProgram, 60, true);
                Console.WriteLine("You started a {0} program, here are some stats about it: \r\nduration: {1} minutes, temperature: {2} celsius, {3} rounds per minute", pesukone.programName, pesukone.durationMinutes, pesukone.temperatureCelsius, pesukone.roundsPerMinute);
            }
            else
            {
                Console.WriteLine("Please enter a number between 1-4");
            }
        }
    }
    // 
    public class Pesukone
    {

        //ohjelman nimi
        public string programName { get; set; }
        //veden käyttö
        public bool useWater { get; set; }
        //lämpötila
        public int temperatureCelsius { get; set; }
        //kosteus % --> 0,00 - 1,00
        public float roundsPerMinute { get; set; }
        //ajastin, ennen kuin pesukone menee päälle
        public float timerMinutes { get; set; }
        //aika jonka kiuas on päällä halutulla lämmöllä
        public float durationMinutes { get; set; }
        //bool, joka ilmoittaa, kun ohjelma on valmis
        public bool washFinished { get; set; }

        public Pesukone(int washProgram)
        {
            useWater = true;
            //eri ohjelmat
            if (washProgram == 0)
            {
                programName = "Mix";
                temperatureCelsius = 40;
                roundsPerMinute = 1000;
                durationMinutes = 120;
            }
            if (washProgram == 1)
            {
                programName = "Hiki";
                temperatureCelsius = 60;
                roundsPerMinute = 1200;
                durationMinutes = 120;
            }
            if (washProgram == 2)
            {
                programName = "Siliavat";
                temperatureCelsius = 40;
                roundsPerMinute = 800;
                durationMinutes = 120;
            }
            if (washProgram == 3)
            {
                programName = "Pika";
                temperatureCelsius = 40;
                roundsPerMinute = 1000;
                durationMinutes = 40;
            }
            if (washProgram == 4)
            {
                programName = "Villa";
                temperatureCelsius = 40;
                roundsPerMinute = 1000;
                durationMinutes = 120;
            }
        }

        public Pesukone(int washProgram, int timerMinutes, bool dryingProgram)
        {
            useWater = true;
            //eri ohjelmat
            if (washProgram == 0)
            {
                programName = "Mix";
                temperatureCelsius = 40;
                roundsPerMinute = 1000;
                durationMinutes = 120;
            }
            if (washProgram == 1)
            {
                programName = "Hiki";
                temperatureCelsius = 60;
                roundsPerMinute = 1200;
                durationMinutes = 120;
            }
            if (washProgram == 2)
            {
                programName = "Siliavat";
                temperatureCelsius = 40;
                roundsPerMinute = 800;
                durationMinutes = 120;
            }
            if (washProgram == 3)
            {
                programName = "Pika";
                temperatureCelsius = 40;
                roundsPerMinute = 1000;
                durationMinutes = 40;
            }
            if (washProgram == 4)
            {
                programName = "Villa";
                temperatureCelsius = 40;
                roundsPerMinute = 1000;
                durationMinutes = 120;
            }
            if (durationMinutes <= 0)
                washFinished = true;

            if (dryingProgram == true && washFinished)
            {
                useWater = false;
                temperatureCelsius = 0;
                roundsPerMinute = 800;
                durationMinutes = 60;
                timerMinutes = 0;
            }
        }
    }
}
