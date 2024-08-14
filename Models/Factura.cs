using System.ComponentModel.DataAnnotations;

namespace Celsia.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroFactura { get; set; }

        [Required]
        public DateTime FechaFacturacion { get; set; }

        [Required]
        public decimal MontoFacturado { get; set; }

        public decimal? MontoPagado { get; set; }
    }
}
