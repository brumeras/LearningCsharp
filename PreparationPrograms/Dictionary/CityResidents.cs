namespace PreparationPrograms.Dictionary;

public class CityResidents
{
    public Dictionary<string, List<string>> GetResidents()
    {
        Dictionary<string, List<string>> citizens = new Dictionary<string, List<string>>();

        citizens.Add("Vilnius", new List<string> { "Jonas", "Petras", "Ona" });
        citizens.Add("Kaunas", new List<string> { "Marija", "Antanas" });
        citizens.Add("Panevezys", new List<string> { "Kamile", "Titas" });
        
        return citizens;
        
    }
}