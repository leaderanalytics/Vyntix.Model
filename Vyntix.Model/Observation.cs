namespace LeaderAnalytics.Vyntix.Model;

public class Observation
{
	public long ID { get; set; }
    public long VintageID { get; set; }
	public DateTime ObsDate { get; set; }
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
	
    public virtual Vintage Vintage { get; set; }
    public virtual ObsModelReference ObsModelReference { get; set; }
}

