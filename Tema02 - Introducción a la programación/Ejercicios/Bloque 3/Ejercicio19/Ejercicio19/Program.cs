// Ejercicio 19 Parte 2 Boletin


string letra;
Console.WriteLine("Escriba una letra");
letra = Console.ReadLine();

if (letra == "a" || letra == "e" || letra == "i" || letra == "u" || letra == "o")
{
    Console.WriteLine("Es una vocal");
}
else if(letra.Length > 1)
{
    Console.WriteLine("Escriba una sola letra");
}
else
{
    Console.WriteLine("Es una consonante");
}


Console.ReadLine();