using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.MigrationConfiguration;

public class RoleMigrationConfiguration : IEntityTypeConfiguration<Role>{

    public void Configure(EntityTypeBuilder<Role> builder){

        builder.Property(x => x.Id)
            .UseIdentityColumn();

         builder.HasMany(r => r.Users)
               .WithOne(u => u.Role)
               .HasForeignKey(u => u.RoleId); 

    }
}