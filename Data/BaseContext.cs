using Microsoft.EntityFrameworkCore;
using Celsia.Models;


namespace Celsia.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext>options) : base(options){
        }
        
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<PlataformaPago> PlataformasPago { get; set; }
        public DbSet<EstadoTransaccion> EstadosTransaccion { get; set; }
    }
}