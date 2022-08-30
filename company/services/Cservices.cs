using company.Models;
using company.services;
using company.Iservices;

namespace company.services
{
    public class Cservices : ICservices<Company>
    {
       private List<Company> companys;
        public Cservices()
        {
            companys = new List<Company>() { new Company() {Id=1,Name="IConnect",Location="Ramallah"},
                                               new Company() {Id=2,Name="ITG",Location="Nablus" },
                                               new Company() {Id=3,Name="SYS",Location="Jenin"}};
        }
        public List<Company> Delete(int id)
        {
            Company comp = companys.FirstOrDefault(e => e.Id == id);
            companys.Remove(comp);
            return companys;
        }

        public List<Company> GetAll()
        {
            return companys;
        }

        public Company Getbyid(int id)
        {
            Company comp = companys.FirstOrDefault(e => e.Id == id);
            return comp;
        }

        public List<Company> Insert(Company comp)
        {
            companys.Add(comp);
            return companys;
        }

        public Company Update(Company comp)
        {
            var compToUpdate = companys.FirstOrDefault(e => e.Id == comp.Id);
            compToUpdate.Name = comp.Name;
            compToUpdate.Location = comp.Location;
            return compToUpdate;
        }
    }
}
