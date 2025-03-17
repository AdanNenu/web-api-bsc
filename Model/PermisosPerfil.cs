using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    // Tabla intermedia para relación muchos a muchos
    public class PermisosPerfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkPermisosPerfil { get; set; }

        [Required]
        [ForeignKey("Perfil")]
        public int FkPerfil { get; set; }

        [Required]
        [ForeignKey("Permiso")]
        public int FkPermiso { get; set; }
    }
}
