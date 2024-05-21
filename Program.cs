// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

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

Console.WriteLine("\n--------Ejercicio 3--------\n");

int controla; 
do
{
    Console.WriteLine("\n--------Calculadora--------\n");
    Console.WriteLine("\n1.VALOR ABSOLUTO");
    Console.WriteLine("\n2.CUADRADO");
    Console.WriteLine("\n3.RAIZ CUADRADA");
    Console.WriteLine("\n4.SENO");
    Console.WriteLine("\n5.COSENO");
    Console.WriteLine("\n6.PARTE ENTERA");
    Console.WriteLine("\nElija la operacion que desea realizar: ");
    string operacion = Console.ReadLine(); 
    int op;
    string n;
    float numero;
    do
    {
      Console.WriteLine("\nIngrese el numero: ");
      n = Console.ReadLine(); 
    } while (!float.TryParse(n, out numero));

    if(int.TryParse(operacion, out op))
    {
       switch (op)
       {
        case 1:
               float valorAbs = Math.Abs(numero); 
               Console.WriteLine($"\nEl valor absoluto es {valorAbs}");
               break;
        case 2:
               double cuadrado = numero * numero;
               Console.WriteLine($"\nEl cuadrado delnumero es {cuadrado}");
               break;
        case 3:
               if (numero >= 0)
               {
                  double raiz = Math.Sqrt(numero);
                  Console.WriteLine($"\nLa raiz cuadrada del numero es {raiz}");
               }else
               {
                  Console.WriteLine("\nNo se puede calcular la raiz de un numero negativo");  
               }
               break;   
        case 4:
               double seno = Math.Sin(numero);
               Console.WriteLine($"\nEl seno del numero es {seno}");
               break;
         case 5:
               double coseno = Math.Cos(numero);
               Console.WriteLine($"\nEl coseno del numero es {coseno}");
               break;
         case 6:
               int parteEntera = (int)numero;
               Console.WriteLine($"\nLa parte entera del numero es {parteEntera}");
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