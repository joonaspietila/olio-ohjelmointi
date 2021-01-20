using System;

/* TT0200 Olio-ohjelmointi Kevät 2020
 * T13-Elevator
 * Programmed: Joonas Pietilä 04.06.2020
 */

class Program
{
    static void Main(string[] args)
    {
        elevator obj = new elevator();
        obj.getInputFromUser();
    }
}

public class elevator
{
    int iChoice;
    int iCurrentPossition = 1;

    public void getInputFromUser()
    {
        Console.WriteLine("You are currently in floor number {0}. Please enter the floor number to visit.", iCurrentPossition);
        if (int.TryParse(Console.ReadLine(), out iChoice))
        {
            if (iChoice > 5 || iChoice < 1)
            {
                Console.WriteLine("Please enter a value between 1-5");
                getInputFromUser();
            }
            else
            {
                elevatorAction(iChoice);
            }
        }
        else
        {
            Console.WriteLine("Please enter valid input (int value)");
            getInputFromUser();
        }
    }
    private void moveUp(int idestinationFloor)
    {
        for (int i = iCurrentPossition; i <= idestinationFloor; i++)
        {
            Console.WriteLine("you are on " + i + " floor");
            if (i == idestinationFloor)
            {

                Console.WriteLine("have a good day. bye bye");
                iCurrentPossition = idestinationFloor;
                idestinationFloor = 0;
                break;
            }
        }
        getInputFromUser();
    }
    private void moveDown(int idestinationFloor)
    {
        for (int i = iCurrentPossition; i >= idestinationFloor; i--)
        {
            Console.WriteLine("you are on " + i + " floor");
            if (i == idestinationFloor)
            {

                Console.WriteLine("have a good day. bye bye");
                iCurrentPossition = idestinationFloor;
                idestinationFloor = 0;
                break;
            }
        }
        getInputFromUser();
    }
    private void elevatorAction(int iDestinationFloor)
    {
        if (iDestinationFloor > iCurrentPossition)
        {
            moveUp(iDestinationFloor);
        }
        else if (iDestinationFloor < iCurrentPossition)
        {
            moveDown(iDestinationFloor);
        }
    }
}