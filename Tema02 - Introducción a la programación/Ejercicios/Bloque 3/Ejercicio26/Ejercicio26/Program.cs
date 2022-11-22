// Ejercicio 26 Parte 2 Boletin

string opcion;

Console.WriteLine("Seleccione el tipo de triangulo. Puede ser equilatero, isosceles o escaleno");
opcion = Console.ReadLine();

if(opcion == "Equilatero")
{
    Console.WriteLine("El perímetro es igual a a * 3");
}else if(opcion == "Isosceles")
{
    Console.WriteLine("El perímetro es igual a 2a + b");
}else if(opcion == "Escaleno")
{
    Console.WriteLine("El perímetro es igual a la suma de sus tres lados");
}
else
{
    Console.WriteLine("Seleccione una de la opciones mostradas");
}


Console.ReadLine();