### ¿Que diferencia podría generar no haber hecho las clases base abstractas?

Podria haber provocado problemas de acoplamiento, donde una de las clases depende de las otras, entonces al cambiar algo de una clase podria producir errores al compilar nuestro propgrama.

### ¿Podría haber utilizado clases abstractas en vez de las interfaces? ¿ Que consecuencias tendría?

Si podria haber usado clases abstractas en vez de interfaces, pero eso limitaria a las mismas acciones dentro de todas las clases hijas como base. En cambio, lo que se busca es que solamente esas clases implementen las metodos que se desean, pero pueden ser diferentes entre ellas.

### Explique cómo sabe .NET que implementación de un método heredado utilizar si se esta refiriendo a una instancia de la clase hija a través de la clase padre.

Ya que el .NET lee nuestro programa de abajo hacia arriba, o de mas pequeño a mas grande. Es decir, que al saber que esta heredando de la clase padre, también hereda todos los atributos y metodos de la clase padre, por lo que sabe que metodos puede contener nuestra clase hija.
