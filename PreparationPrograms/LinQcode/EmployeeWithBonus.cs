namespace PreparationPrograms.LinQ;

public class EmployeeWithBonus
{
    public List<object> GetEmployeesWithBonus(List<Employee> employees)
    {   
        //Sukuriamas naujas objektas basically 
        return employees.Select(x => new
        {
            Name = x.Name,
            Salary = x.Salary,
            Bonus = x.Salary * 0.1
        }).ToList<object>();
    }
}