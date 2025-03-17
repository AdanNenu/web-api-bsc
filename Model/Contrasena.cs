using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpresaBSC.Model
{
    public class Contrasena
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PkContrasena { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int FkUsuario { get; set; }

        // Se agrega entidad para obtener los datos más facils
        public  Usuario? Usuario { get; set; }

        [Required]
        [StringLength(50)] 
        public required string ContrasenaUsuario { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("Perfil")]
        public required int FkUsuarioRegistro { get; set; }

        
    }
}
