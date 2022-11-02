//Declaramos las variables
double numero1, numero2, suma, resta, multiplicacion;

//Pido la info al usuario
Console.Write("Introduce un número: ");
numero1 = double.Parse(Console.ReadLine());

Console.Write("Introduce otro número: ");
numero2 = double.Parse(Console.ReadLine());

//Realizo los cálculos
suma = numero1 + numero2;
resta = numero1 - numero2;
multiplicacion = numero1 * numero2;

//Mostramos los datos por pantalla
Console.WriteLine("La suma es: " + suma);
Console.WriteLine("La resta es: " + resta);
Console.WriteLine("La multiplicación es: " + multiplicacion);

Console.ReadLine();