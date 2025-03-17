using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkPedido { get; set; }


        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalPedido { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public required int FkUsuarioRegistro { get; set; }

        // Relación uno a muchos con DetallePedido(no se agrega en las peticiones)
        public  ICollection<DetallePedido>? DetallesPedido { get; set; }
    }
}
