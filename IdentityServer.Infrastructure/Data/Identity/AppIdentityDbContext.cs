using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Infrastructure.Data.Identity
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = Constants.Roles.User, NormalizedName = Constants.Roles.User.ToUpper() });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = Constants.Roles.Admin, NormalizedName = Constants.Roles.Admin.ToUpper() });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = Constants.Roles.Doctor, NormalizedName = Constants.Roles.Doctor.ToUpper() });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = Constants.Roles.Patient, NormalizedName = Constants.Roles.Patient.ToUpper() });
        }
    }
}
