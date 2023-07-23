namespace LeaderAnalytics.Vyntix.Model;

public class DataRolePermission
{
    public int DataRoleID { get; set; }
    public DataPermission DataPermission { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual DataRole DataRole { get; set; } 
}
