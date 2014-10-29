using System.Collections.Generic;
using Models;

namespace Business
{
    public class LeaveTypes : BaseBusiness, ILeaveTypes
    {
         private readonly Repository.ILeaveTypes _leavesRepo;

         public LeaveTypes()
        {
            _leavesRepo = new Repository.LeaveTypes();
        }

        //public IEnumerable<LeaveType> GetAll()
        //{
        //    return _leavesRepo.SelectAll();
        //}
    }
}
