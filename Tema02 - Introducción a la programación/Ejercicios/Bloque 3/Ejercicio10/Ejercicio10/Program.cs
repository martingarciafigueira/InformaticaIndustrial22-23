int numero;

Console.Write("Introduce el número: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Es múltiplo de 2");
}

if (numero % 3 == 0)
{
    Console.WriteLine("Es múltiplo de 3");
}

Console.ReadLine();

