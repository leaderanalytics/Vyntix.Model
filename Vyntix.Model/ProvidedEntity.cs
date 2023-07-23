namespace LeaderAnalytics.Vyntix.Model;

[NotMapped] // https://github.com/aspnet/EntityFrameworkCore/issues/11948 EF limitation.  Entity.Ignore(...) is not respected in DbContext.
public abstract class ProvidedEntity: INativeIdentity
{
    public int DataProviderID { get; set; }

    [MaxLength(100)][Required]
    public string NativeID { get; set; }

    public virtual DataProvider DataProvider { get; set; }
    public virtual string CacheKey { get => NativeID + DataProviderID.ToString(); }
    public bool IdentityEquals(INativeIdentity otherEntity) => otherEntity.NativeID == NativeID && otherEntity.DataProviderID == DataProviderID;
    public bool IsIdentityValid => !string.IsNullOrEmpty(NativeID) && DataProviderID > 0;
}

public class ProvidedEntityID : ProvidedEntity { }
