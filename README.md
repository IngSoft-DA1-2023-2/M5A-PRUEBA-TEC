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


## Puntos no implementados:

Funcionalidad calcular area y precio total de lista de baldosas: podria implementarse facilmente utilizando una lList<TipoDeBaldosaDeseado> como lo son el Square y El Circle (parcialmente implementado), agregando esta lista a una clase la cual puede tener un metodo calcularAreaTotal() y calcularPrecioTotal(), dichos metodos pueden llamar al Calculo de precio de cada baldosa en particular y sumarlos, asi como el area individual de cada uno.


### Notas del diseno:

 - Se utilizo una clase abstracta "Shape" de la cual extienden el resto de tipos de baldosas como Circle y Square, este opcion permite agregar nuevos tipos de manera muy sencilla y con un impacto muy bajo.

 - Se utilizo una clase "MaterialHandler" para solicitar el costo de cada material asi como en un futuro, anadir nuevos materiales validos. Esta clase contiene una asociacion entre cada material y su precio.
 - Gracias a la implementacion de MaterialHandler el anadido de nuevos materiales no tiene casi impacto, y a su vez, descarga de responsabilidad a las otras clases en cuanto a los precios.

 ### Notas implementacion:

 - Se implemento por completo la clase Square y parcialmente la clase Circle dejando como ejemplo como seria el anadido de nuevas figuras.
 - La clase MaterialHandler esta parcialmente implementada dado que falta el metodo de agregar nuevos materiales, entre otros.







