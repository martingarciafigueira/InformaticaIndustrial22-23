int numero;

//Pedimos el número
Console.Write("Introduce un número: ");
numero = int.Parse(Console.ReadLine());

//Hacemos el bucle
for (int i = numero; i < numero + 5; i++)
{
    Console.WriteLine(i + " " + Math.Pow(i,2) + " " + Math.Pow(i,3));
}

Console.ReadLine();