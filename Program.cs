using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //initialize variables and class instances
        int numRolls = 0;
        int[] numTotals = new int[11];
        GetRolls roll = new GetRolls();
        
        //output greeting
        Console.WriteLine("Welcome to the dice roll simulator." + "\n");
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

internal class GetRolls
{
    public int[] RollDice(int numRolls)
    {
        //initialize variables and array
        int die1 = 0;
        int die2 = 0;
        int total = 0;
        int[] numTotals = new int[11];
        Random random = new Random();

        //loop thru the array
        for (int i = 0; i < numRolls; i++)
        {
            //generate random numbers
            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);
            total = die1 + die2;
            //put total value in the array
            numTotals[total-2]++;
        }
        return numTotals;
    }
}
