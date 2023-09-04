namespace LeaderAnalytics.Vyntix.Model;

public partial class DataSet 
{
	public int ID { get; set; }
	public int? ParentID { get; set; }
	public int UserID { get; set; }
    public ReleaseStatus ReleaseStatus { get; set; }
    [MaxLength(400)][Required]
    public string DataSetName { get; set; }
	public string? Version { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }
	public AlignmentField AlignmentField { get; set; }
	public int ReportingFrequencyID { get; set; }
	public int FirstSeriesLeadPeriods { get; set; }
	public bool ExcludeRowsWithMissingValues { get; set; }
	public DateTime? LastModifiedDate { get; set; }
	public DateTime? LastRunDate { get; set; }
	public DateTime? LastDataUpdate { get; set; }
	public bool CheckForDataUpdates { get; set; }
    [MaxLength(100)]        
    public string? FilePath { get; set; }
    public bool OverwriteDataFile { get; set; } // if true will overwrite existing file if any. if false will make file name unique before writing.
    public string? Notes { get; set; }
    public virtual User User { get; set; }
    public virtual ReportingFrequency ReportingFrequency { get; set; }
    public virtual ICollection<DataSetSeries> DataSetSeries { get; set; }

    // Filter and Calculation settings
    public bool ApplyQueryFilterToAllDataSetSeries { get; set; }

    public ICollection<EntityQueryFilter> EntityQueryFilters { get; set; } // This property is ignored by EF.  There is no FK.
}
