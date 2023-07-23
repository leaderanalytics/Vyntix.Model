namespace LeaderAnalytics.Vyntix.Model;

public interface ISeriesMetaData : INativeIdentity
{
    string Name { get; set; }
    DataProvider DataProvider { get; set; }
    Nullable<DateTime> LastDataRequest { get; set; }
    string Units { get; set; }
    NativeFrequency NativeFrequency { get; set; }
    string SeasonalAdj { get; set; }
    bool IsDiscontinued { get; set; }
}
