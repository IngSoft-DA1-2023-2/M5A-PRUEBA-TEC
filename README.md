# Prueba Técnica 1 M5A - Nicolás Russo Nro. 227286

## Instrucciones

### Agregar un nuevo material

Para agregar un nuevo material, se debe seguir los siguientes pasos:
1. Crear una nueva instancia de la clase `Material` en el archivo `Program.cs`.
2. Asignarle un nombre y un precio.

La justificación para tener una clase sola para los materiales y no implmentar polimorfismo ni otras estrategias es el principio **KISS**. Esta clase solo necesita guardar un nombre y un precio, por lo que no es necesario complicarla por ahora.

### Agregar una nueva baldosa

Para agregar una nueva baldosa, se debe seguir los siguientes pasos:
1. Crear una nueva clase que herede de `Tile` en el archivo `TileShop.cs`.
2. Agregar medidas necesarias.
2. Crear un constructor que reciba por lo menos un material. Adicionalmente se pueden agregar las medidas necesarias.
3. Implementar el método `CalculateAreaInMeters`.

Acá se optó por usar polimorfismo ya que facilita el uso y la implementación resulta limpia.
Las distintas baldosas son simples de agregar ya que la clase abstracta `Tile`, se puede extender fácilmente y ya implementa el método `CalculateCost` que no depende de la forma de la baldosa.

## Testing

Se utilizó TDD con MSTest en un proyecto separado `TileShop.Tests` para realizar las pruebas unitarias.

### Coverage

Se logró un coverage del 100% efectivo (excluyendo Program.cs) en el proyecto `TileShop`.

## Instrucciones

En esta prueba técnica, utilizando TDD (Desarrollo Guiado por Pruebas) y siguiendo buenas prácticas de código, se solicita realizar el siguiente ejercicio.

Se tiene una baldosería con una variedad de baldosas que pueden estar fabricadas con diferentes materiales y tener distintas formas (cuadrado, rectángulo, círculo). Los objetivos son los siguientes:

1. Calcular el área total y el área individual de una lista de baldosas.
2. Calcular el precio total y el precio individual de la lista de baldosas.
3. El costo se determina multiplicando el precio del material por el área de la baldosa.
4. El diseño debe ser extensible para permitir la adición de nuevas formas y precios, minimizando el impacto en el código existente.
5. Se debe incluir al menos tres formas diferentes (por ejemplo, cuadrado, rectángulo, círculo) y tres materiales diferentes (por ejemplo, cerámica, porcelana, piedra) para las baldosas.
6. Proporcionar una lista de ejemplo que contenga varias baldosas con diferentes formas, materiales y tamaños para probar la funcionalidad del sistema.

Para realizar la entrega forkear el repo y luego crear un PR con Nombre-Apellido-NumeroDeEstudiante
