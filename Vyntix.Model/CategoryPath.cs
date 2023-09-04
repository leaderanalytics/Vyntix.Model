namespace LeaderAnalytics.Vyntix.Model;

public class CategoryPath
{
    public string? SeriesNativeID { get; set; }
    public int SeriesDataProviderID { get; set; }

    public string? CategoryNativeID { get; set; }
    public int? CategoryDataProviderID { get; set; }

    public int NodeDataProviderID { get; set; }
    public string? Path { get; set; }
    public DataProvider NodeDataProvider { get; set; }
    public Node Node { get; set; }
}
