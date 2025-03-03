# UsuarioAPI

Esta API esta echa para la creacion de Usuarios, Eliminar Usuarios, ademas de editar y buscar Usuarios, esta creada en Visual Estudio 2022 con .Net 8.0.

---------------------------------------------------------------------------------------------------------------------
Instalaciones necesarias: Para la ejecucion de este Proyecto se ocupa la instalacion de 3 diferentes paquetes NuGet
1- Microsoft.EntityFrameworkCore.
2- Microsoft.EntityFrameworkCore.Tools
3- Microsoft.EntityFrameworkCore.SqlServer

--------------------------------------------------------------------------------------------------------------------------

Creacion de Carpetas Necesarias: 

--Models: En esta Carpeta esta el archivo Usuario.cs define qué información tiene cada usuario en la aplicación:
Id: Un número único para identificar al usuario.

Nombre: El nombre del usuario (opcional).

Cedula: Su número de cédula.


--Context: En esta Carpeta esta el El archivo APIdbContext.cs se encarga de conectarse con la base de datos y guardar la información de los usuarios.
DbSet<Usuario> Usuarios: Representa la lista de usuarios guardados en la base de datos.

-- Controller: En la carpeta controller esta el archivo UsuariosController.cs maneja las solicitudes para agregar, ver, modificar o eliminar usuarios.
Acciones disponibles:
Ver todos los usuarios → GET /api/Usuarios

Ver un usuario específico → GET /api/Usuarios/{id}

Agregar un nuevo usuario → POST /api/Usuarios

Modificar un usuario → PUT /api/Usuarios/{id}

Eliminar un usuario → DELETE /api/Usuarios/{id}

---------------------------------------------------------------------------------------------------------------------------------

Conexion a la base de datos: 

Para realizar la conexio a la base de datos se hace desde el archivo "appsettings.json" donde se va agregar lo siguientes datos:
"ConnectionStrings": {
  "Connection": "Server=Nombre de la maquina ;Database=Nombre de la base de datos;Trusted_Connection=true; TrustServerCertificate=true;"
}

Despues de realizar esto desde la terminar se aplican los comandos para realizar la migracion a la base de datos
- Add-Migration AddTable Usuarios // Con este comando realizamos la migracion a la base de datos creando la tabla Usuarios.
- Update-database: Con este comando actualizamos la base de datos para que se vea reflejada la tabla en la base de datos.

  Despues de ejecutar estos comandos se crea la carpeta Migration y en ella un archivo que no se tiene que modificar.
