int num1, num2, num3, mayor, menor, intermedio = 0;

Console.Write("Introduce un número:");
num1 = int.Parse(Console.ReadLine());

Console.Write("Introduce un número:");
num2 = int.Parse(Console.ReadLine());

Console.Write("Introduce un número:");
num3 = int.Parse(Console.ReadLine());

mayor= Math.Max(num1, num2);
mayor= Math.Max(mayor, num3);

menor = Math.Min(num1, num2);
menor = Math.Min(menor, num3);

if (num1 > menor && num1 < mayor)
{
    intermedio = num1;
}
else if (num2 > menor && num2 < mayor)
{
    intermedio = num2;
}
else if (num3 > menor && num3 < mayor)
{
    intermedio = num3;
}

Console.WriteLine(mayor + " " + intermedio + " " + menor);

Console.ReadLine();