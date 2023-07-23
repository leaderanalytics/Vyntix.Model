namespace LeaderAnalytics.Vyntix.Model;

public class ObsModelReference
{
    public long ObservationID { get; set; }  // This is the primary key.  We have a one to one or one to zero relationship with observation so we use ObservationID as the pk here.
    public int ModelReferenceID { get; set; }   //Allows a user to optionally link an observation (usually a forecast) to a Model.  This allows us to a) track the origin of the forecast and b) further qualify observations with same vintage, dataprovider, and obs date.

    public virtual ModelReference ModelReference { get; set; }
    public virtual Observation Observation { get; set; }
}
