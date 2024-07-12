using Microsoft.EntityFrameworkCore;

namespace Persona.Models
{
    public class PersonaDBContext: DbContext
    {
        public PersonaDBContext(DbContextOptions option) : base(option)
        {
        }
        public DbSet<Persona> Personas { get; set; }
    }
}    
