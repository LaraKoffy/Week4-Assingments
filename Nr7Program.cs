namespace Nr7
{
    internal class Program
    {
        static void InitializeSeats(bool[] seats)
        {
            Random random = new Random();

            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = random.Next(0, 2) == 1;
            }
        }


        static void DisplaySeatingArrangement(bool[] seats)
        {
            Console.WriteLine("Seating Arrangement:");

            for (int i = 0; i < seats.Length; i++)
            {
                Console.WriteLine($"Seat {i + 1}: {(seats[i] ? "Available" : "Booked")}");
            }
            Console.WriteLine();
        }


        static void BookSeat(bool[] seats, int seatNumber)
        {

            if (seatNumber < 1 || seatNumber > seats.Length)
            {
                Console.WriteLine("Invalid seat number. Please enter a number between 1 and 10.");
                return;
            }


            if (!seats[seatNumber - 1])
            {
                Console.WriteLine($"Seat {seatNumber} is already booked.");
            }
            else
            {

                seats[seatNumber - 1] = false;
                Console.WriteLine($"Seat {seatNumber} has been successfully booked.");
            }
        }

        static void Main(string[] args)
        {

            bool[] seats = new bool[10];


            InitializeSeats(seats);


            DisplaySeatingArrangement(seats);


            Console.WriteLine("Enter the seat number you want to book (1-10):");
            if (int.TryParse(Console.ReadLine(), out int seatNumber))
            {

                BookSeat(seats, seatNumber);
            }


            DisplaySeatingArrangement(seats);
        }
    }
}
