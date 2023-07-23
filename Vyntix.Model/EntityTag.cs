namespace LeaderAnalytics.Vyntix.Model;

public class EntityTag : ITagged
{
    public TaggableType TaggableType { get; set; }

    [MaxLength(100)][Required]
    public string EntityNativeID { get; set; }
    public int EntityDataProviderID { get; set; }

    [MaxLength(100)][Required]
    public string TagNativeID { get; set; }
    public int TagDataProviderID { get; set; }

    public int AssociationDataProviderID { get; set; }

    public string CacheKey { get => EntityNativeID + EntityDataProviderID.ToString() + Tag.CacheKey + AssociationDataProviderID.ToString() + TaggableType.ToString(); }
    public virtual ITaggable Entity { get; set; }
    public virtual Tag Tag { get; set; }
    public virtual DataProvider EntityDataProvider { get; set; }
    public virtual DataProvider TagDataProvider { get; set; }
    public virtual DataProvider AssociationDataProvider { get; set; }
}
