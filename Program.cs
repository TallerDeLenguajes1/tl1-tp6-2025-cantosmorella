/*
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
*/
//Ejercicio 3

float num;
int num1, num2;
string s,s1,s2;
bool conversion,conversion1,conversion2;
do
{
    Console.WriteLine("Ingrese un numero(float): ");
    s = Console.ReadLine();
    conversion = float.TryParse(s, out num);

    Console.WriteLine("Calculo del MAYOR y MENOR numero");
    Console.WriteLine("Ingrese el primer numero(int): ");
    s1 = Console.ReadLine();
    conversion1 = int.TryParse(s1, out num1);
    Console.WriteLine("Ingrese el segundo numero(int): ");
    s2 = Console.ReadLine();
    conversion2 = int.TryParse(s2, out num2);
} while (!conversion && !conversion1 && !conversion2);

mostrarCalculos(num, num1, num2);

void mostrarCalculos(float num,int num1,int num2)
{
    Console.WriteLine(
                        @$"El valor absoluto de un numero: {Math.Abs(num)}
                        El cuadrado de el numero es: {num * num}
                        La raiz cuadrada del numero es: {Math.Sqrt(num)}
                        El seno del numero es: {Math.Sin(num)}
                        El coseno del numero es: {Math.Cos(num)}
                        La parte entera de un tipo flotante: {(int)num}
                        El mayor numero de {num1} y {num2} es: {mayor(num1, num2)}
                        El menor numero de {num1} y {num2} es: {menor(num1, num2)}");

}
int mayor(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

int menor(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

