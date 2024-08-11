using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1.Models.Seeds
{
    public class DepartamentoSeeds : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                new Departamento { Id = 1, NomDep = "Recursos Humanos", Descripcion= "" },
                new Departamento { Id = 2, NomDep = "Tecnologia", Descripcion = "" },
                new Departamento { Id = 3, NomDep = "Ventas", Descripcion = "" }
                );
        
        }
    }
}
