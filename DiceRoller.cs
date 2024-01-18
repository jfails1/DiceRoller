using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class DiceRoller
    {
        public static int[] RollDice(int numRolls)
        {
            int[] results = new int[13];

            Random rand = new Random();

            for (int count = 0; count < numRolls; count++)
            {
                int roll = rand.Next(1, 7) + rand.Next(1, 7);
                results[roll]++;
            }

            return results;
        }
    }
}
