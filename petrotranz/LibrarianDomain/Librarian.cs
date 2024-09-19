namespace LibrarianDomain
{
    public class Librarian
    {
        public int CalculatePage(int wordCount, int wordPerPage)
        {
            if (wordPerPage == 0) throw new ArgumentException("Words per page has to be greater than 0");
            return (int)Math.Ceiling((double)wordCount / wordPerPage);
        }
    }
}
