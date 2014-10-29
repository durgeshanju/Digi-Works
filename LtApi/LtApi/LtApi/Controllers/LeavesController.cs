using System.Collections.Generic;
using System.Web.Http;
using Models;

namespace LtApi.Controllers
{
    public class LeavesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<Leaves> Get()
        {
            return new List<Leaves>();
        }

        // GET api/values/5
        public Leaves Get(int id)
        {
            return new Leaves();
        }

        // POST api/values
        public void Post(Leaves value)
        {
        }

        // PUT api/values/5
        public void Put(int id, Leaves value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
