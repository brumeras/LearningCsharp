namespace PreparationPrograms;

public class HowManyTimes
{
    public void HowManyTimesCount(string line1)
    {   
        //Sukuriamas tarsi LIST su simboliu ir kiek kartu jis pasikartojo.
        Dictionary<char, int> symbolCount = new Dictionary<char, int>();
        
        for (int i = 0; i < line1.Length; i++)
        {
            char symbol = line1[i];
            
            //Tikrina, ar toks simbolis jau buvo.
            //Jei buvo, tai didina count, jei ne - priskiria 1.
            if (symbolCount.ContainsKey(symbol))
            {
                symbolCount[symbol]++;
            }
            else
            {
                symbolCount[symbol] = 1;
            }
        }

        var keys = symbolCount.Keys.ToList();
        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine($"{keys[i]} - {symbolCount[keys[i]]}");
        }
    }
}