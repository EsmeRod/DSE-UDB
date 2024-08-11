using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio1.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        
        [MinLength(3)]
        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        public DateOnly Nacimiento { get; set; }

        [Required]
        [Display(Name ="Fecha de Contratacion")]
        public DateOnly FecContr {  get; set; }

        [Required]
        [ForeignKey("Departamento")]
        public int? IDDep { get; set; }

        public Departamento? Departamento { get; set; }

        [Required]
        [Range(typeof(decimal), "0.000000000001", "79228162514264337593543950335")]
        public decimal Salario { get; set; }
       
        public string Descripcion { get; set; }


    }
}
