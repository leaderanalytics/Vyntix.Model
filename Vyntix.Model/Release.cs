namespace LeaderAnalytics.Vyntix.Model;

public partial class Release : ProvidedEntity
{
    public Release()
    {
        SourceReleases = new HashSet<SourceRelease>();
        ReleasesSeriess = new HashSet<ReleaseSeries>();
        ReleaseDates = new HashSet<ReleaseDate>();
    }

    [MaxLength(400)][Required]
    public string Name { get; set; }
    public bool IsPressRelease { get; set; }
    public Nullable<System.DateTime> RTStart { get; set; }
    public string Link { get; set; }
    public string Notes { get; set; }

    public virtual ICollection<SourceRelease> SourceReleases { get; set; }
    public virtual ICollection<ReleaseSeries> ReleasesSeriess { get; set; }
    public virtual ICollection<ReleaseDate> ReleaseDates { get; set; }
}
