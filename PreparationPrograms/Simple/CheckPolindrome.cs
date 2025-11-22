public class CheckPolindrome
{
    public bool CheckIfPolindrome(string polindrome)
    {
        string cleaned = polindrome.Replace(" ", "").ToLower();
        
        char[] reversed = new char[cleaned.Length];
        
        for (int i = 0; i < cleaned.Length; i++)
        {
            reversed[i] = cleaned[cleaned.Length - 1 - i];
        }
        
        for (int i = 0; i < cleaned.Length; i++)
        {
            if (reversed[i] != cleaned[i])
            {
                return false; 
            }
        }
        
        return true;  
    }
}