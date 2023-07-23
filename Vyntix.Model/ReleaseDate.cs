namespace LeaderAnalytics.Vyntix.Model;

public class ReleaseDate : ProvidedEntity
{
    public int ReleaseDataProviderID { get; set; }

    [MaxLength(100)][Required][IgnoreStringValidation]
    public string ReleaseNativeID { get; set; }
    
    public DateTime Release_Date { get; set; } 
    public virtual Release Release { get; set; }
    public virtual DataProvider ReleaseDataProvider { get; set; }
}
