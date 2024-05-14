Respuestas:
En el caso del Material, cree un enum, donde se van agregando los nuevos materiales
y definiendo el costo del mismo en MaterialCost. Decidi crear solamente un enum, el unico
dato importante que debe tener un material es el costo por baldosa del mismo.

En el caso del tipo de la baldosa cree una baldosa padre, en la cual creo nuevas baldosas 
hijas que heredan de la misma. Tome esta desicion ya que las baldosas tienen distinta forma
de calcular el area dependiendo del tipo de la misma, cuadrada, circular, etc. Esto permite
extensibilidad ya que se pueden crear nuevas baldosas libremente sin afectar las demas

Cuando hice el refactor de las baldosas y los materiales no me dio el tiempo para modificar los test para
que acepten la nueva estructura.

Letra
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
