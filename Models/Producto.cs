
using System.ComponentModel.DataAnnotations;

namespace ApiProductos.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(250)]
        public string Descripcion { get; set; } = string.Empty;

        [Range(0.01, 999999999)]
        public decimal Precio { get; set; }
    }
}
