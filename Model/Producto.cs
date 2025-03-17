using EmpresaBSC.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaBSC.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkProducto { get; set; }

        [Required]
        [StringLength(100)]
        public required string NombreProducto { get; set; }

        [Required]
        public required string ClaveProducto { get; set; }

        [StringLength(500)]
        public required string Descripcion { get; set; }

        [Required]
        public decimal IvaProducto { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("Usuario")]
        public required int FkUsuarioRegistro { get; set; }

    }

    

    
}