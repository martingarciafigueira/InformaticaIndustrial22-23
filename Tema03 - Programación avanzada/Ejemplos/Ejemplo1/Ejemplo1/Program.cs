
//Ejemplo 1: Nombres y apellidos de los alumnos de clase, mientras no escriba la palabra "STOP"

string nombre = "", apellido = "";

while (nombre != "STOP")
{
    Console.Write("Introduce tu nombre: ");
    nombre = Console.ReadLine();

    Console.Write("Introduce tu apellido: ");
    apellido = Console.ReadLine();

    Console.WriteLine("Nombre completo: " + nombre + " " + apellido);
    Console.WriteLine();
}


Console.ReadKey();