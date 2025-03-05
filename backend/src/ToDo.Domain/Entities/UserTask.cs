namespace ToDo.Domain.Entities;

public class UserTask{
    public long Id {get; set;}
    public long UserId {get; set;}
    public long TaskId {get; set;}

    public User User{get; set;}
    public TaskEntity Task {get; set;}
}