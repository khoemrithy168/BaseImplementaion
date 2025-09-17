namespace hrm_api.Dtos;

public class IdentityDTO
{
    public string FullName { get; set; }
    public string UserID { get; set; }
    public string EmployeeId { get; set; }
    public string Username { get; set; }
    public string UserType { get; set; }
    public string PlatformType { get; set; }
    public string StructureCode { get; set; }
    public string Country { get; set; }
    public string CostCenterCode { get; set; }
    public string Region { get; set; }

    public int GetIntUserId() => Convert.ToInt32(UserID);
}