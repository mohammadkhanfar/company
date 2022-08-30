using company.Models;
using company.services;
using company.Iservices;

namespace company.services
{
    public class Eservices : IEservices<Employee>
    {
        List<Employee> employees;
        public Eservices()
        {
            employees = new List<Employee>() { new Employee() {Id=1,Name="ameer",Age=25,IdCompany=1 },
                                               new Employee() {Id=2,Name="Mohammad",Age=33,IdCompany=2 },
                                               new Employee() {Id=3,Name="Khalil",Age=50,IdCompany=3 }};
        }
        public List<Employee> Delete(int id)
        {
            Employee emp = employees.FirstOrDefault(e => e.Id == id);
            employees.Remove(emp);
            return employees;
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee Getbyid(int id)
        {
            Employee emp=employees.FirstOrDefault(e=>e.Id ==id);
            return emp;
        }

        public List<Employee> Insert(Employee emp)
        {
             employees.Add(emp);
            return employees;
        }

        public Employee Update(Employee emp)
        {
            var empToUpdate = employees.FirstOrDefault(e => e.Id == emp.Id);
            empToUpdate.Name = emp.Name;
            empToUpdate.Age = emp.Age;  
            return empToUpdate;
            
        }
    }
}
