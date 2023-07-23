namespace LeaderAnalytics.Vyntix.Model;

public class QueryFilterDataProvider : ISequenced
{
    public int QueryFilterID { get; set; }
    public int DataProviderID { get; set; }
    public bool IsForecast { get; set; }

    public int Sequence { get; set; }   // Sequence only makes sense if CalcFunction is First.
    public virtual QueryFilter QueryFilter { get; set; }
    public virtual DataProvider DataProvider { get; set; }
}
