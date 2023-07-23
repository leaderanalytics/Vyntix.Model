namespace LeaderAnalytics.Vyntix.Model;

public class EntityQueryFilter
{
    public int QueryFilterID { get; set; }
    public int EntityID { get; set; }
    public QueryFilterEntityType EntityType { get; set; }
    public bool IsActive { get; set; }
    public virtual QueryFilter QueryFilter { get; set; }
}
