namespace LeaderAnalytics.Vyntix.Model;

public partial class SourceRelease
{
    [MaxLength(100)][Required][IgnoreStringValidation]
    public string SourceNativeID { get; set; }
    public int SourceDataProviderID { get; set; }

    [MaxLength(100)][Required][IgnoreStringValidation]
    public string ReleaseNativeID { get; set; }
    public int ReleaseDataProviderID { get; set; }

    public int AssociationDataProviderID { get; set; }

    public virtual DataProvider SourceDataProvider { get; set; }
    public virtual DataProvider ReleaseDataProvider { get; set; }

    public virtual DataProvider AssociationDataProvider { get; set; }

    public virtual Release Release { get; set; }
    public virtual Source Source { get; set; }
}
