namespace Ticketing
{
    class Program
    {
        static string file = "Tickets.csv";

        static void Main(string[] args)
        {
            string userChoice;

            do
            {
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");

                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    ReadDataFromFile();
                }
                else if (userChoice == "2")
                {
                    CreateFileFromData();
                }

            } while (userChoice == "1" || userChoice == "2");
        }
    }
}