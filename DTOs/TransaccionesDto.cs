namespace Celsia.DTOs
{
    public class TransaccionesDto
    {
        public int IdTransaccion { get; set; }
        public DateTime FechaHora { get; set; }

        public int IdPlataformaPago { get; set; }
        public PlataformaPagoDto PlataformaPago { get; set; }

        public int IdCliente { get; set; }
        public ClientesDto Clientes { get; set; }

        public int IdFactura { get; set; }
        public FacturaDto Factura { get; set; }

        public int IdEstadoTransaccion { get; set; }
        public EstadoTransaccionDto EstadoTransaccion { get; set; }
    }
}
