namespace PreparationPrograms.LinQ;

public class TOP3
{
    public List<Employee> GetTop3Earners(List<Employee> employees)
    {
        return employees
            .OrderByDescending(x => x.Salary)
            .Take(3)
            .ToList();
    }
}