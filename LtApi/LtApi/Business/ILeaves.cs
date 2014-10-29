using System.Collections.Generic;

namespace Business
{
    public interface ILeaves
    {
        IEnumerable<Models.Leaves> GetLeaveTrackerDetailsForGivenDateRange();
    }
}
