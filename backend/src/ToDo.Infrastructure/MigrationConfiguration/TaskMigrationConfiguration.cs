using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.MigrationConfiguration;

public class TaskMigrationConfiguration : IEntityTypeConfiguration<TaskEntity>{

    public void Configure(EntityTypeBuilder<TaskEntity> builder){

        builder.Property(x => x.Id).UseIdentityColumn();

    }
}