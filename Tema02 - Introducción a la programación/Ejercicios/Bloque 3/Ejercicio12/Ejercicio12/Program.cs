int numero;

Console.Write("Introduce un número: ");
numero = int.Parse(Console.ReadLine());

if (numero != 4)
{
    Console.WriteLine("El número no es primo");
}
else
{
    Console.WriteLine("El número es primo");
}

Console.ReadLine();
