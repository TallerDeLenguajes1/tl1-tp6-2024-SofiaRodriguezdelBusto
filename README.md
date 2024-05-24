Punto 4

¿String es una tipo por valor o un tipo por referencia?
String es un tipo por referencia, pero es aceptado como si fuera por valor. Por eso tiene un alias en ambos casos, pero en realidad es siempre el mismo tipo por referencia.

¿Qué secuencias de escape tiene el tipo string?
' : comilla simple
" : comilla doble
\ : barra diagonal inversa
\0 : NULL
\a : alerta
\b : retroceso (permite borrar el último caracter)
\f : avance de página
\n : nueva línea (salta a la línea siguiente)
\r : retorno de carro (va al principio de la línea)
\t : tabulación horizontal
\v : tabulación vertical

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Si se utiliza el $ antes de una cadena, quiere decir que es una cadena interpolada. La interpolación de cadenas significa que puedes utilizar dentro de la misma variables definidas con anterioridad en tu código, y el compilador JIT se encargara de reemplazar las mismas por los valores respectivos, en tiempo de ejecución. Se utiliza la sintáxis "${}". Por otro lado, si se utiliza el carácter "@" antes de una cadena de texto se creará una cadena de texto literal. Esto significa que el texto dentro de la cadena será interpretado literalmente, lo que incluye mantener los caracteres de escape sin interpretar.

Punto 5
Expresiones regulares
Las expresiones regulares son patrones que se utilizan para hacer coincidir combinaciones de caracteres en cadenas. Son una secuencia de caracteres que conforma un patrón de búsqueda. Se utilizan principalmente para la búsqueda de patrones de cadenas de caracteres u operaciones de sustituciones.

¿Funcionan únicamente en C#?
No, existen en todos los principales lenguajes de programación, como por ejemplo Pyhton JavaScript, Ruby, etc.

¿En qué casos le parecen útiles? Enuncie al menos 3.
Las expresiones regulares son útiles para una amplia gama de tareas que incluyen actualización de información, operaciones de búsqueda y reemplazo y formato de texto. Algunos ejemplos específicos son:

Cuando queremos buscar una palabra en un documento de Word y reemplazarla por otra, tal vez porque se nos olvidó quew llevaba tilde o algo similar.
Cuando queremos verificar que la información ingresada por el usuario tiene un formato válido para lo que se está pidiendo, como por ejemplo que un nombre no contenga números.
Para saber a que país/provincia corresponde un número de celular.
¿Cómo se hace uso de estas en C#?
C# nos proporciona un motor o librería la cual permite comprobar expresiones regulares. Cuando utilizamos expresiones regulares dentro de C# lo hacemos utilizando el tipo Regex.