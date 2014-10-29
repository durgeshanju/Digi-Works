using System;
using System.Collections.Generic;

namespace Business
{
    public class Leaves : BaseBusiness, ILeaves
    {
        private readonly Repository.ILeaves _leavesRepo;

        public Leaves()
        {
            _leavesRepo = new Repository.Leaves();
        }
        public IEnumerable<Models.Leaves> GetLeaveTrackerDetailsForGivenDateRange()
        {
            //var list = _leavesRepo.SelectAll();
            return new List<Models.Leaves>
            {
                new Models.Leaves
                {
                    ApprovedById = 1,
                    EmployeeId = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Id = 1,
                    LeaveTypeId = 1
                }
            };
        }
       
        public DateTime GetStartDateForGivenCurrentDate(DateTime currentDate)
        {
            var startDate = currentDate.AddDays(-15);
            return startDate;
        }
        public DateTime GetEndDateForGivenCurrentDate(DateTime currentDate)
        {
            var endDate = currentDate.AddDays(+15);
            return endDate;
        }
       
    }
}
