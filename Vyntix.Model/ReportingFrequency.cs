namespace LeaderAnalytics.Vyntix.Model;

public class ReportingFrequency 
{
    public int ID { get; set; }
    [MaxLength(200)][Required]
    public string Name { get; set; }
    public int AnnualFrequency { get; set; }
    public int MonthlyFrequency { get; set; }
    public int DailyFrequency { get; set; }
    public int MinuteFrequency { get; set; }
    public int Sequence { get; set; }
    public virtual ICollection<DataSet> DataSets { get; set; }
    public virtual ICollection<NativeFrequency> NativeFrequencies { get; set; }
}
