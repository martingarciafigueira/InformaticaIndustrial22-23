//Declaramos la variable
int numero;

//Pedimos el numero por pantalla
Console.Write("Dame un número: ");
numero = int.Parse(Console.ReadLine());

//Comprobamos si es par o impar
if (numero % 2 == 0)
{
    Console.WriteLine("ES PAR");
}
else
{
    Console.WriteLine("ES IMPAR");
}

Console.ReadLine();