# Aplicacion TripsAPI


## INSTALACIÓN:
### Desarrollado en visual studio 2022
###  1. Instalar NET CORE 6.0 ó superior
###  2. Instalar sql server 2019 ó superior
-  Crear base de datos "tripsdb" vacía en la base de datos con el usuario local.
###  3. Abrir Los proyectos contenidos en la carpeta "TripsAPI"
-  Abrir el proyecto TripsRestAPI
-  Agregar en el mismo proyecto TripsDb 

###  4. Configuración de conexión
-  Cambiar el contenido de "DeveloperEnv" (está en la línea 10) en el archivo "appsettings.json". Se debe reemplazar el valor a los correspondientes de la base de datos local

###  5. Creacion de tablas y ejecución del servicio.
- En la consola de comandos de visual studio, verificar que el proyecto principal sea "TripsDb", ya que allí se encuentran los modelos.
- En la consola de comandos de visual studio, ejecutar el comando: add-migration "primera migracion"
- El proyecto principal debe ser TripsRestAPI (es diferente a la consola).
- Seleccionar iniciar el proyecto con la opción "Https", esto iniciará el servicio y desplegará la página del API
- Como consecuencia de esta ejecución, las tablas "Flight" y "Transport" se han creado en la base de datos.







