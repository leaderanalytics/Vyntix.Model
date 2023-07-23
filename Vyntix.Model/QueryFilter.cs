namespace LeaderAnalytics.Vyntix.Model;

public class QueryFilter
{
    public int ID { get; set; }
    [MaxLength(400)][Required]
    public string Name { get; set; }
    public int UserID { get; set; }

    // Historical Observations
    public bool IncludeHistoricalSeriesDataProvider { get; set; } // If checked, Vintages owned by the Series DataProvider will be included
    public bool IncludeHistoricalNullModelReferences { get; set; } // If checked Observations with no ModelReference will be included
    public bool IncludeHistoricalValues { get; set; }
    public bool HistoricalDataProvidersAreExcluded { get; set; }
    public bool HistoricalModelReferencesAreExcluded { get; set; }
    public GroupCalcFunction HistoricalGroupCalcFunction { get; set; }

    // Forecast Observations
    public bool IncludeForecastSeriesDataProvider { get; set; } // If checked, Vintages owned by the Series DataProvider will be included
    public bool IncludeForecastNullModelReferences { get; set; } // If checked Observations with no ModelReference will be included
    public ForecastFilter ActiveForecastFilter { get; set; }
    public ForecastFilter ExpiredForecastFilter { get; set; }
    public bool ForecastDataProvidersAreExcluded { get; set; }
    public bool ForecastModelReferencesAreExcluded { get; set; }
    public GroupCalcFunction ForecastGroupCalcFunction { get; set; }
    
    public int MinActiveForecastRange { get; set; } // (ObservationDate - RealTimeStart) must be greater than this number for forecast to be included.
    public int MaxActiveForecastRange { get; set; } // (ObservationDate - RealTimeStart) must be less than or equal to this number for forecast to be included.
    public int MinExpiredForecastRange { get; set; } // (ObservationDate - RealTimeStart) must be greater than this number for forecast to be included.
    public int MaxExpiredForecastRange { get; set; } // (ObservationDate - RealTimeStart) must be less than or equal to this number for forecast to be included.

    public virtual User User { get; set; }
    public virtual ICollection<QueryFilterDataProvider> QueryFilterDataProviders { get; set; }
    public virtual ICollection<QueryFilterModelRef> QueryFilterModelRefs { get; set; }
    public virtual ICollection<EntityQueryFilter> EntityQueryFilters { get; set; }
}
