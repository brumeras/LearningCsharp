namespace PreparationPrograms.LinQ;

public class OnlyNames
{
    public List<string> GetEmployeeNames(List<Employee> employees)
    {
        return employees.Select(x => x.Name).ToList();
    }
}