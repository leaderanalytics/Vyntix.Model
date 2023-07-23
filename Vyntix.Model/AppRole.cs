namespace LeaderAnalytics.Vyntix.Model;

public class AppRole : ITemporal
{
    public int ID { get; set; }
    [MaxLength(200)][Required]
    public string Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual ICollection<UserAppRole> UserAppRoles { get; set; }
    public virtual ICollection<AppRolePermission> AppRolePermissions { get; set; }
}
