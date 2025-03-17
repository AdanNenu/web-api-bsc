using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    public class Permiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkPermiso { get; set; }

        [Required]
        [StringLength(100)]
        public required string NombrePermiso { get; set; }

        [Required]
        [StringLength(500)]
        public required string DescripcionPermiso { get; set; }

        // Relación muchos a muchos con Perfiles
        public required ICollection<PermisosPerfil> PermisosPerfil { get; set; }
    }
}
