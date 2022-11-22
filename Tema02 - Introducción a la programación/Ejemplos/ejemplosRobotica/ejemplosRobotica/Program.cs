
int numero;
double numeroDecimal;
string cadena;

//EJEMPLO REPASO

//1. Pedir datos por consola
Console.WriteLine("Introduce un número:");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Introduce una cadena :");
cadena = Console.ReadLine();

Console.WriteLine("Introduce un número decimal:");
numeroDecimal = double.Parse(Console.ReadLine());

//2. Calculos matemáticos

//Calcular el cuadrado de un número
numeroDecimal = Math.Pow(2, 5);

//Calcular la raíz cuadrada
numeroDecimal = Math.Sqrt(16);

//Calcular maximo y minimo entre dos números
numero = Math.Max(2, 7);
numero = Math.Min(2, 7);

//Calcular maximo entre 3 numeros
numero = Math.Max(2, 7);
numero = Math.Max(numero, 8);

//Utilizar una constante

numeroDecimal = 2 * Math.Sqrt(4) * Math.PI;

//Definir una constante
const int constante = 5;

//Si un número es mayor que 5
if (numero > 5)
{
    //se ejecuta esto
}
else if(numero < numeroDecimal)
{
    //o se ejecuta esto
}
else
{
    //si no, se ejecuta esto
}

//Numero par
if (numero % 2 == 0)
{
    Console.WriteLine("Número par");
}
else
{
    Console.WriteLine("Número impar");
}

//Switch para los días de la semana
switch (numero)
{
    case 1:
        {
            Console.WriteLine("MARTES");
            break;
        }
    case 2:
        {
            Console.WriteLine("MIERCOLES");
            break;
        }
    case 3:
        {
            Console.WriteLine("JUEVES");
            break;
        }
    case 4:
        {
            Console.WriteLine("VIERNES");
            break;
        }
    case 5:
        {
            Console.WriteLine("SABADO");
            break;
        }
    case 6:
        {
            Console.WriteLine("DOMINGO");
            break;
        }
    case 7:
        {
            Console.WriteLine("LUNES");
            break;
        }
    default:
        break;
}

//Mostrar datos por consola
Console.WriteLine("El valor de número es: " + numero + " y el de número decimal es: " + numeroDecimal);

