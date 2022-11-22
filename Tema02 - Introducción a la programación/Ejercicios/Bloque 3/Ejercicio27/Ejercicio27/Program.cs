// Ejercicio 27 Parte 2 Boletin

string opcion;
double num;

Console.WriteLine("Seleccione entre las siguientes opciones: ");
Console.WriteLine("Hectogramos");
Console.WriteLine("Decagramos");
Console.WriteLine("Gramos");
Console.WriteLine("Decigramos");
Console.WriteLine("Centigramos");
Console.WriteLine("Miligramos");
opcion = Console.ReadLine();

Console.WriteLine("Ahora introduzca la cantidad de gramos");
num = double.Parse(Console.ReadLine());

if ( opcion == "Hectogramos")
{
    num = num * 0.01;
    Console.WriteLine("El resultado es: " + num);
}else if( opcion == "Decagramos")
{
    num = num * 0.1;
    Console.WriteLine("El resultado es: " + num);
}
else if (opcion == "Gramos")
{
    num = num * 1;
    Console.WriteLine("El resultado es: " + num);
}
else if (opcion == "Decigramos")
{
    num = num * 10;
    Console.WriteLine("El resultado es: " + num);
}
else if (opcion == "Centigramos")
{
    num = num * 100;
    Console.WriteLine("El resultado es: " + num);
}
else if (opcion == "Miligramos")
{
    num = num * 1000;
    Console.WriteLine("El resultado es: " + num);
}


Console.ReadLine();