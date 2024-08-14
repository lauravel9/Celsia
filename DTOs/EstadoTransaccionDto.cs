using System.Collections.Generic;

namespace Celsia.DTOs
{
    public class EstadoTransaccionDto
    {
        public int IdEstadoTransaccion { get; set; }
        public string DescripcionEstado { get; set; }

        public ICollection<TransaccionesDto> Transacciones { get; set; }
    }
}
