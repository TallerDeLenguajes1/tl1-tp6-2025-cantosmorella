using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);

Console.WriteLine("-----------------");


//Ejercicio 1----------------------
int num;
int numInvertido;
string s;
bool conversion;
numInvertido = 0;
do
{
    Console.WriteLine("Ingrese un numero para invertir: ");
    s = Console.ReadLine();
    conversion = int.TryParse(s, out num);
} while (!conversion );

if (num > 0)
{
    while (num != 0)
    {
        numInvertido = numInvertido * 10 + num % 10;
        num /= 10;
    }
    Console.WriteLine("El numero invertido invertido: " + numInvertido);
} else {
    Console.WriteLine("No se puede invertir el numero por no ser mayor a cero");
}

//Ejercicio 2
