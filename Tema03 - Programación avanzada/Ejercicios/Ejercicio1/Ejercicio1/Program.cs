//Ejercicio 1a

int i = 1;

while (i <= 11)
{
    Console.Write(i + ",");
    i += 2;
}
Console.WriteLine();

for (i = 1; i <= 11; i = i + 2)
{
    Console.Write(i + ",");
}

Console.WriteLine();

//Ejercicio 1b

i = 2;
while (i <= 10)
{
    Console.Write(i + ",");
    i += 2;
}
Console.WriteLine();

for (i = 2; i <= 10; i = i + 2)
{
    Console.Write(i + ",");
}

Console.WriteLine();

//Ejercicio 1c
i = 5;
while (i <= 25)
{
    Console.Write(i + ",");
    i += 5;
}
Console.WriteLine();

for (i = 5; i <= 25; i = i + 5)
{
    Console.Write(i + ",");
}

Console.WriteLine();

//Ejercicio 1d
i = 100;
while (i >= 50)
{
    Console.Write(i + ",");
    i -= 10;
}
Console.WriteLine();

for (i = 100; i >= 50; i = i - 10)
{
    Console.Write(i + ",");
}

Console.WriteLine();

Console.ReadLine();