// See https://aka.ms/new-console-template for more information
//DECLARACION DE VARIABLES
using System.Security.Cryptography;

string jugadorActual;
int posJugador1 = 0;
int posJugador2 = 0;
int posicionActual = 0;
bool hayGanador = false;
int dado;
int sonido;
bool relay = false;
bool portal = false;
bool agujero = false;
Thread.Sleep(120);
Console.Beep(264, 50);
Thread.Sleep(60);
Console.Beep(264, 50);
Thread.Sleep(30);
Console.Beep(297, 200);
Thread.Sleep(30);
Console.Beep(264, 200);
Thread.Sleep(30);
Console.Beep(352, 200);
Thread.Sleep(30);
Console.Beep(330, 350);
Thread.Sleep(50);
Console.Beep(264, 50);
Thread.Sleep(50);
Console.Beep(264, 50);
Thread.Sleep(30);
Console.Beep(297, 200);
Thread.Sleep(30);
Console.Beep(264, 200);
Thread.Sleep(30);
Console.Beep(396, 200);
Thread.Sleep(30);
Console.Beep(352, 350);
Thread.Sleep(50);
Console.Beep(264, 50);
Thread.Sleep(50);
Console.Beep(264, 50);
Thread.Sleep(30);
Console.Beep(2642, 200);
Thread.Sleep(30);
Console.Beep(440, 200);
Thread.Sleep(30);
Console.Beep(352, 110);
Thread.Sleep(30);
Console.Beep(352, 50);
Thread.Sleep(30);
Console.Beep(330, 200);
Thread.Sleep(30);
Console.Beep(297, 350);
Thread.Sleep(50);
Console.Beep(466, 50);
Thread.Sleep(50);
Console.Beep(466, 50);
Thread.Sleep(30);
Console.Beep(440, 200);
Thread.Sleep(30);
Console.Beep(352, 200);
Thread.Sleep(30);
Console.Beep(396, 200);
Thread.Sleep(30);
Console.Beep(352, 350);
//CONSTRUCCION DE VARIABLE RANDOM
Random son = new Random();
Random ran = new Random();
Console.WriteLine("//////// juego de la Oca /////////");
Console.WriteLine("           BIENVENIDO");
Console.WriteLine("Presione una tecla para saber quien comienza");
//COMANDO PARA SEGUIR CUANDO EL USUARIO TOQUE UNA TECLA
Console.ReadLine();
Console.Beep(466, 125);
//USO DE LA VARIABLE RANDOM
dado = ran.Next(1, 7);
Console.WriteLine($"el dado es {dado}");
//SI EL DADO ES MENOR O IGUAL A 3 COMIENZA EL JUGADOR 1, SINO EL 2
if (dado <= 3)
{
    jugadorActual = "jugador 1";
    posJugador1 = posicionActual;
}
else
{
    jugadorActual = "jugador 2";
    posJugador2 = posicionActual;
}

Console.WriteLine($"Comienza el jugador: {jugadorActual}");
Console.WriteLine("/////////////////////////////////////////////////");
//BUCLE WHILE SE REPITE HASTA QUE HAYA UN GANADOR
while(!hayGanador)
{
    Console.ResetColor();
    Console.WriteLine($"La posicion del jugador 1 es {posJugador1}");
    Console.WriteLine($"La posicion del jugador 2 es {posJugador2}");
    Console.WriteLine();
    Console.WriteLine($"Es el turno del jugador {jugadorActual}");
    Console.WriteLine("presione una tecla para lanzar los dados");
    Console.ReadLine();
    sonido = son.Next(120, 500);
    Console.Beep(sonido, 200); //sonido
    dado = ran.Next(1, 7);
    Console.WriteLine($"su dado es {dado}");
    // BUSCA QUIEN ES EL JUGADOR ACTUAL PARA SABER SU POSICION
    if(jugadorActual == "jugador 1")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        posicionActual = posJugador1;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        posicionActual = posJugador2;
    }
    posicionActual += dado;
    Console.WriteLine($"El jugador {jugadorActual} avanza hasta el casillero {posicionActual}");
    // SI NO SE PASO DEL CASILLERO 64 SIGUE JUGANDO O GANO
    if (posicionActual <= 64)
    {
        //CASILLEROS RELAY, AVANZAN 10 POSICIONES SI LA POSICION ACTUAL ES DIVISIBLE POR 10
        if(posicionActual %10 == 0 && posicionActual < 60)
        {
            if (posicionActual == 10)
            {
                posicionActual += 10;
            }
            else if (posicionActual == 20)
            {
                posicionActual += 10;
            }
            else if (posicionActual == 30)
            {
                posicionActual += 10;
            }
            else if (posicionActual == 40)
            {
                posicionActual += 10;
            }
            else if (posicionActual == 50)
                posicionActual += 10;
            Console.WriteLine($"Relay ¡ FELICIDADES el {jugadorActual} avanza 10 casilleros ");
        }
        //CASILLEROS DE TELETRANSPORTACION: AVANZAN O RETROCEDEN
        else if(posicionActual == 12 || posicionActual == 48)
        {
            posicionActual = posicionActual / 2;
            Console.WriteLine($"QUE LASTIMA el {jugadorActual} fue teletransportado 6 casilleros hacia atras");
        }
        else if(posicionActual == 6 || posicionActual == 24)
        {
            posicionActual = posicionActual * 2;
            Console.WriteLine($"EXCELENTE el {jugadorActual} fue teletransportado 6 casilleros hacia adelante");
        }
        //CASILLEROS AGUJEROS NEGROS: VUELVEN A COMENZAR AL INICIO
        else if(posicionActual==32 || posicionActual==38 || posicionActual==53)
        {
            posicionActual = 0;
            Console.WriteLine($"JAJAJA el {jugadorActual} Fue absorvido por un agujero negro, vuelve a 0");
        }
        //CASILLERO GANADOR
        else if(posicionActual == 64)
        {
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(625);
            Console.BackgroundColor = ConsoleColor.Red;
            hayGanador = true;
            Console.Write($"El ganador es {jugadorActual}");
            Console.ResetColor();
        }
    }
    //SI LA POSICION ACTUAL SE PASO DE 64 ENTONCES NO AVANZA
    else
    {
        posicionActual -= dado;
    }
    //CAMBIO DE JUGADOR
    if (jugadorActual == "jugador 1")
    {
        posJugador1 = posicionActual;
        jugadorActual = "jugador 2";
    }
    else
    {
        posJugador2 = posicionActual;
        jugadorActual = "jugador 1";
    }
}
    
