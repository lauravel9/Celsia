using System.ComponentModel.DataAnnotations;

namespace Celsia.Models
{
    public class EstadoTransaccion
    {
        [Key]
        public int IdEstadoTransaccion { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionEstado { get; set; }
    }
}
