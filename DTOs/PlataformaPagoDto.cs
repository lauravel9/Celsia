using System.Collections.Generic;

namespace Celsia.DTOs
{
    public class PlataformaPagoDto
    {
        public int IdPlataformaPago { get; set; }
        public string NombrePlataforma { get; set; }

        public ICollection<TransaccionesDto> Transacciones { get; set; }
    }
}
