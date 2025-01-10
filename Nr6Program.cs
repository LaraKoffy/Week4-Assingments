namespace Nr6
{
    internal class Program
    {
        static void ThrowDice(int[] diceCounts, int numberOfThrows)
        {
            Random random = new Random();

           
            for (int i = 0; i < numberOfThrows; i++)
            {
                int diceValue = random.Next(1, 7); 
                diceCounts[diceValue - 1]++; 
            }
        }

        
        static void DisplayDiceCounts(int[] diceCounts)
        {
            for (int i = 0; i < diceCounts.Length; i++)
            {
                Console.WriteLine($"Value {i + 1} was thrown {diceCounts[i]} times.");
            }
        }

        
        static void Main(string[] args)
        {
           
            int[] diceCounts = new int[6];

           
            int numberOfThrows = 6000;

            
            ThrowDice(diceCounts, numberOfThrows);

            
            Console.WriteLine("Total counts for each dice value after 6000 throws:");
            DisplayDiceCounts(diceCounts);

        }
}
