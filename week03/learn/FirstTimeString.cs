public class FirstTimeString
{
    public char FindFirstLetter(string text)
    {
        HashSet<char> seen = new HashSet<char>();
        text = text.ToLower();
        
        foreach (char c in text)
        {
            if (!seen.Add(c))
            {
                return c;
            }
        }
        throw new ArgumentException("No unique characters found.");
    }
}