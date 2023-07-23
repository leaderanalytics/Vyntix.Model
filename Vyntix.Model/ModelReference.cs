namespace LeaderAnalytics.Vyntix.Model;

public partial class ModelReference 
{
    public int ID { get; set; }
    public int UserID { get; set; }
    [MaxLength(400)][Required]
    public string Name { get; set; }
    [MaxLength(1000)]        
    public string Notes { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<ObsModelReference> ObsModelReferences { get; set; }
    public virtual ICollection<QueryFilterModelRef> QueryFilterModelRefs { get; set; }

}
