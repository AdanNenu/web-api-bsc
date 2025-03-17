# web-api-bsc
Aplicación Web con Blazor, .Net. y EF.
Revisa los archivos entregables, en la carpeta "Entregables" de este proyecto:
BackLog
Archivos json
Analisis 
Diagrama ER

Para probar la aplicacion:

1. Abrir este proyecto desde .Net.
2. Migrar base de datos 
3. Poblar BD y probar servicios con postman (Dado que no comencé el desarrollo front-end)


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
	
	
	Enlaces de recursos en web (también están en la carpeta Entregables de este proyecto):
	Excel con analisis
	https://docs.google.com/spreadsheets/d/1NAmB0guYeZpY1_ntoG9RhCkeaeEA-i7zpmW8snEObIw/edit?usp=sharing
	
	Diagrama ER en LucidChar
	https://lucid.app/lucidchart/6ea304b6-d555-46ba-bc3d-ff62e009ba40/edit?viewport_loc=-56%2C241%2C1865%2C634%2C0_0&invitationId=inv_9eeca795-7294-41fc-b275-1233264ef327
	
	GGGGGGGGGGGGGGGrrrrrrrrrrrrrrraaaaaaaaaaaciiiiiiiiiiiiiiiiaaaaaaaaaaaassssssssssss


