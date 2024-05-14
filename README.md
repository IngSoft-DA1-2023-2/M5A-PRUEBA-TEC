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

El método para crear una baldoza consiste en crearla indicando la forma y el material en el constructor, luego se llama al metodo CalculateTotalPrice que
se encarga de llamar a los metodos respectivos de las propiedades de la balzoda para calcular el precio total, luego en el main puedo agregar varias baldozas
con el metodo AddTile y cuando lo quiera llamar al CalculateTotal que se va a encargar de sumar todos los precios por area de cada baldoza y retornarlo.

Si se quisiera agregar una forma nueva o un material nuevo, basta con crear una clase que implemente las interfaces correspondientes,
en el caso de una forma puedo crear una clase Circle, la cual implementa IShape, le declaro sus atributos, como el radio, e implemento la función de la interfaz CalculateArea, luego para un material funciona igual, implemento IMaterial y hago el return del CalculatePrice como desee, en este caso es un número hardcodeado