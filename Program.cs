// See https://aka.ms/new-console-template for more information



bool afirmacion = true;

while (afirmacion) {
    Console.Clear();
    Console.WriteLine(@"

.-----------------------------.
| # Texax Instruments   TI-82 |
| .-------------------------. |
| |            ./           | |
| |            +            | |
| |. . . . . ./. . . . . . .| |
| |          / .            | |
| | X=5.2   /  .   Y=0      | |
| '-------------------------' |
| [Y=][WIN][ZOOM][TRACE][GRH] |
|                  _ [ ^ ] _  |
| [2nd][MODE][DEL]|_|     |_| |
| [ALP][XTO][STAT]   [ V ]    |
| [MATH][MAT][PGM][VARS][CLR] |
| [x-1] [SIN] [COS] [TAN] [^] |
|  [x2][ , ][ ( ][ ) ][ / ]   |
| [LOG][ 7 ][ 8 ][ 9 ] [ X ]  |
| [LN ][ 4 ][ 5 ][ 6 ] [ - ]  |
| [STO>][ 1 ][ 2 ][ 3 ][ + ]  |
| [ON][ 0 ][ . ][ (-) ][ENTR] |
| ----                        |
'-----------------------------'



");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("0) salir");
    Console.ForegroundColor = ConsoleColor.White;
 Console.WriteLine(@"
1) multuplicar

2) calcular promedio. 

3)encontrar la hipotenusa. 

4) encontrar el cateto faltante.

5)  encontrar el area de un triangulo.
");
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("6)siguiente >>>>> ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("ingrese el numero que dese ingresar : ");
    string entrada = Console.ReadLine() ?? "";

    switch (entrada)
{
     case "0":
        afirmacion = false;
        break;

        case "1":
        Ejercicios.Multiplicacion();
        break;

    case "2":
        Ejercicios.Promedio();
        break;

    case "3":
        Ejercicios.Hipotenusa();
        break;

    case "4":
        Ejercicios.Cateto();
        break;

    case "5":
        Ejercicios.Triangulo();
        break;

        case "6":

        Ejercicios.Siguiente();
        break;

/*
    case "6":
        Ejercicios.Ecuaciones_segundo_grado();
        break;


    case "7":
        Ejercicios.Caracteres();
        break;

    case "8":
        Ejercicios.Tickets_de_viajero();
        break;

    case "9":
        Ejercicios.Hamburguesa();
        break;

    case "10":
        Ejercicios.Dolar();
        break;

    case "11":
        Ejercicios.Mitad_cuadrado_doble();
        break;

    case "12":
        Ejercicios.Energia();
        break;

    case "13":
        Ejercicios.Edad();
        break;

    case "14":
        Ejercicios.Temperatura();
        break;

    case "15":
        Ejercicios.Corre(); 
        break;

    case "16":
        Ejercicios.Video();
        break;

    default:
        Console.WriteLine("no as puesto naaa");
        break;
*/

}
}