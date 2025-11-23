namespace PreparationPrograms.LinQ;

public class MakesMoreThan
{
    public bool CheckIfMakesMoreThan(List<Employee> employee, double salary)
    {
        return employee.All(x => x.Salary > salary);
    }
}