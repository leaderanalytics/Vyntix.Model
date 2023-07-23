namespace LeaderAnalytics.Vyntix.Model;


public enum AppPermission               // Applies to User only or User + all DataProviders
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


    // Available - 1000


    // DataProviders & NativeFrequencies - 1500
    [Description("Can Create DataProviders")]
    CanCreateDataProviders = 1500 + 50000,
    // Edit and Delete permissions for DataProviders are DataProvider-specific and thus defined on the user's DataRole.


    // DataSets,  DataSetSeries,  ModelReferences - 2000


    [Description("Can View DataSets")]
    CanViewDataSets = 2000,
    [Description("Can View Query Filters")]
    CanViewQueryFilters = 2050,
    [Description("Can View Model References")]
    CanViewModelReferences = 3000,

    [Description("Can Modify DataSets")]
    CanModifyDataSets = 2000 + 50000,
    [Description("Can Modify Query Filters")]
    CanModifyQueryFilters = 2050 + 50000,
    [Description("Can Modify Model References")]
    CanModifyModelReferences = 3000 + 50000
}
