using System;

namespace Celsia.Models
{
    public class Factura
    {
        public int ID { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public decimal MontoFacturado { get; set; }
        public decimal MontoPagado { get; set; }
    }

}