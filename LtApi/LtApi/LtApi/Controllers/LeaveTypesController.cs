using System.Collections.Generic;
using System.Web.Http;
using Business;

namespace LtApi.Controllers
{
    public class LeaveTypesController : ApiController
    {
        readonly ILeaveTypes _leaveTypesBusiness = new LeaveTypes();


        //public IEnumerable<Leaves> Get()
        //{
        //    return _leaveTypesBusiness.SelectAll();
        //}
    }
}
