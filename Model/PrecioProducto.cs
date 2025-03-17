using EmpresaBSC.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    public class PrecioProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkPrecioProducto { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int FkProducto { get; set; }

       [Required]
        public decimal CostoSinIva { get; set; }
    }
}
