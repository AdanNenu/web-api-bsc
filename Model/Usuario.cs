using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresaBSC.Model
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkUsuario { get; set; }


        [Required]
        [ForeignKey("Perfil")]
        public required int FkPerfil { get; set; }


        [Required]
        [StringLength(100)]
        [Column("Nombre")]//Nombre de columna en BD cuando es diferente al atribbuto]
        public required string NombreUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public required string CorreoElectronico { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("Usuario")]
        public required int FkUsuarioRegistro { get; set; }

    }
}
