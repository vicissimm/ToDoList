using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.DataContext;

public class ToDoContext :  DbContext{
    
    public DbSet<User> Users {get;set;}
    public DbSet<TaskEntity> Tasks {get; set;}
    public DbSet<UserTask> UserTasks {get; set;}
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}