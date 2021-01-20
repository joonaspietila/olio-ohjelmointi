using System;
using System.Collections.Generic;
using System.Linq;



namespace T2_Makihyppy
{

    class Program
    {

        static void Main(string[] args)
        {
            int judgeCount = 5;
            Console.WriteLine("Enter the points for 5 judges: ");
            List<int> allJudges = new List<int>();
            for (int i = 0; i < judgeCount; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                allJudges.Add(input);
            }

            allJudges.Sort();

            allJudges.RemoveAt(allJudges.Count - 1);
            allJudges.RemoveAt(0);

            int totalPoints = allJudges.Sum();

            allJudges.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine("The total sum of the points is: " + totalPoints);
        }

    }


}

