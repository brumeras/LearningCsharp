namespace PreparationPrograms.LinQ;

public class SalaryHigherThan
{
    public List<Employee> GetSalaryHigherThan(List<Employee> employees, double threshold)
    {
        return employees
            .Where(x => x.Salary > threshold)
            .ToList();
    }
}