using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
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
                numTotals[total - 2]++;
            }
            return numTotals;
        }
    }
}
