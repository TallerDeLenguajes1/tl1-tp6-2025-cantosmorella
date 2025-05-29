using Microsoft.VisualBasic;
/*
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
//Ejercicio 2

int operacion, num1, num2,resultado,control;
string s1, s2, s, s3;

void solicitarDatos()
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("Seleccione la operacion que deser realizar: ");
    Console.WriteLine("1.Suma\n2.Resta\n3.Multiplicar\n4.Dividir");
    s = Console.ReadLine();
    bool conversion = int.TryParse(s, out operacion);

    Console.WriteLine("Ingrese el primer numero");
    s1 = Console.ReadLine();
    bool conversion2 = int.TryParse(s1, out num1);

    Console.WriteLine("Ingrese el primer numero");
    s2 = Console.ReadLine();
    bool conversion3 = int.TryParse(s2, out num2);
}


int calcularNumeros(int operacion, int num1,int num2)
{
    switch (operacion)
    {
        case 1:
            return num1 + num2;
        case 2:
            return num1 - num2;
        case 3:
            return num1 * num2;
        case 4:
            return num1 / num2;
        default: return 11111;
    }
}

do
{
    solicitarDatos();
    resultado = calcularNumeros(operacion, num1, num2);
    Console.WriteLine("El resultado de su operacion es : " + resultado);
    Console.WriteLine("desea realizar otra operacion? 1:SI 2:NO");
    s3 = Console.ReadLine();
    bool conversion4 = int.TryParse(s3, out control);
} while (control==1);

