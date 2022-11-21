int numero;

Console.Write("Introduce un número: ");
numero = int.Parse(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("LUNES");
        break;
    case 2:
        Console.WriteLine("MARTES");
        break;
    case 3:
        Console.WriteLine("MIÉRCOLES");
        break;
    case 4:
        Console.WriteLine("JUEVES");
        break;
    case 5:
        Console.WriteLine("VIERNES");
        break;
    case 6:
        Console.WriteLine("SÁBADO");
        break;
    case 7:
        Console.WriteLine("DOMINGO");
        break;
    default:
        break;
}

Console.ReadLine();