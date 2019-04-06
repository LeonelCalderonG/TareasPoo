## 1.1. ¿Qué valores imprimen las lineas (1) y (2)?
R= Imprimen 10 y 10.
## 1.2. Redefine el método Display en el espacio indicado, una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?
R= Imprimen 10 y 15.
## 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
R= Virtual.
## 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
R= El punto C, y es porque en las Clases Base se utiliza Virtual lo cual utilizamos a un método que queremos obtener mediante los atributos que se les asignamos que en este caso es el nombre y nosotros queremos que nos muestre el nombre de cada músico, mientras que en las Clases Derivadas se utiliza Override.
## 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
R= Override porque se esta implementando los atributos de la Clase Base hacia las Clases Derivadas.
## 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
R= Porque es un método abstracto, se utilizarán llaves cuando los métodos que se estan creando sean virtuales, osea que queremos que se muestren en pantalla o su uso en construcciones posteriores.
## 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
R= Nos mostraría error en cada método Afina() de las Clases Derivadas porque nos mostraría que aún no se ha implementado ningún acción dentro de los métodos.