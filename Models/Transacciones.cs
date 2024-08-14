using System.ComponentModel.DataAnnotations;

namespace Celsia.Models
{
    public class Transacciones
    {
        [Key]
        public int IdTransaccion { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        public int IdPlataformaPago { get; set; }

        public int IdCliente { get; set; }

        public int IdFactura { get; set; }

        public int IdEstadoTransaccion { get; set; }
    }
}
