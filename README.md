# Sistema De pesaje de Cajas de Huevo
Este sistema esta pensado para organizar cajas de huevo, guardando datos de relevacia del producto como lo son
* Peso
* Tipo de producto
* Parvada/Caseta
* Fecha de pesaje
Ademas de tener comunicacíon con una bascula e Impresora de etiquetas 

# Pre-requisitos
* Se debe tener instalado el lenguaje de c# y algun IDE ( se recomienda Visual Studio)
* Base de datos del proyecto ( Esta se puede encontrar en la sección de archivos del repo)
* Debemos contar con un cable Usb-Serial para la comunicación con nuestra bascula (El puerto esta por default en el COM5)
* Contar con una impresora de etiquetas ( De no ser posible, cualquier impresora funcionara solo que debemos adecuar la impresión al tamaño de la hoja)

# Instalación 
1.- Como primer paso debemos descargar todos los archivos que estan en el repo

2.- Despues debemos ubicarlos en un lugar puede ser en una carpeta en el escritorio

3.- Para poder acceder al codigo de la app debemos abrir el archivo con el nombre "Demo.sln"

4.- Al empezar a correr la app quisas marque el error de "COM5 no existe", como mencione ese puerto lo deje por default (Para cambiar el puerto se debe agregar 
    pero esa parte aun sigue en proceso de programación)

# Por programar 
Configuración de puerto realizada por el usuario 

Mejoras de interfaz con usuario

Hacerla una aplicación web programada en Go 

# Ventajas 
Para programadores que apenas van empezando a comunicar y enviar datos por medio de Usb - serial es un buen comienzo 
Ademas esta aplicación esta diseñada para que el operador haga su trabajo de manera eficiente ya que no requiere llevar un control,
ya que la aplicación guarda la información e imprime una etiqueta con la información del producto y ademas se imprime un QR con dicha información

Esta aplicación esta diseñada para una pantalla tactil


# Desarrollado en
La aplicación fue desarrollada en el lenguaje c# en el IDE Visual Studio 2022

La base de datos fue creada en SQL Server 18


# Autores 
- Sergio G. Rivera 

