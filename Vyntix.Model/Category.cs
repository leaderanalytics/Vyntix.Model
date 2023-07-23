namespace LeaderAnalytics.Vyntix.Model;

public class Category : ProvidedEntity, ITaggable
{
    [MaxLength(400)][Required]
    public string Name { get; set; }
  
    public virtual ICollection<EntityTag> EntityTags { get; set; }
    public virtual ICollection<Node> Nodes { get; set; }
}
