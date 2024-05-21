// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

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
      Console.WriteLine($"El numero invertido es: {numInvertido}");
    }else{
      Console.WriteLine("No ha ingresado un numero");
    }
}

Console.WriteLine("\n--------Ejercicio 3-MERGE--------\n");

int controla; 
do
{
    Console.WriteLine("\n--------Calculadora--------\n");
    Console.WriteLine("\n1.SUMA");
    Console.WriteLine("\n2.RESTA");
    Console.WriteLine("\n3.MULTIPLICACION");
    Console.WriteLine("\n4.DIVISION");
    Console.WriteLine("\n5.VALOR ABSOLUTO");
    Console.WriteLine("\n6.CUADRADO");
    Console.WriteLine("\n7.RAIZ CUADRADA");
    Console.WriteLine("\n8.SENO");
    Console.WriteLine("\n9.COSENO");
    Console.WriteLine("\n10.PARTE ENTERA");
    Console.WriteLine("\nElija la operacion que desea realizar: ");
    string operacion = Console.ReadLine(); 
    int op;
    string n1, n2, n;
    float num1, num2, numero;
    if(int.TryParse(operacion, out op))
    {
      if (op == 1 || op == 2 || op == 3 || op == 4)
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
                     Console.WriteLine($"\nLa suma de los numeros es {suma}");
                     break;
            case 2:
                     float resta = num1 - num2;
                     Console.WriteLine($"\nLa diferencia de los numeros es {resta}");
                     break;
            case 3:
                     float producto = num1*num2;
                     Console.WriteLine($"\nEl producto de los numeros es {producto}");
                     break;
            case 4:
                     if(num2 != 0)
                     {
                        float cociente = num1/num2;
                        Console.WriteLine($"\nEl producto de los numeros es {cociente}");
                     }else{
                        Console.WriteLine("\nNo se puede dividir en 0");
                     }
                     break;
         }
         
      }else
      {
         do{
            Console.WriteLine("\nIngrese el numero: ");
            n = Console.ReadLine(); 
         }while (!float.TryParse(n, out numero));
         switch (op)
         {
            case 5:
                  float valorAbs = Math.Abs(numero); 
                  Console.WriteLine($"\nEl valor absoluto es {valorAbs}");
                  break;
            case 6:
                     double cuadrado = numero * numero;
                     Console.WriteLine($"\nEl cuadrado delnumero es {cuadrado}");
                     break;
            case 7:
                     if (numero >= 0)
                     {
                        double raiz = Math.Sqrt(numero);
                        Console.WriteLine($"\nLa raiz cuadrada del numero es {raiz}");
                     }else
                     {
                        Console.WriteLine("\nNo se puede calcular la raiz de un numero negativo");  
                     }
                     break;   
            case 8:
                     double seno = Math.Sin(numero);
                     Console.WriteLine($"\nEl seno del numero es {seno}");
                     break;
            case 9:
                     double coseno = Math.Cos(numero);
                     Console.WriteLine($"\nEl coseno del numero es {coseno}");
                     break;
            case 10:
                     int parteEntera = (int)numero;
                     Console.WriteLine($"\nLa parte entera del numero es {parteEntera}");
                     break;
            }
         }
      }
    Console.WriteLine("\nIngrese 1 si desea continuar operando. Caso contrario ingrese 0");
    string control = Console.ReadLine();
    if(!int.TryParse(control, out controla))
    {
      controla = 1;
    }
}while (controla != 0);

float c;
string nu1;
float d;
string nu2;
Console.WriteLine("A continuacion ingrese dos numeros\n");
do
{
    Console.WriteLine("Primer numero: ");
    nu1 = Console.ReadLine();
    Console.WriteLine("\nSegundo numero: ");
    nu2 = Console.ReadLine(); 
} while (!float.TryParse(nu1, out c) || !float.TryParse(nu2, out d));
if (c > d)
{
    Console.WriteLine($"\nEl maximo entre los dos numeros es: {c}\n");
    Console.WriteLine($"El minimo entre los dos numeros es: {d}\n");
} else if (d > c)
{
    Console.WriteLine($"\nEl maximo entre los dos numeros es: {d}\n");
    Console.WriteLine($"El minimo entre los dos numeros es: {c}\n");
} else
{
    Console.WriteLine("Ambos numeros son iguales\n");
}