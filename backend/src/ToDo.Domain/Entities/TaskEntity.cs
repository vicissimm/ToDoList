namespace ToDo.Domain.Entities;

public class TaskEntity {
    public long Id {get; set;}
    public string Title {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public long StatusId {get;set;}

    public ICollection<UserTask> UserTasks {get; set;}
}