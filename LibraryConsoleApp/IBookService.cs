namespace LibraryConsoleApp
{
    public interface IBookService
    {
        public int Add(string title, string author);
        public Book? Get(int bookId);
        public void Update(int bookId, string title, string author);
        public void Delete(int bookId);
    }
}