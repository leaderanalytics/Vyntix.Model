namespace LeaderAnalytics.Vyntix.Model;

public class Vintage
{
	public long ID { get; set; }
    [MaxLength(50)][Required]
	public string NativeID { get; set; } 
    public int SeriesDataProviderID { get; set; }
    public int DataProviderID { get; set; }
    [MaxLength(400)][Required]
    public string Name { get; set; }
    public string? Notes { get; set; }
    public DateTime VintageDate { get; set; }
    public ReleaseStatus ReleaseStatus { get; set; }

    public virtual Series Series { get; set; }
    public virtual DataProvider SeriesDataProvider { get; set; }
    public virtual DataProvider DataProvider { get; set; }
    public virtual ICollection<Observation> Observations { get; set; }

    public Vintage()
    {
    }

    public Vintage(FredVintage dto)
    {
        VintageDate = dto.VintageDate;
        Name = dto.VintageDate.ToString("d");
    }
}


