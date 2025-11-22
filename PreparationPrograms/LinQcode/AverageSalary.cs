namespace PreparationPrograms.LinQ;

public class AverageSalary
{
    public double GetAverageSalary(List<Employee> employees)
    {
        return employees.Average(x => x.Salary);
    }
}