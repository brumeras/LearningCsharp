namespace PreparationPrograms;

public class Reverse
{
    public string ReverseLine(string line)
    {
        string reversedLine = "";
        
        //to get the last valid index
        for(int i = line.Length - 1; i >= 0; i--)
        {
            reversedLine += line[i];
        }
        return reversedLine;
    }
}