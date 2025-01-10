namespace Nr1
{
    internal class Program
    {
        private const int ArraySize = 20;
        private const int MinValue = 1;
        private const int MaxValue = 100;

        
        static void FillArray(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(MinValue, MaxValue + 1); 
            }
        }

        
        static void DisplayArray(int[] numbers)
        {
            Console.WriteLine("Array elements:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");

                
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine(); 
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[ArraySize];

            
            FillArray(numbers);

            
            DisplayArray(numbers);
        }
    }
}
