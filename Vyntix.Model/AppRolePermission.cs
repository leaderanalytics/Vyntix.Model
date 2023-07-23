namespace LeaderAnalytics.Vyntix.Model;

public class AppRolePermission
{
    public int AppRoleID { get; set; }
    public AppPermission AppPermission { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual AppRole AppRole { get; set; } 
}
