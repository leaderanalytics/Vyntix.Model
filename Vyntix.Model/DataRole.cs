namespace LeaderAnalytics.Vyntix.Model;

public class DataRole : ITemporal
{
    public int ID { get; set; }
    [MaxLength(200)][Required]
    public string Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual ICollection<UserDataRole> UserDataRoles { get; set; }
    public virtual ICollection<DataRolePermission> DataRolePermissions { get; set; }
}
