//Creamos las variables para guardar los datos
string nombre;
string apellidos;
string genero;
string trabajo;
int edad;

//Pedirle al usuario que meta la información que le pido
Console.WriteLine("AGENDA DE CONTACTOS");

Console.WriteLine("Por favor, introduce tu nombre:");
nombre = Console.ReadLine();

Console.WriteLine("Por favor, introduce tus apellidos:");
apellidos = Console.ReadLine();

Console.WriteLine("Por favor, introduce tu género:");
genero = Console.ReadLine();

Console.WriteLine("Por favor, introduce tu trabajo:");
trabajo = Console.ReadLine();

Console.WriteLine("Por favor, introduce tu edad:");
edad = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

//Hacemos algo con esos datos

//Forma 1: Mas intuitiva
Console.WriteLine("¡Bienvenida, " + nombre + " " + apellidos + " a nuestra aplicación!");
Console.WriteLine("Sabemos que tienes " + edad + " años, que tu profesión es " + trabajo + " y tu género es " + genero);

Console.ReadLine();

