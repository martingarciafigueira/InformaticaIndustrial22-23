// Ejercicio 29 Parte 2 Boletín

double sueldo;
int anhos;

Console.WriteLine("Cuantos años lleva en la empresa?");
anhos = int.Parse(Console.ReadLine());

if(anhos > 10)
{
    sueldo = 40000 * 1.10;
    Console.WriteLine("El sueldo va a ser de " + anhos);
}else if(anhos < 10 && anhos > 5)
{
    sueldo = 40000 * 1.07;
    Console.WriteLine("El sueldo va a ser de " + anhos);
}else if(anhos < 5 && anhos > 3)
{
    sueldo = 40000 * 1.05;
    Console.WriteLine("El sueldo va a ser de " + anhos);
}
else if (anhos < 3)
{
    sueldo = 40000 * 1.03;
    Console.WriteLine("El sueldo va a ser de " + anhos);
}
else
{
    Console.WriteLine("Escriba bien el valor");
}




Console.ReadLine(); 