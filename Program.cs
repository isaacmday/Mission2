using System.Globalization;
using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        //initialize variables and class instances
        int numRolls = 0;
        int[] numTotals = new int[11];
        GetRolls roll = new GetRolls();
        
        //output greeting
        Console.WriteLine("Welcome to my dice roll simulator." + "\n");
        Console.WriteLine("How many rolls would you like to simulate?");
        
        //get the number of rolls
        numRolls = int.Parse(Console.ReadLine());

        Console.WriteLine("\n" + "Results:");

        //get the array of roll counts
        numTotals = roll.RollDice(numRolls);

        //loop thru the array
        for (int i = 0; i < numTotals.Length; i++)
        {
            int currValue = 0;

            //calculate the count percentage of each value 2-12
            currValue = numTotals[i] * 100 / numRolls;
            Console.Write("\n" + (i + 2) + ": ");

            //print out the correct number of asterisks
            for (int j = 0; j < currValue; j++) 
            {
                Console.Write("*");
            }
        }
        //ending message
        Console.WriteLine("\n" + "\n" + "Total number of rolls = " + numRolls + "." + "\n" + "Thanks for using my simulator. See ya!");
    }
}