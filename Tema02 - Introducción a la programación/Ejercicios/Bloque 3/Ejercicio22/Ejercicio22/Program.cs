// Ejercicio 22 Parte 2 Boletin

int num1, num2;
Console.WriteLine("Dime el primer numero:");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dime el segundo numero:");
num2 = int.Parse(Console.ReadLine());

if (num1 == 0 || num1 == 1 || num1 == 4 && num2 == 0 || num2 == 1 || num2 == 4)
{
    Console.WriteLine("No son ambos primos");
}
else if (num1 == 3 || num1 == 5 && num2 == 3 || num2 == 5)
{
    Console.WriteLine("Son primos");
}
else
{
    Console.WriteLine("Introduce un valor válido");
}


Console.ReadLine();
