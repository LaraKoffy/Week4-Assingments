namespace Nr4
{
    internal class Program
    {
        static void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name for student {i + 1}:");
                names[i] = Console.ReadLine();
            }
        }

        
        static void ReadGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Enter grade for student {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                }
            }
        }

      
        static int GetHighestGradeIndex(int[] grades)
        {
            int highestGradeIndex = 0;

            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > grades[highestGradeIndex])
                {
                    highestGradeIndex = i; 
                }
            }

            return highestGradeIndex;
        }

       
        static void Main(string[] args)
        {
            
            Console.Write("Enter the course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter the number of students: ");
            int studentCount;
            while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
            {
                Console.WriteLine(" Please enter a positive integer for the number of students.");
            }

          
            string[] names = new string[studentCount];
            int[] grades = new int[studentCount];

            
            ReadNames(names);
            ReadGrades(grades);

           
            int highestGradeIndex = GetHighestGradeIndex(grades);

            
            Console.WriteLine($"\nCourse: {courseName}");
            Console.WriteLine($"The student with the highest grade is {names[highestGradeIndex]} with a grade of {grades[highestGradeIndex]}.");
        }

    }
}
