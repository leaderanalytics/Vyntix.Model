namespace LeaderAnalytics.Vyntix.Model;

public enum DataProviderSystemID
{
    UserDefined = 0,
    FRED = 1,
    Quandl = 2
}

public enum Frequency
{
    FiveYears = 0,
    Annually = 1,
    TwiceAnnually = 2,
    Quarterly = 3,
    Monthly = 4,
    EveryTwoWeeks = 5,
    Weekly = 6,
    Daily = 7
}

public enum AlignmentField
{ 
    [Description("Observation Date")]
    ObservationDate,
    [Description("Vintage Date")]
    VintageDate
}

public enum Transformation
{ 
    [Description("None - As reported by provider")]
    None = 0,
    [Description("Percent change from prior period")]
    PercentChange = 1,
    [Description("Difference from prior period")]
    Difference = 2,
}



public enum CategoryRelationshipType
{
    ChildCategory,
    RelatedCategory,
    SeriesCategory
}

public enum AccessModifier
{
    [Description("Public")]
    Public,     // Anyone can view and edit
    [Description("Protected")]
    Protected,  // Anyone can view, only owner or Admin can edit (
    [Description("Private")]
    Private     // Only owner or Admin can view or edit.
}





public enum ReleaseStatus
{ 
    [Description("Under construction")]
    InProgress,
    [Description("Submitted for review")]
    UnderReview,
    [Description("Approved for release")]
    ApprovedNotReleased,
    [Description("Released")]
    Released
}

public enum GroupCalcFunction
{ 
    [Description("Do not group")]
    None,
    [Description("Mean")]
    Mean,
    [Description("Median")]
    Median,
    [Description("Max")]
    Max,
    [Description("Min")]
    Min,
    [Description("First")]
    FirstRanked // Based on Priority in FilterRank.  Makes sense only when FilterFunction is OnlySelected otherwise first user may be any user.
    // Not necessary to add Data Provider as option here - if the user wants the data provider they can specify Data Provider as the first (and, possibly, only) user in the ranking
    // With regard to forecasts, This enum only resolves observations within a vintage.  So a value of "Most Recent" makes no sense because "Most Recent" is a comparison of different vintages.
}

public enum ForecastFilter
{ 
    All,
    Range,
    MostRecent,  // Observation with Min(ObservationDate - RealTimeStart) for each user will be selected
    None
}

public enum DownloadResult
{
    Aborted,        // User shuts down or computer powers off or premature shut down for external reason with no exception thrown
    Faulted,        // An exception is thrown and caught
    Canceled,       // User cancels and download gracefully terminates
    Successful
}

public class DatabaseProviderName
{
    public const string Unknown = "Unknown";
    public const string MSSQL = "MSSQL";
    public const string SQLite = "SQLite";
    public const string MySQL = "MySQL";
}

public enum TaggableType
{
    Category,
    Series
}

public enum NodeEntityType
{
    Category,
    Series
}

public enum QueryFilterEntityType
{
    DataSet,
    DataSetSeries
}
