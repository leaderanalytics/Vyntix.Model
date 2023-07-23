namespace LeaderAnalytics.Vyntix.Model;

public interface ITagged
{
    int AssociationDataProviderID { get; set; }
    string CacheKey { get; }
    Tag Tag { get; set; }
    DataProvider AssociationDataProvider { get; set; }
}
