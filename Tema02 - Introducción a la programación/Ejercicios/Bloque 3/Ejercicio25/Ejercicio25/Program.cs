// Ejercicio 25 Parte 2 Boletin


double num1, num2, num3;

Console.Write("Escribe el primer numero: ");
num1 = double.Parse(Console.ReadLine());

Console.Write("Escribe el segundo numero: ");
num2 = double.Parse(Console.ReadLine());

Console.Write("Escribe el tercer numero: ");
num3 = double.Parse(Console.ReadLine());

if (num1 % num2 == num3)
{
    Console.WriteLine("El resto de la division de los números " + num1 + " y " + num2 + " es igual a " + num3);
}
else
{
    Console.WriteLine("El resto de la division de los números " + num1 + " y " + num2 + " no es igual a " + num3);
}


Console.ReadLine();