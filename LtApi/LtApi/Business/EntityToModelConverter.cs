namespace Business
{
    public class EntityToModelConverter
    {
        public static Models.Leaves ToModel(DataAccess.Leaves source)
        {
            return new Models.Leaves
            {
                ApprovedById = source.ApprovedById,
                EmployeeId = source.EmployeeId,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                Id = source.Id,
                LeaveTypeId = source.LeaveTypeId
            };
        }
    }
}
