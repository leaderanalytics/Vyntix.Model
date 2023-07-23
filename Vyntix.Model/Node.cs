namespace LeaderAnalytics.Vyntix.Model;

public class Node : ProvidedEntity  
{
    public int ParentDataProviderID { get; set; }   // Not nullable.  Two or more DataProviders can have root nodes.
    [MaxLength(100)] 
    public string ParentNativeID { get; set; }      // Not required


    public int EntityDataProviderID { get; set; }
    [MaxLength(100)][Required]
    public string EntityNativeID { get; set; }
    public NodeEntityType EntityType { get; set; }              // Table where NativeID/DataProviderID can be found. 

    public bool IsRelatedToParent { get; set; }                 // If true this Node points to an entity that is related to it's parent - not a child.
    public int Sequence { get; set; }

    public virtual Node ParentNode { get; set; }
    public virtual ICollection<Node> ChildNodes { get; set; }
    
    public virtual ProvidedEntity Entity { get; set; }  
    public virtual DataProvider EntityDataProvider { get; set; }
    public virtual DataProvider ParentDataProvider { get; set; }
}
