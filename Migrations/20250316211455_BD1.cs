using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaBSC.Migrations
{
    /// <inheritdoc />
    public partial class BD1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Existencias",
                columns: table => new
                {
                    PkExistencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkProducto = table.Column<int>(type: "int", nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Existencias", x => x.PkExistencia);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PkPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPedido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FkUsuarioRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PkPedido);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    PkPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePerfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionPerfil = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.PkPerfil);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PkPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePermiso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescripcionPermiso = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PkPermiso);
                });

            migrationBuilder.CreateTable(
                name: "PreciosProducto",
                columns: table => new
                {
                    PkPrecioProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkProducto = table.Column<int>(type: "int", nullable: false),
                    CostoSinIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciosProducto", x => x.PkPrecioProducto);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    PkProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClaveProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IvaProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FkUsuarioRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.PkProducto);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    PkUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkPerfil = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FkUsuarioRegistro = table.Column<int>(type: "int", nullable: false),
                    PerfilPkPerfil = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.PkUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfiles_PerfilPkPerfil",
                        column: x => x.PerfilPkPerfil,
                        principalTable: "Perfiles",
                        principalColumn: "PkPerfil");
                });

            migrationBuilder.CreateTable(
                name: "PermisosPerfil",
                columns: table => new
                {
                    PkPermisosPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkPerfil = table.Column<int>(type: "int", nullable: false),
                    FkPermiso = table.Column<int>(type: "int", nullable: false),
                    PerfilPkPerfil = table.Column<int>(type: "int", nullable: true),
                    PermisoPkPermiso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosPerfil", x => x.PkPermisosPerfil);
                    table.ForeignKey(
                        name: "FK_PermisosPerfil_Perfiles_PerfilPkPerfil",
                        column: x => x.PerfilPkPerfil,
                        principalTable: "Perfiles",
                        principalColumn: "PkPerfil");
                    table.ForeignKey(
                        name: "FK_PermisosPerfil_Permisos_PermisoPkPermiso",
                        column: x => x.PermisoPkPermiso,
                        principalTable: "Permisos",
                        principalColumn: "PkPermiso");
                });

            migrationBuilder.CreateTable(
                name: "DetallesPedido",
                columns: table => new
                {
                    PkDetallePedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkPedido = table.Column<int>(type: "int", nullable: false),
                    ClaveProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductoPkProducto = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CostoUnidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IvaAplicado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PedidoPkPedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPedido", x => x.PkDetallePedido);
                    table.ForeignKey(
                        name: "FK_DetallesPedido_Pedidos_PedidoPkPedido",
                        column: x => x.PedidoPkPedido,
                        principalTable: "Pedidos",
                        principalColumn: "PkPedido");
                    table.ForeignKey(
                        name: "FK_DetallesPedido_Productos_ProductoPkProducto",
                        column: x => x.ProductoPkProducto,
                        principalTable: "Productos",
                        principalColumn: "PkProducto");
                });

            migrationBuilder.CreateTable(
                name: "Contrasenas",
                columns: table => new
                {
                    PkContrasena = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUsuario = table.Column<int>(type: "int", nullable: false),
                    ContrasenaUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FkUsuarioRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrasenas", x => x.PkContrasena);
                    table.ForeignKey(
                        name: "FK_Contrasenas_Usuarios_FkUsuario",
                        column: x => x.FkUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "PkUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrasenas_FkUsuario",
                table: "Contrasenas",
                column: "FkUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPedido_PedidoPkPedido",
                table: "DetallesPedido",
                column: "PedidoPkPedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPedido_ProductoPkProducto",
                table: "DetallesPedido",
                column: "ProductoPkProducto");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosPerfil_PerfilPkPerfil",
                table: "PermisosPerfil",
                column: "PerfilPkPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_PermisosPerfil_PermisoPkPermiso",
                table: "PermisosPerfil",
                column: "PermisoPkPermiso");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilPkPerfil",
                table: "Usuarios",
                column: "PerfilPkPerfil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrasenas");

            migrationBuilder.DropTable(
                name: "DetallesPedido");

            migrationBuilder.DropTable(
                name: "Existencias");

            migrationBuilder.DropTable(
                name: "PermisosPerfil");

            migrationBuilder.DropTable(
                name: "PreciosProducto");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Perfiles");
        }
    }
}
