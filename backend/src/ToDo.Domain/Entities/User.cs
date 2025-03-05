namespace ToDo.Domain.Entities;

public class User{
    public long Id {get; set;}
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get;set;} = string.Empty;
    public string EmailAddress {get;set;} = string.Empty;
    public string PasswordHash {get;set;} = string.Empty;
    public long RoleId {get;set;}

    public Role Role {get; set;}
    public ICollection<UserTask> UserTasks {get;set;}
}