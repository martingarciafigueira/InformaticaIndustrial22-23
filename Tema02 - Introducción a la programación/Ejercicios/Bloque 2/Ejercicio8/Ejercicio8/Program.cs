//pv = nRT
//Declaramos las variables
double presion, volumen, nMoles, temperatura;
const double R = 0.082;

//Pedimos los datos al usuario
Console.Write("Mete el volumen: ");
volumen = double.Parse(Console.ReadLine());

Console.Write("Mete el número de moles: ");
nMoles = double.Parse(Console.ReadLine());

Console.Write("Mete la temperatura: ");
temperatura = double.Parse(Console.ReadLine());

//Realizamos los cálculos
presion = (nMoles * R * temperatura) / volumen;

//Mostramos los datos por pantalla
Console.WriteLine("Con un volumen de " + volumen + " litros ,y una temperatura de " + temperatura + " kelvin, " + nMoles + " moles de un gas ideal tienen una presión de " + presion + " atmósferas");

Console.ReadLine();