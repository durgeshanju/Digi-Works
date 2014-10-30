using System.Collections;
using System.Collections.Generic;

namespace Business
{
    public interface ILeaveTypes
    {
        IEnumerable<Models.LeaveType> GetAll();
    }
}
