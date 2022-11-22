// Ejercicio 23 Parte 2 Boletin

double num1, num2;
Console.WriteLine("Dime el primer numero:");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Dime el segundo numero:");
num2 = double.Parse(Console.ReadLine());

if(num1 % 2 == 0 && num2 % 2 == 0)
{
    Console.WriteLine("Ambos son pares");
}else if(num1 % 2 != 0 && num2 % 2 != 0)
{
    Console.WriteLine("Ambos son impares");
}
else
{
    Console.WriteLine("El tipo de los numeros no coincide");
}


Console.ReadLine();