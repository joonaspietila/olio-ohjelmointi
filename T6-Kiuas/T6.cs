using System;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T6-Kiuas
 * Programmed: Joonas Pietilä 03.06.2020
 */
namespace T6_Kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a sauna OOP script. A sauna object has already been premade, and you can edit the different parameters within the program itself.\r\n\r\n" +
            "However, these parameters have to be edited within the .cs file, and cannot be accessed in the console. Please open the .cs file.\r\n\r\n" +
            "You can also reference different methods for each parameter within the Main method, for example the temperature can be changed by running: Kiuas1.ChangeTemp(value) and so on.\r\n\r\n" +
            "You can edit the Temperature, Moisture, Timer(before the sauna starts heating up), Duration and lastly, there's a toggle whether or not the sauna is on or off.");

            Kiuas kotiKiuas = new Kiuas()
            {
                enabled = true,
                temperatureCelsius = 90,
                moisture = .3f,
                timerMinutes = 120,
                durationMinutes = 90
            };
        }
    }
    // 
    public class Kiuas
    {
        // on/off kytkin
        public bool enabled { get; set; }
        //lämpötila 
        public int temperatureCelsius { get; set; }
        //kosteus % --> 0,00 - 1,00
        public float moisture { get; set; }
        //ajastin, ennen kuin kiuas menee päälle
        public float timerMinutes { get; set; }
        //aika jonka kiuas on päällä halutulla lämmöllä
        public float durationMinutes { get; set; }


        //asetusten säätämisen metodit
        public void Toggle()
        {
            enabled = !enabled;
            
        }
        public void ChangeTemp(int _celsius)
        {
            temperatureCelsius = _celsius;
            
        }
        public void ChangeMoisture(float _moisture)
        {
            moisture = _moisture;
            
        }
        public void ChangeTimer(int _timerMminutes)
        {
            timerMinutes = _timerMminutes;
            
        }
        public void ChangeDuration(int _durationMinutes)
        {
            durationMinutes = _durationMinutes;
            
        }
    }
}
