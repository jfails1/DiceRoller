using DiceRoller;

namespace DiceRoller
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the dice throwing simulator!");
            System.Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numberOfRolls = int.Parse(System.Console.ReadLine());

            int[] rollResults = DiceRoller.RollDice(numberOfRolls);

            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            System.Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            for (int count = 2; count <= 12; count++)
            {
                System.Console.Write($"{count}: ");
                int rollCount = rollResults[count];
                for (int counter = 0; counter < rollCount; counter++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}