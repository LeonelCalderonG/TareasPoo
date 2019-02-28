## ==2.1 Declaración de clases: atributos, metodos, encapsulamiento.==

## Clases y estructuras (Guia de programacion de C#)
Las clases y las estructuras son constructores en .NET Framework. Estos constructores son estructuras de datos que usan el encapsulamiento en los datos y sus comportamientos lógicos.
Una estructura sirve para crear objetos durante su ejecución. Por ejemplo si se usa primero la variable "P" de tipo persona, será el objeto de la clase persona sin importar las cantidades que se pueden crear.
Se le llama clase cuando se esta haciendo referencia a un objeto en el que se trabajará. Cuando nosotros hacemos un objeto estamos asignandole una referencia, y ya después cuando se realizan los cambios se refleja los resultados en ambas variables y esto es porque ambas variables contienen los mismos datos.
Una estructura es un valor que contiene datos reales de una variable en el que se trabajará, cuando se le agrega una nueva variable a la estructura simplemente se copia. Después de cuando se realicen los cambios de una copia no afectará a la otra copia.
Hablando en general, las clases son el comportamiento de datos que se modifican después de ser creado un objeto en una clase, por lo que las estructuras son perfectas para la estrctura de datos diminutos que permiten no modificarlos despues de que se haya creado la estructura.

## Encapsulamiento
Hace referencia como el primer pilar en programación orientado a objetos. Según su principio nos dice que una clase se puede especificar a un punto en el que se puede acceder usuarios para escribir fuera de la clase.

## Miembros
Todo lo que sea miembro, propiedades, metodos, etc se declaran dentro de un tipo, lo cual se les llama miembros de tipo. En C# no se puede hacer variables globales ni métodos. Aparte todas estas características deben declararse dentro de una clase.

## Accesibilidad
Es muy importante limitar la accesibilidad hasta que el código del cliente pueda ser previsto por el. Puede usar modificadores de acceso para especificar que tipos y miembros puedan tener acceso al código de cliente.

## Herencia
Se le llama así cuando una clase base deriva sus atributos a otra clase sin contar con sus métodos.
Las clases tambien se le pueden considerar como abstractas, por lo que uno o muchos métodos no tienen una implementación. Estas pueden servir como clases bases para otras clases que proporcionan la implementación que les hace falta. También se les puede llamar "Sealed" para evitar que otras clases hereden atributos de ellas.

## Interfaces
Heredar de una interfaz se le considera que el tipo implementa todos los métodos definidos en la interfaz.

## Tipos genéricos
Se definen con uno o varios parámetros de tipo. El código de cliente proporciona un tipo cuando se crea una instancia del tipo.

## Tipos estáticos
Las clases pueden declararse como "Static". Puede contener solo miembros estáticos y no se puede crear una instancia de ellos con new.

## Tipos anidados
Una clase se puede anidar dentro de otra clase o estructura.

## Tipos parciales
Puede definirse una clase en un archivo de codificación y otra en una indepediente.

## Inicializadores de objeto
Permite crear instancias de objetos de alguna clase y de una colección de objetos y ejecutarlos.

## Tipos anónimos
Son aquellos cuando en alguna situación no es conveniente o necesario crear una clase con un nombre.

## Metodos de extensión
Permite extender una clase sin que se ocupe crear una clase derivada por medio de la creación de un tipo independiente con métodos que se llaman igual al principal.

## Variables locales con asignación implícita de tipos
Dentro de alguna clase, puede usar tipos implícitos para indicar al compilador que determine el tipo correcto en el tiempo de compilación. 

## ==2.2 Instanciación de una clase.==
El operador "New" tiene como tarea cumplir con la función de malloc.
El operador "New" tiene como dos funciones que se utilizan en Programación Orientado a Objetos (POO), lo cual son los siguientes:
1. Se utiliza para crear instancias de tipo anónimos.
2. Permite invocar un constructor predeterminado para tipos de valor.