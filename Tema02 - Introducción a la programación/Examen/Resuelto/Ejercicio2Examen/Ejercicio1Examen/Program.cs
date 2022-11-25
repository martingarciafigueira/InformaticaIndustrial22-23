int horasTrabajadas;
double tasaHora, salarioNeto = 0, salarioBruto = 0;

//Pedimos los datos por pantalla
Console.Write("Introduce las horas trabajadas: ");
horasTrabajadas = int.Parse(Console.ReadLine());

Console.Write("Introduce las tasa/hora: ");
tasaHora = float.Parse(Console.ReadLine());

//Calculamos el BRUTO
if (horasTrabajadas <= 25)
{
    salarioBruto = horasTrabajadas * tasaHora;
}
else if (horasTrabajadas > 25 && horasTrabajadas < 35)
{
    salarioBruto = 25 * tasaHora + (horasTrabajadas - 25) * (tasaHora * 1.5);
}
else
{
    salarioBruto = 25 * tasaHora + 10 * (tasaHora * 1.5) + (horasTrabajadas - 35) * (tasaHora * 1.75);
}

//Calculamos el NETO
if (salarioBruto < 1000)
{
    salarioNeto = salarioBruto * 0.9;
}
else if (salarioBruto < 1500)
{
    salarioNeto = salarioBruto * 0.85;
}
else if (salarioBruto < 1800)
{
    salarioNeto = salarioBruto * 0.75;
}
else
{
    salarioNeto = salarioBruto * 0.70;
}

Console.WriteLine("SALARIO BRUTO ES: " + salarioBruto);
Console.WriteLine("SALARIO NETO ES: " + salarioNeto);

Console.ReadLine();
