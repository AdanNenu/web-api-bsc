using EmpresaBSC.Model;
using EmpresaBSC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaBSC.Data
{
    public class CBSDbContext : DbContext
    {
        //Contexto de BD para interactuar con Entiti Framework.
        public CBSDbContext(DbContextOptions<CBSDbContext> options)
            : base(options)
        {
        }

        // Representa las tablas en la base de datos
        // Permite realizar consultas, inserciones, actualizaciones y eliminaciones
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contrasena> Contrasenas { get; set; }
        public DbSet<DetallePedido> DetallesPedido { get; set; }
        public DbSet<Existencia> Existencias { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PermisosPerfil> PermisosPerfil { get; set; }
        public DbSet<PrecioProducto> PreciosProducto { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}