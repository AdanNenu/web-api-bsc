using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    public class DetallePedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkDetallePedido { get; set; }

        [Required]
        [ForeignKey("Pedido")]
        public int FkPedido { get; set; }

        [Required]
        public required string ClaveProducto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal CostoUnidad { get; set; }

        [Required]
        public decimal IvaAplicado { get; set; }

        [Required]
        public decimal Subtotal { get; set; }
    }
}
