namespace LeaderAnalytics.Vyntix.Model;

public partial class DataProvider
{
    public DataProvider()
    {
        Categories = new HashSet<Category>();
        Sources = new HashSet<Source>();
        Series = new HashSet<Series>();
    }

    public int ID { get; set; }
    public int UserID { get; set; }
    [MaxLength(400)][Required]
    public string Name { get; set; }
    public int SystemID { get; set; } // Zero if DataProvider is user defined. Greater than zero if system maintained i.e. Fred, Quandl.
    public bool Active { get; set; }
    [MaxLength(50)][Required]
    public string BackgroundColor { get; set; }
    [MaxLength(50)][Required]
    public string ForegroundColor { get; set; }
    [MaxLength(400)]
    public string? IconFileName { get; set; }
    public DownloadResult LastDownloadResult { get; set; }
    public DateTime? LastDownloadDate { get; set; }
    public string? Setting1 { get; set; }
    public string? Setting2 { get; set; }
    public string? Setting3 { get; set; }
    public string? Setting4 { get; set; }
    public string? Setting5 { get; set; }

    public virtual User User { get; set; }
    public virtual ICollection<Category> Categories { get; set; }

    public virtual ICollection<Source> Sources { get; set; }
    public virtual ICollection<Series> Series { get; set; }
    public virtual ICollection<Series> Series_NativeFreqDataProvider { get; set; }
    public virtual ICollection<Release> Releases { get; set; }
    public virtual ICollection<NativeFrequency> NativeFrequencies { get; set; }
    public virtual ICollection<DataSetSeries> DataSetSeries { get; set; }
    
    public virtual ICollection<WatchList> WatchLists { get; set; }

    public virtual ICollection<Vintage> Vintages_Series { get; set; }
    public virtual ICollection<Vintage> Vintages_Vintage { get; set; }

    public virtual ICollection<EntityTag> EntityTags_Entity { get; set; }
    public virtual ICollection<EntityTag> EntityTags_Tag { get; set; }
    public virtual ICollection<EntityTag> EntityTags_Associations { get; set; }

    public virtual ICollection<Tag> Tags { get; set; }
    public virtual ICollection<Tag> Tags_Groups { get; set; }

    public virtual ICollection<TagGroup> TagGroups { get; set; }
    public virtual ICollection<UserDataRole> UserDataRoles { get; set; }

    public virtual ICollection<SourceRelease> SourceReleases_Sources { get; set; }
    public virtual ICollection<SourceRelease> SourceReleases_Releases { get; set; }
    public virtual ICollection<SourceRelease> SourceReleases_Associations { get; set; }

    public virtual ICollection<ReleaseSeries> ReleaseSeries_Releases { get; set; }
    public virtual ICollection<ReleaseSeries> ReleaseSeries_Associations { get; set; }

    public virtual ICollection<ReleaseDate> ReleaseDate_ReleaseDates { get; set; }
    public virtual ICollection<ReleaseDate> ReleaseDate_Releases { get; set; }

    public virtual ICollection<Node> Nodes { get; set; }
    public virtual ICollection<Node> Node_Parents { get; set; }
    public virtual ICollection<Node> Node_Entities { get; set; }

    public virtual ICollection<QueryFilterDataProvider> QueryFilterDataProviders { get; set; }
}
