namespace LeaderAnalytics.Vyntix.Model;

public class UserDataRole : ITemporal
{
    public int UserID { get; set; }
    public int DataProviderID { get; set; }
    public int DataRoleID { get; set; }
    public DateTime? StartDate { get; set; }        // System maintained - perhaps by subscription / accounting
    public DateTime? EndDate { get; set; }          // System maintained - perhaps by subscription / accounting

    public virtual User User { get; set; }
    public virtual DataRole DataRole { get; set; }
    public virtual DataProvider DataProvider {get;set;}
}
