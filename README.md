# Prueba Técnica 1 M5A

En esta prueba técnica, utilizando TDD (Desarrollo Guiado por Pruebas) y siguiendo buenas prácticas de código, se solicita realizar el siguiente ejercicio.

Se tiene una baldosería con una variedad de baldosas que pueden estar fabricadas con diferentes materiales y tener distintas formas (cuadrado, rectángulo, círculo). Los objetivos son los siguientes:

1. Calcular el área total y el área individual de una lista de baldosas.
2. Calcular el precio total y el precio individual de la lista de baldosas.
3. El costo se determina multiplicando el precio del material por el área de la baldosa.
4. El diseño debe ser extensible para permitir la adición de nuevas formas y precios, minimizando el impacto en el código existente.
5. Se debe incluir al menos tres formas diferentes (por ejemplo, cuadrado, rectángulo, círculo) y tres materiales diferentes (por ejemplo, cerámica, porcelana, piedra) para las baldosas.
6. Proporcionar una lista de ejemplo que contenga varias baldosas con diferentes formas, materiales y tamaños para probar la funcionalidad del sistema.

Para realizar la entrega forkear el repo y luego crear un PR con Nombre-Apellido-NumeroDeEstudiante

<hr>


# Agustin Do Canto (250230)

- No se llego a terminar el trabajo debido a la falta de tiempo.

- Se logro implementar la clase Tile y sus tests correspondientes, sin validaciones.

- Un resumen de los "Requerimientos" se puede encontrar en Requerimientos.txt

A continuación se explicará que se hubiese hecho de haber poseido el tiempo:

- Abstraccion de la clase Tile: Esto para asegurar la mantenibilidad del programa, si el dia de mañana se agregan métodos o atributos a la clase, simplemente se modificaria esta y se haria uso del polimorfismo en la clase TileCalculator (sistema) que se encargará de hacer todos los calculos correspondientes, las instancias de baldosas (tiles) seran las que guardaran los datos, mas no así la clase Tile, ya que es abstracta.

- Se agregaria un TileRepository (Repositorio de baldosas) esto a fin de separar la logica de busqueda, eliminación y guardado de la logica de cálculo para seguir con el principio "Single Responsability Principle" de los principios solid.

- Luego para los puntos se crearian instancia de los repositorios de la clase abtracta Tile en el TileCalculator para hacer los calculos correspondientes.

- Si se quisiera agregar materiales o baldosas nuevas en el futuro se podria simplemente cambiar el atributo material de la clase Tile, lo mismo para el area, forma y precio del material ya que la instancia de esta clase posee los atributos.