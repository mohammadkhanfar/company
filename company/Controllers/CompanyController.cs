using company.Iservices;
using company.Models;
using company.services;
using Microsoft.AspNetCore.Mvc;

namespace company.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        public ICservices<Company> _cservices;
        public CompanyController(ICservices<Company> cs)
        {
            _cservices = cs;
        }
        [HttpGet]

        public ActionResult<List<Company>> GetAll()
        {
            return _cservices.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<Company> Getbyid(int id)
        {
            return _cservices.Getbyid(id);
        }
        [HttpPost]
        public ActionResult<List<Company>> Insert(Company comp)
        {
            return _cservices.Insert(comp);
        }
        [HttpPut("{comp}")]
        public ActionResult<Company> Update(Company comp)
        {
            return _cservices.Update(comp);
        }
        [HttpDelete("{id}")]
        public ActionResult<List<Company>> Delete(int id)
        {
            return _cservices.Delete(id);
        }
    }
}
