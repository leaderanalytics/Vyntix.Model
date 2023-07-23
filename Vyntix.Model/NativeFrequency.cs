namespace LeaderAnalytics.Vyntix.Model;

public class NativeFrequency : ProvidedEntity
{
    [MaxLength(200)][Required]
    public string Name { get; set; }
    public int ReportingFrequencyID { get; set; }

    public virtual ReportingFrequency ReportingFrequency { get; set; }
    public virtual ICollection<Series> Series { get; set; }
}
