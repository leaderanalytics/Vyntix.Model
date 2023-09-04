namespace LeaderAnalytics.Vyntix.Model;

public partial class Source : ProvidedEntity
{
    [MaxLength(400)][Required]
    public string Name { get; set; }
    [MaxLength(400)]
	public string? Link { get; set; }
	public string? Notes { get; set; }
	public virtual ICollection<SourceRelease> SourceReleases { get; set; }

    public Source()
    {
        SourceReleases = new HashSet<SourceRelease>();
    }
}
