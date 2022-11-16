double presion, temperatura;

Console.Write("Introduce la presión: ");
presion = double.Parse(Console.ReadLine());

Console.Write("Introduce la temperatura: ");
temperatura = double.Parse(Console.ReadLine());

if (presion > 2)
{
    Console.WriteLine("Abrir válvula de seguridad");
}

if (temperatura > 500)
{
    Console.WriteLine("Reducir la temperatura");
}

if (presion <= 2 && temperatura <= 500)
{
    Console.WriteLine("Todo en orden");
}

Console.ReadLine();