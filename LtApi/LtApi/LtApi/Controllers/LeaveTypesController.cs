using System.Collections.Generic;
using System.Web.Http;
using Business;
using Models;

namespace LtApi.Controllers
{
    public class LeaveTypesController : ApiController
    {
        readonly ILeaveTypes _leaveTypesBusiness = new LeaveTypes();

        public IEnumerable<LeaveType> Get()
        {
            return _leaveTypesBusiness.GetAll();
        }

       // GET api/values/5
        public LeaveType Get(int id)
        {
            return new LeaveType();
        }

        // POST api/values
        public void Post(LeaveType value)
        {
        }

        // PUT api/values/5
        public void Put(int id, LeaveType value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
