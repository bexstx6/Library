namespace LibraryConsoleApp
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} \nTitle: {Title} \nAuthor: {Author}";
        }
    }
}
