int numero1, numero2, numero3, menor, mayor, intermedio;

Console.Write("Introduce un número: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("Introduce un número: ");
numero2 = int.Parse(Console.ReadLine());

Console.Write("Introduce un número: ");
numero3 = int.Parse(Console.ReadLine());

menor = Math.Min(numero1, numero2);
menor = Math.Min(menor, numero3);

mayor = Math.Max(numero1, numero2);
mayor = Math.Max(mayor, numero3);

if (numero1 > menor && numero1 < mayor)
{
    intermedio = numero1;
}
else if (numero2 > menor && numero2 < mayor)
{
    intermedio = numero2;
}
else
{
    intermedio = numero3;
}

Console.WriteLine(mayor + " ," + intermedio + " ," + menor);

Console.ReadLine();