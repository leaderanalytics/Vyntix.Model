namespace LeaderAnalytics.Vyntix.Model;

public partial class Series : ProvidedEntity, ITaggable, ISeriesMetaData
{
    [MaxLength(100)][Required]
    public string Units { get; set; }
    [MaxLength(50)][Required]
    public string SeasonalAdj { get; set; }
    public System.DateTime? LastUpdated { get; set; }
    public int Popularity { get; set; }
    public DateTime? RTStart { get; set; }
    public string? Notes { get; set; }
    [MaxLength(100)]
    public string? SystemAttributes { get; set; }
    public DateTime? LastDataRequest { get; set; }
    [MaxLength(400)][Required]
    public string Name { get; set; }
    public bool IsDiscontinued { get; set; }
    public int NativeFreqDataProviderID { get; set; }
    public string? NativeFreqNativeID { get; set; }
    public virtual ICollection<Node> Nodes { get; set; }
    public virtual ICollection<ReleaseSeries> ReleaseSeries { get; set; }
    public virtual ICollection<Vintage> Vintages { get; set; }
    public virtual DataProvider NativeFreqDataProvider { get; set; }
    public virtual NativeFrequency NativeFrequency { get; set; }
    public virtual ICollection<EntityTag> EntityTags { get; set; }
    public virtual ICollection<WatchListItem> WatchListItems { get; set; }
}
