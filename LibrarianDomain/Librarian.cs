namespace LibrarianDomain
{
    public class Librarian
    {
        public static int calculatePage(int wordCount, int wordPerPage)
        {
            if (wordPerPage == 0) throw new ArgumentException("Nope");
            return (int)Math.Ceiling((double)wordCount / wordPerPage);
        }
    }
}
