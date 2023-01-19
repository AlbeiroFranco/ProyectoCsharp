using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoCsharp.Constants;

namespace ProyectoCsharp.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "408aa945-3d84-4421-8342-7269ec64d949",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "3f4631bd-f907-4409-b416-ba356312e659",
                    Name = Roles.user,
                    NormalizedName = Roles.user.ToUpper(),
                }
            );
        }
    }
}