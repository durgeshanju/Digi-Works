using System.Collections.Generic;
using System.Web.Http;
using Business;
using Employee = Business.Employee;

namespace LtApi.Controllers
{
    public class EmployeeController : ApiController
    {
        readonly IEmployee _employeeBusiness = new Employee();

        public IEnumerable<Models.Employee> Get()
        {
            return new List<Models.Employee>(); //_employeeBusiness.GetAll();
        }

        // GET api/values/5
        public Models.Employee Get(int id)
        {
            return new Models.Employee();
        }

        // POST api/values
        public void Post(Models.Employee value)
        {
        }

        // PUT api/values/5
        public void Put(int id, Models.Employee value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        
        }
}
