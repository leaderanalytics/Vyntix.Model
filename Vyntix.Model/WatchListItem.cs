namespace LeaderAnalytics.Vyntix.Model;

public partial class WatchListItem  
{
	public int ID { get; set; }
    public int WatchListID { get; set; }
    [MaxLength(100)][Required][IgnoreStringValidation]
    public string NativeID { get; set; }
	public virtual Series Series { get; set; }
    public virtual WatchList WatchList { get; set; }
}
