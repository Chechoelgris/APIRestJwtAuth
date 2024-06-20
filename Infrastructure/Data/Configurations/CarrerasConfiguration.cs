using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class CarrerasConfiguration : IEntityTypeConfiguration<Carrera>
    {
        public void Configure(EntityTypeBuilder<Carrera> builder)
        {
            builder.ToTable("Carreras");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Descripcion)
                .HasMaxLength(500);

            // Seed de datos iniciales para carreras
            builder.HasData(
                new Carrera { Id = 1, Nombre = "Ingeniería de Sistemas", Descripcion = "Carrera enfocada en el desarrollo de sistemas informáticos." },
                new Carrera { Id = 2, Nombre = "Ingeniería Civil", Descripcion = "Carrera enfocada en la construcción y mantenimiento de infraestructuras." },
                new Carrera { Id = 3, Nombre = "Medicina", Descripcion = "Carrera enfocada en el estudio y práctica de la medicina." },
                new Carrera { Id = 4, Nombre = "Psicología", Descripcion = "Carrera enfocada en el estudio del ser humano y su mundo psiquico." }
            );
        }
    }
}
