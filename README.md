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


Q: Como implementaría Circle?
R: En mi codigo se implementa cada Shape en una clase distinta. Aunque se podria hacer todo adentro de Shape. Por comodidad lo elegi asi,
de manera de tener todo separado para hacer la practica sin confundirme. 
Para crear Circle seguiria el procedimiento que hice para el resto de formas. Crear una clase Circle, con las propiedades
de una forma ciruclar (Radio), y luego overridearia el calculo de area de Shape.

Q: Qué faltó?
R: Faltaron checkeos en las variables de cada shape. En Square hay una public Side, pero en otros hay un atributo privado.
Hay inconsistencia en ese sentido adentro del código, como si lo hicieran personas diferentes.

También revisaría, como implementé las formas. Siento que es la mejor forma, porque hay una clase general
que son las formas de la que se hereda un método común. Lo cual tiene mucho sentido y viendo que estamos
en programación orientada a objetos, es lo mas tirado a la realidad.

Además la mantenibilidad en este sentido mejora al igual que el acoplamiento. Porque cada clase se afecta por su propio lado.