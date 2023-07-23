namespace LeaderAnalytics.Vyntix.Model;

public class WatchList
{
    public int ID { get; set; }
    [MaxLength(100)][Required]
    public string Name { get; set; }
    public int UserID { get; set; }
    public int DataProviderID { get; set; }
    public virtual ICollection<WatchListItem> WatchListItems { get; set; }
    public virtual User User { get; set; }
    public virtual DataProvider DataProvider { get; set; }

    public WatchList() => WatchListItems = new List<WatchListItem>();
}
