namespace PreparationPrograms.Dictionary;

public class AddResident
{
    public void AddNewResident(string name, Dictionary<string, List<string>> citizens, string city)
    {
        if(!citizens.ContainsKey(city))
        {
            citizens[city] = new List<string>(); 
        }
    
        citizens[city].Add(name); 
    }
}