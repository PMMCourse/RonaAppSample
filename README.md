# RonaAppSample

Mediante está aplicación vamos a realizar un simulacro de examen. Se van a indicar diferentes cambios que hay que introducir 
dentro del código. Estos cambios deben ir incluidos de todos los comentarios que se vean convenientes para darle sentido 
y explicación a cada uno de los cambios. 

Por favor, todos esos comentarios deben ir precedidos de la siguiente manera.

```
//EjerX: 
```

Siendo la X el número de ejercicio. También se recomienda que para cada ejercicio se realice en un **commit** en concreto, 
marcando el ejercicio al que van relacionado.

Vamos a indicar 10 ejercicios. Para ser más concreto se plantean diferentes valores de nota para cada uno de ellos, para 
indicar el diferente peso de los mismos, debido a su complejidad. No todos los ejercicios tienen una respuesta correcta, 
es por ello, **que el uso de comentarios para justificar las acciones al respecto, son especialmente importantes**

**Importante** hacer este ejercicio como si se tratara de un examen, intentar no copiaros los unos de otros e intentar hacerlo
de manera individual, para que os sirva como aprendizaje para la prueba real.

## Ejer 1 (0,5)

Ejecuta el código, pruebalo. Soluciona cualquier error que pueda aparecer en el mismo. 

## Ejer 2 (0.5)
 
Crea el método *SetValue* para poder asignar y notificar dentro del setter del ViewModel

## Ejer 3 (1.5)

Crea una nueva vista, con su respectivo ViewModel con una pantalla de login en la que se autentifique un usuario con una 
contraseña *hardcodeada* Haz que esa navegación vaya a la pantalla principal.

## Ejer 4 (0.5)

Crea un modelo usuario, que tenga como propiedades usuario, contraseña y permisos. Estos permisos serán: 

- Agregar
- Visualizar
- Ambos

## Ejer 5 (1.5)

Crea un servicio de login, con al menos **tres** usuarios, que tengan los diferentes permisos. Consume ese servicio en la 
pantalla de Login, esos permisos deben modificar la pantalla principal. Haciendo desaparecer el botón de agregar o el de 
visualizar o mostrar ambos dependiendo del permiso aceptado.

## Ejer 6 (1)

Mejora la usabilidad dentro de la pantalla de agregar. El campo de virus puede mejorarse. 

## Ejer 7 (0.5)

Añade un nuevo virus a la lista. ¿Crees que sería interesante crear un servicio para solventar este problema?

## Ejer 8 (1)

Actualiza todas las llamadas de servicio a un patrón *async-await*

## Ejer 9 (1)

Añade la posibilidad de buscar pacientes en la pantalla de búsqueda. 

## Ejer 10 (2)

Añade al modelo paciente una nueva propiedad que sea tiempo de registro, haz que se inicialice a 0 
está debe ser de tipo TimeSpan, muestra ese nuevo valor dentro del listado que los pacientes, haz que ese campo vaya 
actualizando el tiempo conforme vayan pasando los minutos.
