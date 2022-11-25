double num1, num2, num3, num4, num5, maximo, minimo, raizMaximo = 0, potenciaMinimo = 0, sumaFinal;

//Pedimos los números
Console.Write("Introduce un número decimal: ");
num1 = double.Parse(Console.ReadLine());

Console.Write("Introduce un número decimal: ");
num2 = double.Parse(Console.ReadLine());

Console.Write("Introduce un número decimal: ");
num3 = double.Parse(Console.ReadLine());

Console.Write("Introduce un número decimal: ");
num4 = double.Parse(Console.ReadLine());

Console.Write("Introduce un número decimal: ");
num5 = double.Parse(Console.ReadLine());


//Calculamos máximo y mínimo (Math.Max y Math.Min)
maximo = Math.Max(num1, num2);
maximo = Math.Max(maximo, num3);
maximo = Math.Max(maximo, num4);
maximo = Math.Max(maximo, num5);

minimo = Math.Min(num1, num2);
minimo = Math.Min(minimo, num3);
minimo = Math.Min(minimo, num4);
minimo = Math.Min(minimo, num5);

if (maximo > 0)
{
    raizMaximo = Math.Sqrt(maximo);
}

if (minimo < 0)
{
    potenciaMinimo = Math.Pow(minimo, minimo);
}

sumaFinal = raizMaximo + potenciaMinimo;

Console.WriteLine("Números iniciales: {0} - {1} - {2} - {3} - {4}", num1, num2, num3, num4, num5);
Console.WriteLine("Mínimo: {0}", minimo);
Console.WriteLine("Máximo: {0}", maximo);
Console.WriteLine("Suma final: {0}", sumaFinal);

Console.ReadLine();