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



4- El diseno permite extender la funcionalidad de el programa para incluir nuevas formas, materiales y precios. Lo que se debe de hacer para lograrlo es, incluir la nueva forma en el enum Size, incluir el nuevo material en el enum Material. Luego de debe agregar una entrada en el Hashmap MaterialPrices de la clase PriceCalculator con el par {Material, precio en float}.
Finalmente para incluir la nueva forma se debe de crear una clase por ejemplo "CircularTile" que herede de la clase Tile, agregue los atributos necesarios para calcular su area, por ejemplo para este caso seria float _radius, y por ultimo hacer un override de la funcion CalculateArea implementando el calculo de la misma.

Aclaracion, solo pude implementar 1 forma de las 2 que se pedian como ejemplo por falta de tiempo.
