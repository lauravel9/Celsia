using System.ComponentModel.DataAnnotations;

namespace Celsia.Models
{
    public class PlataformaPago
    {
        [Key]
        public int IdPlataformaPago { get; set; }

        [Required]
        [StringLength(100)]
        public string NombrePlataforma { get; set; }
    }
}
