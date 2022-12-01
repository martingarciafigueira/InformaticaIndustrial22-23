
int opcion, a, b, c;
double x1 = 0, x2 = 0, raiz = 0;

Console.WriteLine("1- Resolver ecuación 2º grado");
Console.WriteLine("2- Salir");

opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        {
            Console.Write("Introduce el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduce el valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduce el valor de c: ");
            c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                x1 = -(c / b);
                x2 = -(c / b);
            }
            else if (b == 0)
            {
                raiz = -(c / a);
                if (raiz < 0)
                {
                    Console.WriteLine("No hay soluciones reales");
                    break;
                }
                else
                {
                    x1 = -Math.Sqrt(raiz);
                    x2 = Math.Sqrt(raiz);
                }
            }
            else if (c == 0)
            {
                x1 = 0;
                x2 = -(b / a);
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                raiz = Math.Pow(b, 2) - 4 * a * c;
                if (raiz < 0)
                {
                    Console.WriteLine("No hay soluciones reales");
                    break;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(raiz)) / 2 * a;
                    x2 = (-b - Math.Sqrt(raiz)) / 2 * a;
                }
            }

            Console.WriteLine("X1: " + x1);
            Console.WriteLine("X2: " + x2);

            break;
        }
    case 2:
        {
            Environment.Exit(0);
            break;
        }
}

Console.ReadLine();