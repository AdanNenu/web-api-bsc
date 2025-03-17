# web-api-bsc
Aplicación Web con Blazor, .Net. y EF.

Para probar la aplicacion:

1. Abrir este proyecto desde .Net.
2. Migrar base de datos 
3. Poblar BD y probar servicios con postman


Para migrar la base de datos:
	Asegurarse de temer instalado
	a) Nuguets Microsoft.EntityFrameworkCore.SqlServer y Microsoft.AspNetCore.Identity.EntityFrameworkCore
	b) SQL server

	Abrir View Other Windows Package Management Console y ejecutar lo siguiente:
	# Crear migración
	Add-Migration PrimeraMigracion

	# Actualizar base de datos
	Update-Database

	Finalmente, abre SQL server y confirma que la BD se creó.
	Si tienes algun problema, puedes revisar la cadena de conexion en appsettings.json.


Para poblar la BD y probar los servicios rest (Ejecuta la app para levantar la API):
	Desde postman, selecciona collecciones y despues "import". 
	Carga los archivos json, cada archivo corresponde a una coleccion y a su vez a un servicio. Ejecula las colecciones en el siguiente orden:
	1. RegistrarUsuario
	2. RegistrarContrasena
	3. RegistrarNombreProducto
	4. RegistrarPedido
	5. RegistrarExistenciaProducto
	6. RegistrarPrecioProducto
	7. ObtenerUsuario
	8. ValidarContrasena
	
	Puedes usar el servicio de obtener, para validar los usuarios registrados, pero también
	puedes consultarlo directamente en tu base de datos de SQL. 
	
	GGGGGGGGGGGGGGGrrrrrrrrrrrrrrraaaaaaaaaaaciiiiiiiiiiiiiiiiaaaaaaaaaaaassssssssssss


