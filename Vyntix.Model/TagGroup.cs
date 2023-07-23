namespace LeaderAnalytics.Vyntix.Model;

public class TagGroup : ProvidedEntity
{
    [MaxLength(200)][Required]
    public string Name { get; set; }
    public virtual ICollection<Tag> Tags { get; set; }
}
