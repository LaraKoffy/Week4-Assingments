namespace Nr2
{
    internal class Program
    {
        const int ArraySize = 20;
        const int MinValue = 1;
        const int MaxValue = 100;

      
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
            Console.WriteLine("The array contains the following numbers:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

       
        static int GetSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i]; 
                }
            }

            return smallest;
        }

        
        static void Main(string[] args)
        {
           
            int[] numbers = new int[ArraySize];

            
            FillArray(numbers);

           
            DisplayArray(numbers);

            
            int smallestNumber = GetSmallestNumber(numbers);
            Console.WriteLine($"The smallest number in the array is: {smallestNumber}");
        }
    }
}
