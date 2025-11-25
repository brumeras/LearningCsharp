namespace PreparationPrograms.Dictionary;

public class ResidentInACity
{
    public List<string> GetCityResidents(Dictionary<string, List<string>> citizens, string city)
    {
        return citizens.GetValueOrDefault(city, new List<string>());
    }
}