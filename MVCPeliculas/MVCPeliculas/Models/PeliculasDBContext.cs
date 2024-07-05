using Microsoft.EntityFrameworkCore;

namespace MVCPeliculas.Models
{
    public class PeliculasDBContext: DbContext
    {
        public PeliculasDBContext(DbContextOptions option): base(option) 
        {
        }
        public DbSet<pelicula> Peliculas { get; set; } 
    }
}
