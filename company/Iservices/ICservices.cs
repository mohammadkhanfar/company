using company.Models;

namespace company.Iservices
{
    public interface ICservices<Company>
    {
        List<Company> GetAll();
        Company Getbyid(int id);
        List<Company> Insert(Company comp);
        Company Update(Company comp);
        List<Company> Delete(int id);
        
    }
}
