using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1.Models.Seeds
{
    public class EmpleadoSeeds : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado
                {
                    Id = 1,
                    Nombre = "John Doe",
                    Nacimiento = DateOnly.Parse("1985-05-20"),
                    FecContr = DateOnly.Parse("2010-08-15"),
                    Salario = 50000,
                    IDDep = 1,
                    Descripcion = ""
                },
                new Empleado
                {
                    Id = 2,
                    Nombre = "Jane Smith",
                    Nacimiento = DateOnly.Parse("1990-03-10"),
                    FecContr = DateOnly.Parse("2015-01-25"),
                    Salario = 70000,
                    IDDep = 2,
                    Descripcion = ""
                },
                new Empleado
                {
                    Id = 3,
                    Nombre = "Mark Johnson",
                    Nacimiento = DateOnly.Parse("1982-11-22"),
                    FecContr = DateOnly.Parse("2012-06-18"),
                    Salario = 55000,
                    IDDep = 3,
                    Descripcion = ""
                },
                new Empleado
                {
                    Id = 4,
                    Nombre = "Emily Davis",
                    Nacimiento = DateOnly.Parse("1978-07-30"),
                    FecContr = DateOnly.Parse("2005-10-12"),
                    Salario = 75000,
                    IDDep = 1,
                    Descripcion = ""
                },
                new Empleado
                {
                    Id = 5,
                    Nombre = "Michael Brown",
                    Nacimiento = DateOnly.Parse("1995-12-05"),
                    FecContr = DateOnly.Parse("2020-04-15"),
                    Salario = 60000,
                    IDDep = 2,
                    Descripcion = ""
                }
                );
        
        }
    }
}
