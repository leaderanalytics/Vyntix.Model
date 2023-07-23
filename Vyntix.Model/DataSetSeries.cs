namespace LeaderAnalytics.Vyntix.Model;


public partial class DataSetSeries
{
    public int ID { get; set; }
    public int DataSetID { get; set; }
    public int Sequence { get; set; }
    [MaxLength(50)][Required]
    public string NativeID { get; set; }
    public int DataProviderID { get; set; }
    public int Transformation { get; set; }
    [MaxLength(200)][Required]
    public string ColumnHeader { get; set; }
    public bool ShowActualDate { get; set; }
    public bool ShowAlignmentComplement { get; set; }
    public bool IncludeRevisions { get; set; }
    public int LagCount { get; set; }
    public virtual DataSet DataSet { get; set; }
    public virtual Series Series { get; set; }
    public virtual DataProvider DataProvider { get; set; }
    public ICollection<EntityQueryFilter> EntityQueryFilters { get; set; }  // This property is ignored by EF.  There is no FK.
}
