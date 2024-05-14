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

# Extensibilidad
Para agregar una nueva forma de baldosa, tenemos a nuestro alcance la clase abstracta Tile que ya tiene definido un material y un metodo CalculateArea() que se encarga de calcular su area segun la logica de negocios de la nueva baldosa. En definitiva, habria que crear una nueva clase que herede de Tile e implemente CalculateArea.

Luego, para los materiales, contamos con un Enum que define los materiales existentes y la clase TileCalculator que se encarga de calcular el precio de las baldosas y lleva un diccionario que mapea materiales y costos.

Entonces, para agregar un nuevo material, basta con agregar una entrada al enum y luego cuando se instancie la clase TileCalculator habria que pasarle un diccionario que mapee los materiales existentes a sus respectivos precios.

# Mantenibilidad
Cada clase y método tiene una responsabilidad clara y bien definida, lo que facilita la comprensión del código y su mantenimiento. Por ejemplo, la clase Tile se encarga de representar una baldosa y calcular su área, mientras que la clase TileCalculator se encarga de calcular el costo total de una lista de baldosas. 

En resumen, la solución es extensible porque permite la adición de nuevas formas de baldosas y nuevos materiales con mínimas modificaciones al código existente y a mi parecer es mantenible porque cada parte del código tiene una responsabilidad clara y bien definida.