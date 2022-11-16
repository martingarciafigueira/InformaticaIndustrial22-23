double num1, num2, resultado;

Console.Write("Introduce el número 1: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Introduce el número 2: ");
num2 = int.Parse(Console.ReadLine());

if(num1 >= num2)
{
    resultado = Math.Pow(num1, num2);
}
else
{
    resultado = Math.Pow(num2, num1);
}

Console.WriteLine("El resultado es: " + resultado);

Console.ReadLine();