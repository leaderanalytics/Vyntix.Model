namespace LeaderAnalytics.Vyntix.Model;

public partial class User : IUser
{
    public User()
    {
        DataSets = new HashSet<DataSet>();
        UserDataRoles = new List<UserDataRole>(10);
        UserAppRoles = new List<UserAppRole>(10);
        Settings = new UserSetting();
    }

    public int ID { get; set; }
    [MaxLength(200)][Required]
    public string Name { get; set; }  // "SYSTEM" is reserved. 
    [MaxLength(100)]
    public string? Password { get; set; }
    [MaxLength(400)]
    public string? DefaultDataDirectory { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsAdmin { get; set; }
    public string? SerializedSettings { get; set; }      // json 
    public UserSetting Settings { get; set; }
    public virtual ICollection<UserDataRole> UserDataRoles { get; set; }
    public virtual ICollection<UserAppRole> UserAppRoles { get; set; }
    public virtual ICollection<DataProvider> DataProviders { get; set; }
    public virtual ICollection<DataSet> DataSets { get; set; }
    public virtual ICollection<WatchList> WatchLists { get; set; }
    public virtual ICollection<ModelReference> ModelReferences { get; set; }
    public virtual ICollection<QueryFilter> QueryFilters { get; set; }
}
