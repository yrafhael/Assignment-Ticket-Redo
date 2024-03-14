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

        static void ReadDataFromFile()
        {
            if (File.Exists(file))
            {
                bool isFirstLine = true;
                string[] headerFields = null;

                using (StreamReader sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        if (isFirstLine)
                        {
                            headerFields = line.Split(',');
                            isFirstLine = false;
                            continue;
                        }

                        string[] fields = line.Split(',');

                        if (fields.Length >= headerFields.Length) // Allowing for extra data fields
                        {
                            for (int i = 0; i < headerFields.Length; i++)
                            {
                                if (i < fields.Length)
                                {
                                    if (headerFields[i] == "Watching")
                                    {
                                        // Print all names in the Watching list
                                        List<string> watching = fields[i].Split(',').ToList();
                                        Console.WriteLine($"{headerFields[i]}: {string.Join(", ", watching)}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{headerFields[i]}: {fields[i]}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"{headerFields[i]}: N/A"); // Handle extra data fields
                                }
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Error: Number of fields in a line does not match the number of header fields.");
                            Console.WriteLine("Header Fields: " + string.Join(", ", headerFields));
                            Console.WriteLine("Data Fields: " + string.Join(", ", fields));
                            // Additional handling or logging can be added here
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}