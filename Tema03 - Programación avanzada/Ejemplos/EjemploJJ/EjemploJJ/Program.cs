
string jugada = "", jugadaOrdenador = "";

//Creamos la interfaz gráfica
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("JUEGO PIEDRA, PAPEL, TIJERAS");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

while (jugada != "STOP")
{
    Console.Write("Elige tu jugada: ");
    jugada = Console.ReadLine();
    jugadaOrdenador = calcularJugadaOrdenador();
    //Comprobamos que se cumpla las condiciones
    if (jugada == "PIEDRA" || jugada == "PAPEL" || jugada == "TIJERAS")
    {
        if (jugada == jugadaOrdenador)
        {
            Console.WriteLine("EMPATE");
        }
        else if (jugada == "PIEDRA")
        {
            if (jugadaOrdenador == "PAPEL")
            {
                Console.WriteLine("ORDENADOR GANADOR");
            }
            else
            {
                Console.WriteLine("JUGADOR GANADOR");
            }
        }
        else if (jugada == "PAPEL")
        {
            if (jugadaOrdenador == "TIJERAS")
            {
                Console.WriteLine("ORDENADOR GANADOR");
            }
            else
            {
                Console.WriteLine("JUGADOR GANADOR");
            }
        }
        else if (jugada == "TIJERAS")
        {
            if (jugadaOrdenador == "PIEDRA")
            {
                Console.WriteLine("ORDENADOR GANADOR");
            }
            else
            {
                Console.WriteLine("JUGADOR GANADOR");
            }
        }
    }
    else
    {
        Console.WriteLine("Vuelve a probar");
    }

    Console.ReadLine(); 
}


string calcularJugadaOrdenador()
{
    string jugadaOrdenador = "";
    int numeroJugada;

    Random generadorAleatorio = new Random();
    numeroJugada = generadorAleatorio.Next(1, 3 + 1);

    switch (numeroJugada)
    {
        case 1:
            {
                jugadaOrdenador = "PIEDRA";
                break;
            }
        case 2:
            {
                jugadaOrdenador = "PAPEL";
                break;
            }
        case 3:
            {
                jugadaOrdenador = "TIJERAS";
                break;
            }
    }

    return jugadaOrdenador;
}

