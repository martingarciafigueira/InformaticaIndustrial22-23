string pass1, pass2;

pass1 = "Montecastelo";

Console.WriteLine("Introduce la contraseña");
pass2 = Console.ReadLine();

if (pass1 == pass2)
{
    Console.WriteLine("Acertaste la pass");
}
else
{
    Console.WriteLine("Más suerte la próxima vez");
}

Console.ReadLine();