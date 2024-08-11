using System.ComponentModel.DataAnnotations;

namespace Desafio1.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(100)]
        [Required]
        [Display(Name = "Departamento")]
        public string NomDep { get; set;}

        [Required(AllowEmptyStrings = true)]
        public string Descripcion { get; set;}  

        public ICollection<Empleado> Empleados { get; set;}


    }
}
