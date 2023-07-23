namespace LeaderAnalytics.Vyntix.Model;

public class NativeIdentity : INativeIdentity
{
    public string NativeID { get; set; }
    public int DataProviderID { get; set; }

    public NativeIdentity() { }

    public NativeIdentity(string nativeID, int dataProviderID)
    {
        NativeID = nativeID;
        DataProviderID = dataProviderID;
    }
}
