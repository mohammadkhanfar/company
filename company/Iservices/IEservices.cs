using company.Models;

namespace company.Iservices
{
    public interface IEservices<Employee>
    {
        List<Employee> GetAll();
        Employee Getbyid(int id);
        List<Employee> Insert (Employee emp);
        Employee Update (Employee emp);
        List<Employee> Delete (int id);
    }
}
