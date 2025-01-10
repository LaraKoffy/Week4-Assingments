namespace Nr3
{
    internal class Program
    {
        
        static void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine(" Please enter a valid number.");
                }
            }
        }

        
        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;  
            }
            return sum;
        }

      
        static double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return (double)sum / numbers.Length; 
        }

      
        static void Main(string[] args)
        {
           
            int[] numbers = new int[3];

           
            FillArray(numbers);

            
            int sum = CalculateSum(numbers);

            
            double average = CalculateAverage(numbers);

            
            Console.WriteLine($"\nSum of the numbers: {sum}");
            Console.WriteLine($"Average of the numbers: {average:F2}");
        }
    }
}
