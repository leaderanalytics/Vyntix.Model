namespace LeaderAnalytics.Vyntix.Model;

public class Tag : ProvidedEntity
{
    [MaxLength(200)][Required]
    public string Name { get; set; }
    [MaxLength(100)][Required]
    public string TagGroupNativeID { get; set; }
    public int TagGroupDataProviderID { get; set; }
    public DateTime DateCreated { get; set; }
    public int Popularity { get; set; }

    public virtual TagGroup TagGroup { get; set; }
    public virtual DataProvider TagGroupDataProvider { get; set; }
    public virtual ICollection<EntityTag> EntityTags { get; set; }

    public Tag() { }

    public Tag(Tag t)
    {
        NativeID = t.NativeID;
        DataProviderID = t.DataProviderID;
        Name = t.Name;
        TagGroupNativeID = t.TagGroupNativeID;
        TagGroupDataProviderID = t.TagGroupDataProviderID;
        DateCreated = t.DateCreated;
        Popularity = t.Popularity;
        TagGroup = t.TagGroup;
        DataProvider = t.DataProvider;
        TagGroupDataProvider = t.TagGroupDataProvider;
        EntityTags = t.EntityTags;
    }


    public Tag Clone()
    {
        return new Tag
        {
            NativeID = NativeID, // retain NativeID.  The name of the method is "Clone".  Caller is responsible.
            DataProviderID = DataProviderID,
            Name = Name,
            TagGroupNativeID = TagGroupNativeID,
            TagGroupDataProviderID = TagGroupDataProviderID,
            DateCreated = DateCreated,
            Popularity = Popularity,
            TagGroup = TagGroup,
            DataProvider = DataProvider,
            TagGroupDataProvider = TagGroupDataProvider,
            EntityTags = EntityTags,
        };
    }
}
