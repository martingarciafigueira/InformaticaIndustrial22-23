// Ejercicio 28 Parte 2 Boletín

double impBruto, impNeto;

Console.WriteLine("Cual es el importe bruto?");
impBruto = double.Parse(Console.ReadLine());

if (impBruto > 15000)
{
    impNeto = impBruto * 0.84;
    Console.WriteLine("El sueldo neto es " + impNeto);
}else if(impBruto < 15000)
{
    impNeto = impBruto * 0.90;
    Console.WriteLine("El sueldo neto es " + impNeto);
}
else
{
    Console.WriteLine("Escriba un valor válido");
}




Console.ReadLine();