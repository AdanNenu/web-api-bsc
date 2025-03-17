using EmpresaBSC.Data;
using EmpresaBSC.Model;
using EmpresaBSC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaBSC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosRestBSCController : ControllerBase
    {

        private readonly CBSDbContext _context;

        public ServiciosRestBSCController(CBSDbContext context)
        {
            _context = context;
        }

        [HttpPost("registrarUsuario")]
        public IActionResult RegistrarUsuario(Usuario usuario) 
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpPost("registrarContrasena")]
        public IActionResult RegistrarContrasena(Contrasena contrasena)
        {
            _context.Contrasenas.Add(contrasena);
            _context.SaveChanges();
            return Ok(contrasena);
        }

        [HttpPost("registrarNombreProducto")]
        public IActionResult RegistrarNombreProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return Ok(producto);
        }

        [HttpPost("registrarExistenciaProducto")]
        public IActionResult RegistrarExistenciaProducto(Existencia existencia)
        {
            _context.Existencias.Add(existencia);
            _context.SaveChanges();
            return Ok(existencia);
        }

        [HttpPost("registrarPrecioProducto")]
        public IActionResult RegistrarPrecioProducto(PrecioProducto precioProducto)
        {
            _context.PreciosProducto.Add(precioProducto);
            _context.SaveChanges();
            return Ok(precioProducto);
        }

        [HttpPost("registrarPedido")]
        public IActionResult RegistrarPedido(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return Ok(pedido);
        }

        [HttpPost("registrarDetallePedido")]
        public IActionResult RegistrarDetallePedido([FromBody] List<DetallePedido> detallesPedido)
        {
            foreach (var detallePedido in detallesPedido)
            {
                _context.DetallesPedido.Add(detallePedido);
                _context.SaveChanges();
            }
           
            return Ok(detallesPedido);
        }

        [HttpGet("obtenerProducto/{id}")]
        public IActionResult ObtenerProducto(int id)
        {
            var producto = _context.Productos.Find(id);

            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpGet("obtenerExistencias")]
        public IActionResult ObtenerExistencias()
        {
            var existencias = _context.Existencias.ToList();
            return Ok(existencias);
        }

        [HttpGet("obtenerUsuario/{id}")]
        public IActionResult ObtenerUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }


        /// <summary>
        /// Esta operación es usada para validar los requisitos minimos de contraseña.
        /// Es usada cada vez que el usuario cambia o actualiza su contraseña.
        /// </summary>
        /// <param name="contrasena"></param>
        /// <returns>Si la contraseña cumple, se devuelve un http status 200, de
        /// lo contrario, lanza un erros 400 indicando puntualmente el requerimiento 
        /// que no cumple la contraseña.
        /// Debe cumplir: Minimo 6 carateres, minimo un número, minimo una letra.
        /// </returns>
        [HttpPost("validarContrasena")]
        public IActionResult ValidarContrasena([FromBody] string contrasena)
        {
            // Validación que no venga vacía o nulla
            if (string.IsNullOrEmpty(contrasena))
                return BadRequest("Contraseña no puede estar vacía");

            // Validar longitud mínima
            if (contrasena.Length < 6)
                return BadRequest("La contraseña debe tener al menos 6 caracteres");

            //Validar máxima 
            if (contrasena.Length > 30)
                return BadRequest("La contraseña debe tener como máximo 30 caractres");

            // Verificar que tenga al menos un número
            bool tieneNumero = contrasena.Any(char.IsDigit);
            if (!tieneNumero)
                return BadRequest("La contraseña debe contener al menos un número");

            // Verificar que tenga al menos una letra
            bool tieneLetra = contrasena.Any(char.IsLetter);
            if (!tieneLetra)
                return BadRequest("La contraseña debe contener al menos una letra");

            // Si pasa todas las validaciones
            return Ok("Contraseña válida");
        }

        [HttpGet("obtenerUsuarios")]
        public IActionResult ObtenerUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }
    }
}
