namespace PreparationPrograms.LinQ;

public class TotalSalary
{
    public double GetTotalSalary(List<Employee> employees)
    {
        return employees.Sum(x => x.Salary);
    }
}