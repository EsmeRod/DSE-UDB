namespace MVCPeliculas.Models
{
    public class pelicula
    {
        public int id {  get; set; }
        public string Titulo { get; set; }
        public DateTime fechalanzaliento { get; set; }
        public string genero { get; set; }
        public decimal precio { get; set;}

    }
}
