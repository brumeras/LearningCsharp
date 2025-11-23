namespace PreparationPrograms.LinQ;

public class MaxSalary
{
    public double GetMaxSalary(List<Employee> employees)
    {
        return employees.Max(employee => employee.Salary);
    }
}