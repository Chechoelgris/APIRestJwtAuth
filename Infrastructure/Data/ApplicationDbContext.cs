using Core.Entities.AuthEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name="Admin",
                    NormalizedName="ADMIN"
                },
                 new IdentityRole
                {
                    Name="Client",
                    NormalizedName="CLIENT"
                },
                  new IdentityRole
                {
                    Name="User",
                    NormalizedName="USER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
