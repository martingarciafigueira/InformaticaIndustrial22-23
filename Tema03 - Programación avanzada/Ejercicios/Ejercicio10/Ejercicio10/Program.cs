int m = -1, suma = 0;

//Me aseguro que el número sea positivo
while (m < 0)
{
    Console.Write("Introduce un número positivo: ");
    m = int.Parse(Console.ReadLine());
}

//Calculo la suma de los m primeros números
for (int i = 1; i <= m; i++)
{
    suma += i;
}

Console.WriteLine("La suma es: " + suma);

Console.ReadLine();