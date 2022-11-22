string opcion;

Console.WriteLine("ARCHIVO");
Console.WriteLine("BUSCAR");
Console.WriteLine("SALIR");

Console.WriteLine("Introduce una de las opciones");

opcion = Console.ReadLine();

if (opcion  == "ARCHIVO" || opcion == "BUSCAR" || opcion == "SALIR")
{
    Console.WriteLine("GARZA");
}
else
{
    Console.WriteLine("ERROR");
}

Console.ReadLine();