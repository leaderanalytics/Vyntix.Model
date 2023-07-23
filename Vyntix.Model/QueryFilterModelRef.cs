namespace LeaderAnalytics.Vyntix.Model;

public partial class QueryFilterModelRef 
{
    public int QueryFilterID { get; set; }
    public int ModelReferenceID { get; set; } 
    public bool IsForecast { get; set; }

    public virtual QueryFilter QueryFilter { get; set; }
    public virtual ModelReference ModelReference { get; set; }
}
