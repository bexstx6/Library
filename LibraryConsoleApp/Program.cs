namespace LibraryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookService bookService = new BookService();
            IConsoleManager consoleManager = new ConsoleManager();
            bool exit = false;

            Console.WriteLine("Menu:\n 1)Create \n 2)Read \n 3)Update \n 4)Delete \n 5)Exit ");

            while (exit == false)
            {
                try
                {
                    var menuAction = (MenuActions)consoleManager.GetInt("Menu action");
                    switch (menuAction)
                    {

                        case MenuActions.Create:
                            var bookTitle = consoleManager.GetString("Book's Title");
                            var authorName = consoleManager.GetString("Author's Name");

                            var newBookId = bookService.Add(authorName, bookTitle);
                            consoleManager.WriteLine("Your books's Id: " + newBookId.ToString());
                            break;

                        case MenuActions.Read:
                            var bookId = consoleManager.GetInt("Book's Id");

                            var book = bookService.Get(bookId);
                            consoleManager.WriteLine(book.ToString());
                            break;

                        case MenuActions.Update:
                            var updatedBookId = consoleManager.GetInt("Book's Id");
                            var updatedBookTitle = consoleManager.GetString("New Book's Title");
                            var updatedAuthorName = consoleManager.GetString("New Author's Name");

                            bookService.Update(updatedBookId, updatedBookTitle, updatedAuthorName);

                            break;

                        case MenuActions.Delete:
                            var bookIdToDelete = consoleManager.GetInt("Book's Id");
                            bookService.Delete(bookIdToDelete);

                            break;

                        case MenuActions.Exit:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("An Error occured, please try again.");
                            break;
                    }

                }
                catch (Exception)
                {
                    consoleManager.WriteLine("An unexpected error occured!!!");
                }
            }

        }
    }
}
