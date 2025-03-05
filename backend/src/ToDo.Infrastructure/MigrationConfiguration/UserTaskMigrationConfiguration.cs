using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.MigrationConfiguration;

public class UserTaskMigrationConfiguration : IEntityTypeConfiguration<UserTask>{

    public void Configure(EntityTypeBuilder<UserTask> builder){

        builder.Property(x => x.Id)
            .UseIdentityColumn();

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserTasks)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Task)
            .WithMany(x => x.UserTasks)
            .HasForeignKey(x => x.TaskId);    

    }
}