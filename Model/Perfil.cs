using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaBSC.Model
{
    public class Perfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkPerfil {  get; set; }

        [Required]
        public required string NombrePerfil { get; set; }

        [Required]
        [StringLength (200)]
        public required String DescripcionPerfil { get; set; }

        // Relación uno a muchos con Usuarios, obligatoria para validar permisos por usuario
        public required ICollection<Usuario> Usuarios { get; set; }

        // Relación muchos a muchos con Permisos, obligatoria para validar permisos por usuario
        public required ICollection<PermisosPerfil> PermisosPerfil { get; set; }

    }
}
