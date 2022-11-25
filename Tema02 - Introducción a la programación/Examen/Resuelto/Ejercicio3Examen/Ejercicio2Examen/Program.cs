int numero;

Console.WriteLine("Introduce un número");
numero = int.Parse(Console.ReadLine());

//Comprobamos si es múltiplo de 2, 3 o 5
if (numero % 2 == 0)
{
    Console.WriteLine("Es múltiplo de 2");
}

if (numero % 3 == 0)
{
    Console.WriteLine("Es múltiplo de 3");
}

if (numero % 5 == 0)
{
    Console.WriteLine("Es múltiplo de 5");
}

Console.ReadLine();