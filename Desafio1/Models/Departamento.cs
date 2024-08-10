using System.ComponentModel.DataAnnotations;

namespace Desafio1.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(100)]
        [Required]
        public string NomDep { get; set;}
        public string Descripcion { get; set;}  

        public ICollection<Empleado> Empleados { get; set;}


    }
}
