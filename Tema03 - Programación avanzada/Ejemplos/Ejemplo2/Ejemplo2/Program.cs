//Ejemplo 2: Pedir nombre de 5 alumnos por pantalla

string nombre = "", apellido = "";

for (int i = 1; i <= 5; i++)
{
    Console.Write("Introduce tu nombre: ");
    nombre = Console.ReadLine();

    Console.Write("Introduce tu apellido: ");
    apellido = Console.ReadLine();

    Console.WriteLine("Nombre completo: " + nombre + " " + apellido);
    Console.WriteLine();
}


Console.ReadKey();
