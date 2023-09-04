namespace LeaderAnalytics.Vyntix.Model;

public interface ICategoryChild
{
    string? ParentNativeID { get; set; }
    int? ParentDataProviderID { get; set; } 
}
