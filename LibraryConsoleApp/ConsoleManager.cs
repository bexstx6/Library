
namespace LibraryConsoleApp
{
    class ConsoleManager : IConsoleManager
    {
        public int GetInt(string placeHolder)
        {
            while (true)
            {
                WriteLine($"Please enter {placeHolder}:");
                string userInput = Console.ReadLine();
                if (userInput is not null)
                {
                    if(int.TryParse(userInput, out int numInput))
                    {
                        return numInput;
                    }
                }

                Console.WriteLine("Error occured. Int expected");
            }
        }

        public string GetString(string placeHolder)
        {
            while (true)
            {
                WriteLine($"Please enter {placeHolder}:");
                string userInput = Console.ReadLine();
                if (userInput is not null)
                {
                    return userInput;
                }

                Console.WriteLine("Error occured. String expected");
            }
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
