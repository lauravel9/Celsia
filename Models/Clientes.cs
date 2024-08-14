using System.ComponentModel.DataAnnotations;

namespace Celsia.Models
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string CorreoElectronico { get; set; }
    }
}
