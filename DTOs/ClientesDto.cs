using System.Collections.Generic;

namespace Celsia.DTOs
{
    public class ClientesDto
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public ICollection<TransaccionesDto> Transacciones { get; set; }
    }
}
