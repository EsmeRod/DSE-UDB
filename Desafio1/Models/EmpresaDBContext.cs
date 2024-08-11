using Microsoft.EntityFrameworkCore;
using Desafio1.Models.Seeds;

namespace Desafio1.Models
{
    public class EmpresaDBContext: DbContext
    {
        public EmpresaDBContext(DbContextOptions option) : base(option)
        {
        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartamentoSeeds());
            modelBuilder.ApplyConfiguration(new EmpleadoSeeds());

        }
    }
}
