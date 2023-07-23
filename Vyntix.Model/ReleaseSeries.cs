namespace LeaderAnalytics.Vyntix.Model;

public partial class ReleaseSeries
{
    [MaxLength(100)][Required][IgnoreStringValidation]
    public string SeriesNativeID { get; set; }
    public int SeriesDataProviderID { get; set; }

    [MaxLength(100)][Required][IgnoreStringValidation]
    public string ReleaseNativeID { get; set; }
    public int ReleaseDataProviderID { get; set; }

    public int AssociationDataProviderID { get; set; }
    public virtual DataProvider ReleaseDataProvider { get; set; }
    public virtual DataProvider AssociationDataProvider { get; set; }

    public virtual Release Release { get; set; }
    public virtual Series Series { get; set; }
    
}
