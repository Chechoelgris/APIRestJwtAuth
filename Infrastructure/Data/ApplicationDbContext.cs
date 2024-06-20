using Core.Entities;
using Core.Entities.AuthEntities;
using Infrastructure.Data.Configurations;
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
        public DbSet<Carrera> Carreras { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Aplicar la configuración de los roles
            builder.ApplyConfiguration(new RolesConfiguration());

            // Aplicar la configuración de la entidad Carrera
            builder.ApplyConfiguration(new CarrerasConfiguration());


        }
    }
}
