using System.Runtime.InteropServices.JavaScript;

namespace PreparationPrograms.LinQ;

//ANY naudojimas
public class DoesNameExist
{
    public bool CheckIfNameExist(List<Employee> employees, string name)
    {
        return employees.Any(x => x.Name == name); 
    }
}