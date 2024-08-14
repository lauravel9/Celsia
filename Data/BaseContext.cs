using Microsoft.EntityFrameworkCore;
using Celsia.Models;

namespace Celsia.Data
{
    public class BaseContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<PlataformaPago> PlataformasPago { get; set; }
        public DbSet<EstadoTransaccion> EstadosTransaccion { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Transacciones> Transacciones { get; set; }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }
    }
}
