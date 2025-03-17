using EmpresaBSC.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    public class Existencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkExistencia { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int FkProducto { get; set; }

        [Required]
        public int CantidadDisponible { get; set; }
    }
}
