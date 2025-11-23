namespace PreparationPrograms.LinQ;

public class MinSalary
{
    public double GetMinSalary(List<Employee> employees)
    {
        return employees.Min(employee => employee.Salary);
    }
}