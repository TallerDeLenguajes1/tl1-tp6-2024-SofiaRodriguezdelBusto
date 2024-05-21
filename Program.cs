// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

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

Console.WriteLine("\n--------Ejercicio 2--------\n");

int controla; 
do
{
    Console.WriteLine("\n--------Calculadora--------\n");
    Console.WriteLine("\n1.SUMA");
    Console.WriteLine("\n2.RESTA");
    Console.WriteLine("\n3.MULTIPLICACION");
    Console.WriteLine("\n4.DIVISION");
    Console.WriteLine("\n5.SALIR");
    Console.WriteLine("\nElija la operacion que desea realizar: ");
    string operacion = Console.ReadLine(); 
    int op;
    string n1, n2;
    float num1, num2;
    do
    {
      Console.WriteLine("\nIngrese el primer numero: ");
      n1 = Console.ReadLine(); 
      n2 = Console.ReadLine();
    } while (!(float.TryParse(n1, out num1) && float.TryParse(n2, out num2)));

    if(int.TryParse(operacion, out op))
    {
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
    }
    Console.WriteLine("\nIngrese 1 si desea continuar operando. Caso contrario ingrese 0");
    string control = Console.ReadLine();
    if(!int.TryParse(control, out controla))
    {
      controla = 1;
    }
}while (controla != 0);

