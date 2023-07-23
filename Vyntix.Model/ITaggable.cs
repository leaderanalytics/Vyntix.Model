namespace LeaderAnalytics.Vyntix.Model;

public interface ITaggable
{
    ICollection<EntityTag> EntityTags { get; set; }
}
