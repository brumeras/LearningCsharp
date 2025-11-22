namespace PreparationPrograms.LinQ;

public class ABCorder
{
    public List<Employee> GetOrder(List<Employee> employees)
    {
        return employees
            .OrderBy(x => x.Name)
            .ToList();
    }
}