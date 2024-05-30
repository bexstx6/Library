namespace LibraryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookService bookService = new BookService();
            IConsoleManager consoleManager = new ConsoleManager();

            Console.WriteLine("Menu:\n 1)Create \n 2)Read \n 3)Update \n 4)Delete ");

            while (true)
            {
                var menuAction = (MenuActions)consoleManager.GetInt("Menu action");
                switch (menuAction)
                {

                    case MenuActions.Create:
                        string bookTitle = consoleManager.GetString("Book's Title");
                        string authorName = consoleManager.GetString("Author's Name");
                        
                        var newBookId = bookService.Add(authorName, bookTitle);
                        consoleManager.WriteLine("Your books's Id: " + newBookId.ToString());
                        break;

                    case MenuActions.Read:
                        int bookId = consoleManager.GetInt("Book's Id");

                        var book = bookService.Get(bookId);
                        consoleManager.WriteLine(book.ToString());
                        break;

                    //case MenuActions.Update:
                    //    bookService.Update(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

                    //    break;

                    //case MenuActions.Delete:
                    //    bookService.Delete(Console.ReadLine());

                    //    break;

                    default:
                        Console.WriteLine("An Error occured, please try again.");
                        break;
                }

            }

        }
    }
}
