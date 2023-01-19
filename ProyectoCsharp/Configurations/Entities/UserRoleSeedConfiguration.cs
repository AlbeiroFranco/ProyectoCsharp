using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoCsharp.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "408aa945-3d84-4421-8342-7269ec64d949",
                    UserId = "8851a296-6b9b-481c-a00e-17f5a5b0bf00"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3f4631bd-f907-4409-b416-ba356312e659",
                    UserId = "ed55405b-f95f-472b-b881-2bcf426aca7d"
                }
            );
        }
    }
}