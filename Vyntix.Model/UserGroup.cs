namespace LeaderAnalytics.Vyntix.Model;

public class UserGroup
{
    public int ID { get; set; }
    [MaxLength(400)]
    [Required]
    public string Name { get; set; }

    public virtual ICollection<UserAppRole> UserAppRoles { get; set; }
}
