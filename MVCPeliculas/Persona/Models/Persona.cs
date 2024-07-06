namespace Persona.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FecNac { get; set; }
        public string Direccion { get; set; }
        public string mail { get; set; }    


    }
}
