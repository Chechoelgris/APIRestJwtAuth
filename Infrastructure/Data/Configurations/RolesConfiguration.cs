using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "GestorInstitucion",
                    NormalizedName = "GESTORINSTITUCION"
                },
                new IdentityRole
                {
                    Name = "Profesor",
                    NormalizedName = "PROFESOR"
                },
                new IdentityRole
                {
                    Name = "Estudiante",
                    NormalizedName = "ESTUDIANTE"
                }
            };
            builder.HasData(roles);
        }
    }
}
