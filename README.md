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

# Implementacion faltante

En el proyecto falto la parte de agregar materiales, solo se llego a implementar una clase material, de donde deberian heredar los materiales que se quieran agregar. Tambien lo que falto es la lista de ejemplo que contenga varias baldosas, se hizo las clases para tres formas diferentes (triangulo, rectangulo y circulo), pero no se llego a implementar la lista de ejemplo con valores ya definidos.

# Por que es extensible?

Es extensible ya que el agregar nuevas formas no impacta de ninguna manera en las ya existentes, y lo mismo pasaria con los materiales si estuviesen implementados. Se podria agregar una nueva forma o material sin tener que modificar el codigo ya existente, solo se deberia agregar una nueva clase que herede de la clase base correspondiente.