namespace LeaderAnalytics.Vyntix.Model;

public interface IPresentationDataSet
{
    //string TmpID { get; set; }
    bool IsDeleted { get; set; }
    bool IsModified { get; set; }
}
