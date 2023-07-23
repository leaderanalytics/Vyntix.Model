namespace LeaderAnalytics.Vyntix.Model;

public interface IUser: ITemporal
{
    int ID { get; set; }
    string Name { get; set; }
    string Password { get; set; }
    string DefaultDataDirectory { get; set; }
    bool IsAdmin { get; set; }
    string SerializedSettings { get; set; }     
    ICollection<UserDataRole> UserDataRoles { get; set; }
    ICollection<UserAppRole> UserAppRoles { get; set; }
    UserSetting Settings { get; set; }
}
