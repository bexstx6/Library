
namespace LibraryConsoleApp
{
    class BookService : IBookService
    {
        public static List<Book> books = new List<Book>();

        public int Add(string title, string author)
        {
            books.Add(new Book { Id = books.Count, Title = title, Author = author });
            return books[books.Count - 1].Id;
        }


        public Book? Get(int bookId)
        {
            foreach (var book in books)
            {
                if (book.Id == bookId)
                {
                    return book;
                }
            }

            return null;
        }

        public void Update(int bookId, string title, string author)
        {
            foreach (var book in books)
            {
                if (book.Id == bookId)
                {
                    books[book.Id].Title = title;
                    books[book.Id].Author = author;
                }
            }

        }


        public void Delete(int bookId)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            foreach (var book in books)
            {
                Console.WriteLine(book.Id);
            }

            foreach (var book in books)
            {
                if (book.Id == bookId)
                {
                    books.RemoveAt(bookId);
                    break;
                }
            }
        }
    
    }
}
