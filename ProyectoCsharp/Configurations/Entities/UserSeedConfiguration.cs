using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoCsharp.Data;

namespace ProyectoCsharp.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            var hasher = new PasswordHasher<Empleado>();
            builder.HasData(
                new Empleado
                {
                    Id = "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                    Email = "jose@test.com",
                    NormalizedEmail = "JOSE@TEST.COM",
                    NormalizedUserName = "JOSE@TEST.COM",
                    UserName = "jose@test.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                },
                new Empleado
                {
                    Id = "ed55405b-f95f-472b-b881-2bcf426aca7d",
                    Email = "user@test.com",
                    NormalizedEmail = "USER@TEST.COM",
                    NormalizedUserName = "USER@TEST.COM",
                    UserName = "user@test.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                }
            );
        }


    }
}