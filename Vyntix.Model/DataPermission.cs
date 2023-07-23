
namespace LeaderAnalytics.Vyntix.Model;

public enum DataPermission // Applies to User + DataProvider
{
    // -------------------------------------------------------------------------------------------------------------------------------------------
    // -------------------------------------------------------------------------------------------------------------------------------------------
    // Do not create permissions that relate to modifying Users or Roles.  Those permissions are controlled by the IsAdmin flag on the User class.
    // -------------------------------------------------------------------------------------------------------------------------------------------
    // -------------------------------------------------------------------------------------------------------------------------------------------
    // "Modify" in a permission name is a shortcut for Create, Edit, and Delete
    
    
    // View Permission          < 50,000
    // Modify Permission        < 100,000
    // Delete Permission        > 100,000


    // Categories, RelatedCategories - 500

    [Description("Can Modify Categories and Related Categories")]
    CanModifyCategories = 500 + 50000,
    [Description("Can View Categories and Related Categories")]
    CanViewCategories = 510,
    // Available - 1000


    // DataProviders - 1500
    [Description("Can Edit DataProviders")]
    CanEditDataProviders = 1500 + 50000,
    [Description("Can View DataProviders")]
    CanViewDataProviders = 1510,
    [Description("Can Delete DataProviders")]
    CanDeleteDataProviders = 1550 + 100000,

    // Native Frequencies - 2000
    [Description("Can Modify Native Frequencies")]
    CanModifyNativeFrequencies = 2000 + 50000,
    [Description("Can View Native Frequencies")]
    CanViewNativeFrequencies = 2010,


    // Observations, ObsModelReferences, Vintages - 2500
    [Description("Can Modify Vintages")]
    CanModifyVintages = 2500 + 50000,
    [Description("Can View Vintages")]
    CanViewVintages = 2510,


    // Releases, Release Dates, Sources - 3000
    [Description("Can Modify Releases, Release Dates, Sources")]
    CanModifyReleases = 3000 + 50000,
    [Description("Can View Releases, Release Dates, Sources")]
    CanViewReleases = 3010,


    // Series, SeriesCategories, ReleaseSeries - 3500
    [Description("Can Modify Series, SeriesCategories, ReleaseSeries")]
    CanModifySeries = 3500 + 50000,
    [Description("Can View Series, SeriesCategories, ReleaseSeries")]
    CanViewSeries = 3510,

    // Tags TagGroups - 4000
    [Description("Can Modify Tags")]
    CanModifyTags = 4000 + 50000,
    [Description("Can View Tags")]
    CanViewTags = 4010,

    // SeriesTags - 4500
    [Description("Can Modify Category or Series Tags")]
    CanModifyCategoryOrSeriesTags = 4500 + 50000,
    [Description("Can View Tags")]
    CanViewCategoryorSeriesTags = 4510,
  
    // Download - 5000
    [Description("Can download data from the Data Provider")]
    CanDownload
}
