using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoCsharp.Configurations.Entities;

namespace ProyectoCsharp.Data
{
    public class ApplicationDbContext : IdentityDbContext<Empleado>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocation { get; set; }
    }
}