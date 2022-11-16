double numero1, numero2, suma, raiz;

Console.Write("Introduce numero 1: ");
numero1 = double.Parse(Console.ReadLine());

Console.Write("Introduce numero 2: ");
numero2 = double.Parse(Console.ReadLine());

suma = numero1 + numero2;

if (suma > 0)
{
    raiz = Math.Sqrt(suma);
    Console.WriteLine("La raíz es: " + raiz);
}
else
{
    Console.WriteLine("No se puede calcular la raíz");
}

Console.ReadLine();
