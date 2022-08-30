using company.Iservices;
using company.Models;
using company.services;
using Microsoft.AspNetCore.Mvc;

namespace company.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        public IEservices<Employee> _eservices;
        public EmployeeController(IEservices<Employee> es)
        {
            _eservices = es;
        }
        [HttpGet]

        public ActionResult<List<Employee>> GetAll()
        {
            return _eservices.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> Getbyid(int id)
        {
            return _eservices.Getbyid(id);
        }
        [HttpPost]
        public ActionResult<List<Employee>> Insert(Employee emp)
        {
            return _eservices.Insert(emp);
        }
        [HttpPut("{comp}")]
        public ActionResult<Employee> Update(Employee emp)
        {
            return _eservices.Update(emp);
        }
        [HttpDelete("{id}")]
        public ActionResult<List<Employee>> Delete(int id)
        {
            return _eservices.Delete(id);
        }
    }
}
