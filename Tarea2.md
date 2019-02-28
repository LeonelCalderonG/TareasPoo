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

## ==2.3 Referencia al objeto actual.==  
La palabra clave "this" hace referencia a la instancia actual de la clase.

## ==2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
## Parámetros de métodos (Referencia de C#)
Los parámetros en declaración "in, ref, out" van al método con el nombre de valor. Este puede cambiar, pero al cambiarlo se perderá cuando se devuelva el control al procedimiento que se hizo.
Si se usa palabras claves de parámetros de metodo en la declaración puede ser modificado el comportamiento de éste.
1. params: específica que este parámetro toma un número aleatorio.
2. in: pasa por referencia, pero solo se lee por el método llamado.
3. ref: pasa por referencia y puede leerse o escrito por el método llamado.
4. out: pasa por referencia y se escribe por medio del método llamado.

## Params (Referencia de C#)
Puede especificar un parámetro de método que escoge un número aleatorio de argumentos.
También puede enviar una lista dividia en comas de tipo en que se específico o una matríz. También puede no hacerlo, en caso de no enviar nada la longitud de la lista lo tomará como 0.
Esto no permite parámetros adicionales después de la palabra clave en un método y solo permite la palabra clave en una declaración de método.
El tipo de parámetro debe de ser una matríz unidimensional, de lo contrario, se producirá un error de compilación.

## Out (Referencia de C#)
Se puede utilizar en dos contextos:
1. Como modificador de parámetro que se encarga de transferir un argumento a un método dandole      referencia que un valor.
2. Declarando el parámetro de tipo genérico para interfaces y delegados, lo cual da entender que    un parámetro es covariante. 

## Ref (Referencia de C#)
Indica un valor que paso por referencia. Se puede utilizar en cuatro contexto:
1. En una firma del método y llamado método para pasar un argumento a un método referido.
2. En una firma del método que devuelve un valor al creador de la llamada por medio de una          referencia.
3. En un cuerpo de miembro, para indicar que un valor devuelto se almacene de manera local como     referencia que el creador de la llamada intente modificarlo hasta de manera general.
4. En una declaración "Struct" para declararlo en "Ref struct".

## ==2.5 Constructores y destructores: declaración, uso y aplicaciones.==
## Utilizar constructores (Guía de programación de C#)
Los constructores son métodos de una clase que se ejecutan cuando se crea un objeto de cualquier tipo. Los constructores tienen el nombre similar de la clase y empiezan los miembros de datos del nuevo objeto.
Los constructores para los tipos struct son iguales a los constructores de clases, pero los tipos struct no pueden contener un constructor predeterminado porque el compilador otorga uno.
Tanto las clases como las structs pueden definir constructores que acepten parámetros. Se debe llamar a constructores que toman parámetros a través de una instrucción new o base. Las clases y las structs también pueden definir varios constructores.

Los constructores se pueden marcar como public, private, protected, internal o protectedinternal. Estos modificadores de acceso definen cómo los usuarios de la clase pueden construir la clase.

Un constructor se puede declarar como estático mediante la palabra clave static. Se llama automáticamente a los constructores estáticos de forma inmediata antes de que se tenga acceso a cualquier campo estático.

## ==2.6 Sobrecarga de métodos.==
Ver el ejercicio siguiente.

## ==2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.==
Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.
Debe de tener por lo menos las siguientes propiedades:
1. Valor
2. Color

La clase debe contar por lo menos con:
1. Dos constructores es sobrecargados.
2. Los operadores ==, <, > sobrecargados.
3. El uso de la palabra clave "this".

Utiliza tu clase dentro del método Main de tu programa, creando tres dados, arrojándolos e imprimiendo el mejor de ellos o si alguno es igual.