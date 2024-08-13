using System;

namespace Celsia.Models
{
    public class Transaccion
    {
        public int ID { get; set; }
        public DateTime FechaHora { get; set; }

        public int PlataformaId { get; set; }
        public PlataformaPago Plataforma { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public int EstadoId { get; set; }
        public EstadoTransaccion Estado { get; set; }
    }
}
