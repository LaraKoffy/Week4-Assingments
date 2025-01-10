namespace Nr5
{
    internal class Program
    {
        static void ReadNumbers(int[] numbers)
        {
            int index = 0;

            while (index < numbers.Length)
            {
                Console.WriteLine("Enter a number (0 to stop):");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break; 
                }

                numbers[index] = input; 
                index++;
            }
        }

        
        static int CountSearchValue(int[] numbers, int searchValue)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    count++;
                }
            }

            return count;
        }

     
        static void Main(string[] args)
        {
            
            int[] numbers = new int[20];

            
            ReadNumbers(numbers);

           
            Console.WriteLine("Enter a number to search for:");
            int searchValue = int.Parse(Console.ReadLine());

           
            int occurrences = CountSearchValue(numbers, searchValue);

           
            Console.WriteLine($"The number {searchValue} occurs {occurrences} times in the array
        }
    }
}
