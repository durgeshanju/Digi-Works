using System;
using System.Collections.Generic;

namespace Business
{
    public interface ILeaves
    {
        IEnumerable<Models.Leaves> GetLeaveTrackerDetailsForGivenDateRange(DateTime startDate, DateTime endDate);
        IEnumerable<Models.Leaves> GetAll();
    }
}
