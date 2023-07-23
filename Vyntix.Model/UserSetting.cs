namespace LeaderAnalytics.Vyntix.Model;


public class UserSetting
{
    public int[] SelectedDataProviders { get; set; } // Readable DataProviders which are selected by default on program load.
    public bool SortPreviewVintagesAscending { get; set; }
    public bool SortPreviewObservationsAscending { get; set; }
}
