int numero;

Console.Write("Introduce un número: ");
numero = int.Parse(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine("Número positivo");
}
else
{
    Console.WriteLine("Número negativo");
}

Console.ReadLine();
