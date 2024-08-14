using System.Collections.Generic;

namespace Celsia.DTOs
{
    public class FacturaDto
    {
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public decimal MontoFacturado { get; set; }
        public decimal? MontoPagado { get; set; }

        public ICollection<TransaccionesDto> Transacciones { get; set; }
    }
}
