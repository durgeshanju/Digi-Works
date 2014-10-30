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

        public IEnumerable<Models.Leaves> GetAll()
        {
            return _leavesRepo.SelectAll().ToModel();
        }

        public IEnumerable<Models.Leaves> GetLeaveTrackerDetailsForGivenDateRange(DateTime startDate, DateTime endDate)
        {
            return _leavesRepo.SelectAll().ToModel();
        }
       
        private DateTime GetStartDateForGivenCurrentDate(DateTime currentDate)
        {
            var startDate = currentDate.AddDays(-15);
            return startDate;
        }
        private DateTime GetEndDateForGivenCurrentDate(DateTime currentDate)
        {
            var endDate = currentDate.AddDays(+15);
            return endDate;
        }
       
    }
}
