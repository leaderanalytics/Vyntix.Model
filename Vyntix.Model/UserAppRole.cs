namespace LeaderAnalytics.Vyntix.Model;

public class UserAppRole : ITemporal
{
    public int UserID { get; set; }
    public int UserGroupID { get; set; }            // The UserGroup to which the role applies, not the UserGroup the user belongs to.
    public int AppRoleID { get; set; }
    public DateTime? StartDate { get; set; }        // System maintained, perhaps by subscription / accounting
    public DateTime? EndDate { get; set; }          // System maintained, perhaps by subscription / accounting

    public virtual User User { get; set; }
    public virtual UserGroup UserGroup { get; set; }
    public virtual AppRole AppRole { get; set; }
}
