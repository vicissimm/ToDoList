using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.MigrationConfiguration;

public class UserMigrationConfiguration : IEntityTypeConfiguration<User>{

    public void Configure(EntityTypeBuilder<User> builder){

        builder.Property(x => x.Id)
            .UseIdentityColumn();

    }
}