namespace LibraryConsoleApp
{
    public interface IConsoleManager
    {
        public string GetString(string placeHolder);
        public int GetInt(string placeHolder);
        public void WriteLine(string message);

    }
}
