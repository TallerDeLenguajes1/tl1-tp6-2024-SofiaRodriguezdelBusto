// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("El valor de a es: "+a);
Console.WriteLine("El valor de b es: "+b);

Console.WriteLine("\n--------Ejercicio 1--------\n");
Console.WriteLine("Ingrese un numero");
string cadena = Console.ReadLine(); 
int num;
int resto;
int numInvertido = 0;
if(int.TryParse(cadena, out num))
{
   if(num > 0)
   {
      while(num != 0)
      {
        resto = num%10;
        num = num/10;
        numInvertido = numInvertido*10 + resto;
      }
   }
   Console.WriteLine($"El numero invertido es: {numInvertido}");
}
Console.WriteLine("No ha ingresado un numero");

Console.WriteLine("-------Ejercicio 4---------");
Console.WriteLine("Ingrese una cadena");
string cadenaUsu = Console.ReadLine();
int longitudCadena = cadenaUsu.Length;
Console.WriteLine($"La longitud de la cadena ingresada por el usuario es {longitudCadena}");
Console.WriteLine("Ingrese una segunda cadena");
string cadenaUsu2 = Console.ReadLine();
string concatenacion = cadenaUsu + cadenaUsu2;
Console.WriteLine($"La concatenacion de las cadenas ingresadas es: {concatenacion}");

Console.WriteLine("Extraemos una subcadena de la primera cadena ingresada\n");
string ini;
string longit;
int inicio;
int final;
do
{
    Console.WriteLine("Ingrese a partir de que posicion de la cadena principal quiere extraer la subcadena\n");
    ini = Console.ReadLine();
    Console.WriteLine("Ingrese la longitud que debe tener la subcadena\n");
    longit = Console.ReadLine();
} while (!int.TryParse(ini, out inicio) || !int.TryParse(longit, out final));
string subcadena = cadenaUsu.Substring(inicio-1, final);
Console.WriteLine($"La subcadena generada es \"{subcadena}\"\n");


Console.WriteLine("Hacemos la suma de numeros ingresados por el usuario y mostramos el resultado en un cadena de texto\n");

int controla; 
do
{
    Console.WriteLine("\n--------Calculadora--------\n");
    Console.WriteLine("\n1.SUMA");
    Console.WriteLine("\n2.RESTA");
    Console.WriteLine("\n3.MULTIPLICACION");
    Console.WriteLine("\n4.DIVISION");
    Console.WriteLine("\nElija la operacion que desea realizar: ");
    string operacion = Console.ReadLine(); 
    int op;
    string n1, n2;
    float num1, num2;
    if(int.TryParse(operacion, out op))
    {
      do
      {
         Console.WriteLine("\nIngrese el primer numero: ");
         n1 = Console.ReadLine(); 
         Console.WriteLine("\nIngrese el segundo numero: ");
         n2 = Console.ReadLine();
      } while (!(float.TryParse(n1, out num1) && float.TryParse(n2, out num2)));
      switch (op)
      {
         case 1:
               float suma = num1 + num2; 
               Console.WriteLine("\nLa suma de"+num1+ "y de"+num2+"es"+suma);
               break;
         case 2:
               float resta = num1 - num2;
               Console.WriteLine("\nLa diferencia de"+num1+ "y de"+num2+"es"+resta);
               break;
         case 3:
               float producto = num1*num2;
               Console.WriteLine("\nEl producto de"+num1+ "y de"+num2+"es"+producto);
               break;
         case 4:
               if(num2 != 0)
               {
                  float cociente = num1/num2;
                  Console.WriteLine("\nEl cociente entre"+num1+ "y"+num2+"es"+cociente);
               }else{
                  Console.WriteLine("\nNo se puede dividir en 0");
               }
               break;
      }
   }
   Console.WriteLine("\nIngrese 1 si desea continuar operando. Caso contrario ingrese 0");
    string control = Console.ReadLine();
    if(!int.TryParse(control, out controla))
    {
      controla = 1;
    }
}while (controla != 0);

Console.WriteLine("Recorremos la primera cadena con un foreach caracter por caracter e imprimimos cada uno: \n");
foreach (char caracter in cadenaUsu)
{
   Console.WriteLine(caracter);
}

Console.WriteLine("Buscar una palabra en una cadena");
Console.WriteLine("\nIngrese la palabra que desea buscar en la cadena: ");
string PalabraAbuscar = Console.ReadLine();
if (cadenaUsu.IndexOf(PalabraAbuscar, 0, cadenaUsu.Length) != -1)
{
   int start = 0;
   int pos = 0;
   int end = cadenaUsu.Length;
   int c = 0;
   Console.WriteLine("La palabra ingresada aparece en la cadena en la/s posicion/es:");
   while ((start <= end) && (pos > -1))
   {
      c = end - start;
      pos = cadenaUsu.IndexOf(PalabraAbuscar, start, c);
      if (pos == -1) break;
      Console.WriteLine(pos+1);
      start = pos+1;
   }
}else
{
   Console.WriteLine("La palabra ingresada no aparece en la cadena\n");
}

Console.WriteLine($"\nLa cadena en mayusculas es \"{cadenaUsu.ToUpper()}\"");
Console.WriteLine($"\nLa cadena en minusculas es \"{cadenaUsu.ToLower()}\"");

Console.WriteLine("Separador de cadenas");

Console.WriteLine("\nIngrese la cadena que va a separar");
string cadenaAseparar = Console.ReadLine();
string separador;
do
{
   Console.WriteLine("\nIngrese el separador de la cadena");
   separador = Console.ReadLine();
   if(!cadenaAseparar.Contains(separador))
   {
      Console.WriteLine("Separador no válido. No se encuentra en la cadena. Ingrese uno nuevamente");
   }
}while(!cadenaAseparar.Contains(separador));

string [] palabrasSeparadas = cadenaAseparar.Split(separador);

Console.WriteLine("\nLas cadenas generadas son:");
foreach(string cadenas in palabrasSeparadas)
{
   Console.WriteLine(cadenas);
}

Console.WriteLine("A partir de una cadena de texto se resuelve una operacion simple");

Console.WriteLine("\nIngrese la expresion a resolver\n");
string expresion = Console.ReadLine();
string [] operandos;
float operando1;
float operando2;
float respuesta = 0;
int error = 0;
if (expresion.Contains('+'))
{
   operandos = expresion.Split('+');
   if(float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      respuesta = operando1 + operando2;
   }else
   {
      error = 1; 
   }
} else if (expresion.Contains('-'))
{
   operandos = expresion.Split('-');
   if (float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      respuesta = operando1 - operando2;
   } else
   {
      error = 1; 
   }
} else if (expresion.Contains('*'))
{
   operandos = expresion.Split('*');
   if (float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      respuesta = operando1*operando2;
   }else
   {
      error = 1; 
   }
}else if (op.Contains('/'))
{
   operandos = expresion.Split('/');
   if (float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      if(operando2 != 0)
      {
         respuesta = operando1/operando2;
      }else
      {
         Console.WriteLine("\nNo se puede dividir en 0");
      }
   } else
   {
      error = 1;  
   }
}else
{
   Console.WriteLine("\nNo se ha ingresado ningun operador valido");
}
if (error == 1)
{
   Console.WriteLine($"Operando no válidos\n");
}else
{
   Console.WriteLine("El resultado de la expresion es", respuesta);
}

Console.WriteLine("-------Ejercicio 5---------");

Console.WriteLine("\nIngrese una dirección de una pagina web: ");
string direccionWeb = Console.ReadLine();
string formaValida = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
if (Regex.IsMatch(direccionWeb, formaValida, RegexOptions.IgnoreCase))
{
   Console.WriteLine("\nLa direccion web ingresada es valida.");
} else
{
   Console.WriteLine("\nLa direccion web ingresada NO es valida.");
}

Console.WriteLine("\nIngrese un mail: ");
string mail = Console.ReadLine();
string mailValido = @"^[a-z0-9._-]+@[a-z0-9.-]+\.[a-zA-Z]{2,}(.[a-z])?$";

if (Regex.IsMatch(mail, mailValido, RegexOptions.IgnoreCase))
{
   Console.WriteLine("\nLa direccion de mail ingresada es valida.");
}else
{
   Console.WriteLine("\nLa direccion de mail ingresada NO es valida.");
}