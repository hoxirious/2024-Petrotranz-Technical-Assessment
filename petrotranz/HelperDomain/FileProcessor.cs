namespace HelperDomain
{
    public static class Helper
    {
        public static string ReadAllText(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                return text;
            }
            catch (FileNotFoundException _)
            {
                // Handle the case where the file does not exist
                throw new ArgumentException($"Error: File '{filePath}' not found.");
            }
        }
    }
}
