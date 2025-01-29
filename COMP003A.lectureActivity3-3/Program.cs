//Pedro Garcia
//COMP003A
//Johnathan Cruz
//Lecture Activity 3-3
namespace COMP003A.lectureActivity3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Control Statements Demo!\n");

            int range; // Range of numbers to iterate through

            while (true)
            {
                try // to handle invalid input
                {

                    Console.Write("Enter a positive integer to iterate through: "); // prompt to enter positive integer
                    range = int.Parse(Console.ReadLine()); // Parse the input to an integer
                    if (range <= 0) throw new Exception("Number must be positive"); // Checks if integer is positive
                    break; // Exit loop if input is valid
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}\nPlease try again.\n"); // error message
                }
            }



        }
    }
}
