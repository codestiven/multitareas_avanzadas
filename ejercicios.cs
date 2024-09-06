using System;


public class Ejercicios
{
	public static void Siguiente()
	{
		bool afirmacion = true;

		while (afirmacion)
		{

			Console.Clear();
			Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO  3.141592654 | |
| |_________________| |
|  __ __ __ __ __ __  |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|
");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("5) <<<<<<<<<<<<< atras");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(@"

6) resolver ecuacion de segundo grado

7)Indicar la cantidad de caracteres que tiene una palabra. 

8) cuantos ticket puedo comprar.

9)cuantas hamburguesas puedo hacer. 


10)convertir de peso dominicano a dolares. 

11)la mitad, el cuadrado y el doble de un numero.
");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("12) siguiente >>>>>");
			Console.ForegroundColor = ConsoleColor.White;

			Console.Write("ingrese el numero que dese ingresar : ");
			string entrada = Console.ReadLine() ?? "";

			switch (entrada)
			{
				case "5":
					afirmacion = false;
					break;


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
					        Ejercicios.Siguiente_2();
							break;

			}
		}
	}

	public static void Siguiente_2()
	{
		bool afirmacion = true;

		while (afirmacion)
		{

			Console.Clear();
			Console.WriteLine(@"

 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|

");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("11) <<<<<<atras");
			Console.ForegroundColor = ConsoleColor.White;


			Console.WriteLine(@"



12) calcular segun la tasa de su hogar, cuanto debera pagar por dicho consumo.

13)cual es su edad.

14) convertir de celcius a farenheight o kervin

15) Calcular que cantidad de dinero se gastaría en un viaje.

16) video
");
			Console.Write("ingrese el numero que dese ingresar : ");
			string entrada = Console.ReadLine() ?? "";

			switch (entrada)
			{

				case "11":
					afirmacion = false;
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


			}
		}
	}

	//ejercicio - 1
	public static void Multiplicacion()
	{






		Console.Clear();
		color();
		Console.WriteLine(@"
 _____________________
/ ,-----------------. \
| |    1.05459 e -34| |
| `-----------------' |
| [@ ] On/Off  ###### |
|              ###### |
| [7] [8] [9] [C] [AC]|
|                     |
| [4] [5] [6] [X] [%] |
|                     |
| [1] [2] [3] [+] [-] |
|                     |
| [0] [.]  [EXP]  [=] |
\_____________________/
");
		int entrada1 , entrada2 = 0;
		int res = 0;

		Console.Write("Ingrese el primer dígito a multiplicar : ");
		int.TryParse( Console.ReadLine(), out entrada1);
		Console.Write("Ingrese el segundo dígito a multiplicar : ");
		int.TryParse(Console.ReadLine(), out entrada2);
		res = entrada1 * entrada2;
		Console.WriteLine("al multiplicar {1} con {2} da como resultado {0}" ,res , entrada1 , entrada2);
		Console.ReadKey();
	}
	//ejercicio - 2
	public static void Promedio()
	{
		Console.Clear();
		color();
        Console.WriteLine(@"
 _____________________
|  _________________  |
| | JO           0. | |
| |_________________| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|

");
		int entrada1, entrada2 = 0;
		int res = 0;
		Console.Write("Ingrese el primer dígito : ");
		int.TryParse(Console.ReadLine(), out entrada1);
		Console.Write("Ingrese el segundo dígito : ");
		int.TryParse(Console.ReadLine(), out entrada2);
		res = (entrada1 + entrada2)/2;
		Console.WriteLine( "el promedio de dichos numero es de : {0}" , res);
		Console.ReadKey();
	}
	//ejercicio - 3
	public static void Hipotenusa()
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
  ___                            ___
 ||  |   ___         ___        ||  |
 || _|__/  _\_______/  _\_______|| _|
 ||(___(  (________(  (_________||((_)
 ||  |  \___/       \___/       ||  |
 ||  |         ___              ||  |
 || _|________/  _\_____________|| _|
 ||(_________(  (_______________||((_)
 ||  |        \___/             ||  |
 ||  |                          ||  |
 ||  |                          ||  |
 ||  |                          ||  |

");
		double entrada1, entrada2 , res = 0.0;

		double hipotenusa;
		Console.Write(" ingrese cateto1 : ");
		double.TryParse(Console.ReadLine(), out entrada1);

		Console.Write(" ingrese cateto2 : ");
		double.TryParse(Console.ReadLine(), out entrada2);

		res = Math.Sqrt(Math.Pow(entrada1, 2) + Math.Pow(entrada2, 2));
		Console.WriteLine("la hipotenusa de cateo {1} y de cateto {2} es {0}", res , entrada1 , entrada2);
		Console.ReadKey();
	}
	//ejercicio - 4
	public static void Cateto()
	{

		Console.Clear();
		color();
		Console.WriteLine(@"
 __________
| ________ |
||12345678||
|""""""""""|
|[M|#|C][-]|
|[7|8|9][+]|
|[4|5|6][x]|
|[1|2|3][%]|
|[.|O|:][=]|
 ----------

");
		double entrada1, entrada2, res = 0.0;

		double hipotenusa;
		Console.Write("ingrese cateto1 : ");
		double.TryParse(Console.ReadLine(), out entrada1);

		Console.Write(" imgrese hipotenusa :");
		double.TryParse(Console.ReadLine(), out entrada2);

		res = Math.Sqrt(Math.Pow(entrada2, 2) - Math.Pow(entrada1, 2));
		Console.WriteLine("el cateto faltante es {0}" , res);
		Console.ReadKey();
	}
	//ejercicio - 5
	public static void Triangulo()
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
 __________
| ________ |
||12345678||
|""""""""""|
|[M|#|C][-]|
|[7|8|9][+]|
|[4|5|6][x]|
|[1|2|3][%]|
|[.|O|:][=]|
 ----------

");
		double entrada1, entrada2, res = 0.0;

		double hipotenusa;
		Console.Write(" ingrese la base : ");
		double.TryParse(Console.ReadLine(), out entrada1);

		Console.Write(" ingrese la altura :");
		double.TryParse(Console.ReadLine(), out entrada2);

		res = (entrada1 * entrada2)/2;
		Console.WriteLine( " el area de dicho triangulo es de area {0}" , res);
		Console.ReadKey();
	}
	//ejercicio - 6
	public static void Ecuaciones_segundo_grado()
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
           _            _       _             
          | |          | |     | |            
  ___ __ _| | ___ _   _| | __ _| |_ ___  _ __ 
 / __/ _` | |/ __| | | | |/ _` | __/ _ \| '__|
| (_| (_| | | (__| |_| | | (_| | || (_) | |   
 \___\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|

");
		double a , b , c = 0.0;
		double res3 , res2 , res1 , res , x1 , x2 = 0.0;

		Console.WriteLine(" ingrese el valor de A");
		double.TryParse(Console.ReadLine(), out a);

		Console.WriteLine("ingrese el valor de B");
		double.TryParse(Console.ReadLine(), out b);

		Console.WriteLine("ingrese el valor de C");
		double.TryParse(Console.ReadLine(), out c);

		res3 = Math.Pow(b, 2);
		res2 = -4 * a * c;
		res1 = res3 + res2;



		res = Math.Sqrt(res1);
		x1 = ( -(b) + res) / (2 * a);
		x2 = (-(b) - res) / (2 * a);


		if(x1.ToString() == "NaN" || x2.ToString() == "NaN")
        {

			Console.WriteLine("lo sentimos los numero que usted ingreso no se pueden aplicar la formula cuadratica");
		}
        else
        {
			Console.WriteLine("El valor x1 = {0} y el valor de x2 = {1}", x1, x2);
		}

	
		Console.ReadKey();

	}
	//ejercicio - 7
	public static void Caracteres()
	{
		Console.Clear();
		Console.WriteLine(@"
           _            _       _             
          | |          | |     | |            
  ___ __ _| | ___ _   _| | __ _| |_ ___  _ __ 
 / __/ _` | |/ __| | | | |/ _` | __/ _ \| '__|
| (_| (_| | | (__| |_| | | (_| | || (_) | |   
 \___\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|

");

		color();
		string entrada;
		int aumento = 0;
		Console.Write("ingrese un texto : ");
		entrada = Console.ReadLine()??"";
		while(aumento < entrada.Length) {
			aumento ++;

		}
		Console.WriteLine(aumento);
		Console.ReadKey();
	}
	//ejercicio - 8
	public static void Tickets_de_viajero()
	{
		Console.Clear();
		Console.WriteLine(@"
 _____________________
|  _________________  |
| |              /  | |
| |       /\    /   | |
| |  /\  /  \  /    | |
| | /  \/    \/     | |
| |/             JO | |
| |_________________| |
|  __ __ __ __ __ __  |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
| |__|__|__|__|__|__| |
|  ___ ___ ___   ___  |
| | 7 | 8 | 9 | | + | |
| |___|___|___| |___| |
| | 4 | 5 | 6 | | - | |
| |___|___|___| |___| |
| | 1 | 2 | 3 | | x | |
| |___|___|___| |___| |
| | . | 0 | = | | / | |
| |___|___|___| |___| |
|_____________________|
");

		color();
		int entrada ;
		double res;
		Console.WriteLine("Escribe texto");
		int.TryParse(Console.ReadLine(), out entrada);
		res = entrada / 35;
		Console.WriteLine("solo tienes {0} ticket" , res);
		Console.ReadKey();
	}
	//ejercicio - 9 *************************************
	public static void Hamburguesa()
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
                            |\ /| /|_/|
                          |\||-|\||-/|/|
                           \\|\|//||///
          _..----.._       |\/\||//||||
        .'     o    '.     |||\\|/\\ ||
       /   o       o  \    | './\_/.' |
      |o        o     o|   | .:.  .:. |
      /'-.._o     __.-'\   | :  ::  : |
      \      `````     /   | :  ''  : |
      |``--........--'`|    '.______.'
       \              /
        `'----------'`

");

		color();

		double paness, carness;
		double tocinetaa;
		double cantidad = 0.0;

		Console.Write("cuantos panes tienes : ");
		double.TryParse(Console.ReadLine(), out paness);

		Console.Write("cuantas carnes tienes : ");
		double.TryParse(Console.ReadLine(), out carness);

		Console.Write("cuantos  libra de tocineta tienes : ");
		double.TryParse(Console.ReadLine(), out tocinetaa);




		var carnes = (int)carness / 2;

		var tocineta = (int)tocinetaa / 0.2;

		var panes = (int)paness;


		if (panes < carnes && paness < tocineta) {
			cantidad = panes;
		}
		else if (carnes < panes && carnes < tocineta)
		{
			cantidad = carnes;
		}
		else if (tocineta < carnes && tocineta < panes)
		{
			cantidad = tocineta;
		}

		var cosas = Math.Min(carnes , panes);

		var final = Math.Min(cosas, tocineta);

		Console.WriteLine("la cantidad de hamburguesas es de {0}" , final);
		Console.ReadKey();

	}
	//ejercicio - 10
	public static void Dolar()
	{
		Console.Clear();
		Console.WriteLine(@"
   ||====================================================================||
   ||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||
   ||(100)==================| FEDERAL RESERVE NOTE |================(100)||
   ||\\$//        ~         '------========--------'                \\$//||
   ||<< /        /$\              // ____ \\                         \ >>||
   ||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||
   ||<<|        \\ //           || <||  >\  ||                        |>>||
   ||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||====================================================================||>||
||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||<||
||(100)==================| FEDERAL RESERVE NOTE |================(100)||>||
||\\$//        ~         '------========--------'                \\$//||\||
||<< /        /$\              // ____ \\                         \ >>||)||
||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||/||
||<<|        \\ //           || <||  >\  ||                        |>>||=||
||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||<<|      L38036133B        *\\  |\_/  //* series                 |>>||
||>>|  12                     *\\/___\_//*   1989                  |<<||
||<<\      Treasurer     ______/Franklin\________     Secretary 12 />>||
||//$\                 ~|UNITED STATES OF AMERICA|~               /$\\||
||(100)===================  ONE HUNDRED DOLLARS =================(100)||
||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
||====================================================================||
");

		color();

		int pesos = 0;
		float conversion = 0.0f;
		Console.Write("ingrese una cantidad en pesos");
		int.TryParse(Console.ReadLine(), out pesos);

		conversion = pesos / 55.15F;
		Console.WriteLine("La moneda introducida es {0}DOP en dolares es {1}USD   ", pesos ,conversion);

		Console.ReadKey();

	}
	//ejercicio - 11
	public static void Mitad_cuadrado_doble()
	
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
            _ _            _                                 _                          _       _     _      
           (_) |          | |                               | |                        | |     | |   | |     
  _ __ ___  _| |_ __ _  __| |  ______    ___ _   _  __ _  __| |_ __ ___    ______    __| | ___ | |__ | | ___ 
 | '_ ` _ \| | __/ _` |/ _` | |______|  / __| | | |/ _` |/ _` | '__/ _ \  |______|  / _` |/ _ \| '_ \| |/ _ \
 | | | | | | | || (_| | (_| |          | (__| |_| | (_| | (_| | | | (_) |          | (_| | (_) | |_) | |  __/
 |_| |_| |_|_|\__\__,_|\__,_|           \___|\__,_|\__,_|\__,_|_|  \___/            \__,_|\___/|_.__/|_|\___|
");
		color();


		double entrada;
		Console.WriteLine("entre algo perro");
		double.TryParse(Console.ReadLine(), out entrada);

		double mitad, cuadrado , doble = entrada;
		mitad = entrada / 2;
		cuadrado = Math.Pow( entrada , 2);
		doble = entrada * 2;
		Console.WriteLine("mitad {0} , cuadrado {1} , doble {2} ",mitad,cuadrado,doble);
		Console.ReadKey();
	}
	//ejercicio - 12 *************************************
	public static void Energia()
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
            _ _            _                                 _                          _       _     _      
           (_) |          | |                               | |                        | |     | |   | |     
  _ __ ___  _| |_ __ _  __| |  ______    ___ _   _  __ _  __| |_ __ ___    ______    __| | ___ | |__ | | ___ 
 | '_ ` _ \| | __/ _` |/ _` | |______|  / __| | | |/ _` |/ _` | '__/ _ \  |______|  / _` |/ _ \| '_ \| |/ _ \
 | | | | | | | || (_| | (_| |          | (__| |_| | (_| | (_| | | | (_) |          | (_| | (_) | |_) | |  __/
 |_| |_| |_|_|\__\__,_|\__,_|           \___|\__,_|\__,_|\__,_|_|  \___/            \__,_|\___/|_.__/|_|\___|
");
		color();

		double energia = 0;
		double precio, res = 0;
		precio = 51.19;


		Console.WriteLine(" El precio de la taza de energia es de {0}DOP por kWh: " , precio);

		Console.Write("cantidad de energía consume su  casa al mes(kWh) : ");
		double.TryParse(Console.ReadLine(), out energia);

		res = (energia * precio);

		Console.Write("");
		Console.WriteLine(" si la taza de su hogal es de {0}  por kWh usted gastara RD{1} ", precio , res);

		Console.ReadKey();
	}
	//ejercicio - 13
	public static void Edad()
	{
		Console.Clear();
		color();
		Console.WriteLine(@"
 /$$$$$$$$       /$$                 /$$
| $$_____/      | $$                | $$
| $$        /$$$$$$$  /$$$$$$   /$$$$$$$
| $$$$$    /$$__  $$ |____  $$ /$$__  $$
| $$__/   | $$  | $$  /$$$$$$$| $$  | $$
| $$      | $$  | $$ /$$__  $$| $$  | $$
| $$$$$$$$|  $$$$$$$|  $$$$$$$|  $$$$$$$
|________/ \_______/ \_______/ \_______/
                                        

");
		color();

		int entrada1 , entrada2 = 0;
		int res = 0;


		Console.Write("ingrese fecha de nacimiento : ");
		int.TryParse(Console.ReadLine(), out entrada1);

		Console.Write("ingrese el año en curso : ");
		int.TryParse(Console.ReadLine(), out entrada2);

		res = entrada1 - entrada2;

		Console.WriteLine("usted tiene {0} años" ,res);
		Console.ReadKey();
	}
	//ejercicio - 14
	public static void Temperatura()
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(@"

                                ████                                  
                                ██▒▒██          ████                  
                                ██▒▒██          ██▒▒██                
                                ██▒▒██          ██▒▒██                
                                ██▒▒████        ██▒▒██                
                                ██▒▒▒▒██        ██▒▒██                
                                ██▒▒░░████      ██████                
                                ██▒▒  ▒▒██▓▓██            ██▓▓        
                                ██▒▒░░  ▒▒▒▒██          ██▒▒██        
                                ██▒▒░░░░░░▒▒██▓▓██      ██▒▒██        
                                ██▒▒░░░░░░  ▒▒▒▒██      ██▒▒██        
                                ██▒▒░░░░░░░░░░▒▒██▓▓    ██▒▒██        
                                ████▒▒  ░░░░░░  ▒▒██    ██▒▒██        
                ████              ██▒▒  ░░░░░░░░▒▒██    ██▒▒██        
              ██▒▒██      ████    ██▒▒  ░░░░░░░░▒▒██    ██▒▒██        
              ██▒▒██    ▓▓▒▒██    ██▒▒  ░░░░░░░░▒▒██    ██▒▒██        
              ██▒▒██    ██▒▒██    ██▒▒  ░░░░░░░░▒▒██    ██▒▒██        
    ▓▓▓▓      ██▒▒██    ██▒▒██▓▓▓▓██▒▒  ░░░░░░░░▒▒██    ██▒▒██        
    ██▒▒██    ██▒▒██    ██▒▒▒▒▒▒▒▒▒▒  ░░░░░░░░░░▒▒██    ██████        
    ██▒▒██    ██▒▒██    ██▒▒░░░░░░░░░░░░░░░░░░░░▒▒██                  
    ██▒▒██    ██████    ██▒▒░░░░░░░░░░░░░░░░░░▒▒████                  
    ██▒▒██    ░░░░░░    ██▒▒░░░░░░░░░░░░░░░░▒▒▒▒██          ▓▓▓▓      
    ██▒▒██              ████▒▒░░░░░░░░░░░░▒▒██████        ██▒▒██      
  ████▒▒██                ██▒▒░░░░░░░░░░░░▒▒██  ░░        ██▒▒██      
  ██▒▒▒▒██                ██▒▒░░░░░░░░░░░░▒▒██            ██▒▒██      
  ██▒▒▒▒██      ████      ██▒▒░░░░░░░░░░░░▒▒██████        ██▒▒██      
  ████▒▒██    ██▒▒██      ██▒▒░░░░░░░░░░░░  ▒▒▒▒████      ██▒▒████    
  ████▒▒██    ██▒▒██      ██▒▒░░░░░░░░░░░░░░▒▒▒▒▓▓██      ██▒▒▓▓██    
    ██▒▒██    ██▒▒██      ██▒▒░░░░░░░░░░░░░░░░░░▒▒██▒▒    ██▒▒▒▒██    
    ██▓▓██    ██▒▒████    ██▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒██    ██▒▒▒▒██    
              ██▒▒▒▒██    ██▒▒░░░░░░░░░░░░░░░░░░░░▒▒██    ██▒▒░░██    
          ▒▒▒▒██░░▒▒██  ▒▒██▒▒░░░░░░░░░░░░░░░░▒▒▓▓▓▓██    ██▒▒  ██    
          ██▒▒▒▒  ▒▒██  ██▒▒░░░░░░░░░░░░░░░░░░▒▒██        ██▒▒  ██    
        ████░░░░  ▒▒██  ██▒▒░░░░░░░░░░░░░░░░░░▒▒██    ▒▒████▒▒  ████  
      ██▒▒▒▒░░░░  ▒▒██  ██▒▒░░░░░░░░░░░░░░░░░░▒▒██    ██▒▒▒▒░░░░▒▒████
      ██▒▒░░░░░░  ▒▒██████▒▒░░░░░░░░░░░░░░░░░░▒▒████████▒▒▒▒░░░░░░▒▒██
      ██▒▒░░░░░░░░  ▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒  ░░░░░░░░▒▒██
      ██▒▒░░░░░░░░░░░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██
      ██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██
  ▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██
  ██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██
  ██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██
  ██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██
  ██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒████
  ████▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒██  
  ░░░░██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓██  
      ██████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████    
      ░░  ██▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒██  ░░    
          ████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒██████        
              ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██            
              ████████████████████████████████████████████            
⠀⠀

");
		color();
		

		float entrada1 = 0;
		double fa , ke = 0;


		Console.Write("ingrese grados celcius :");
		float.TryParse(Console.ReadLine(), out entrada1);

		fa = (entrada1 * 1.8) + 32;
		ke = entrada1  + 273.15;
		Console.WriteLine( "los celcius que ingresaste en farenheit es {0} y en kervin {1}",fa,ke);
		Console.ReadKey();
	}
	//ejercicio - 15
	public static void Corre()
	{
		color();
		Console.WriteLine(@"
                       ____________________
                     //|           |        \
                   //  |           |          \
      ___________//____|___________|__________()\__________________
    /__________________|_=_________|_=___________|_________________{}
    [           ______ |           | .           | ==  ______      { }
  __[__        /##  ##\|           |             |    /##  ##\    _{# }_
 {_____)______|##    ##|___________|_____________|___|##    ##|__(______}
             /  ##__##                              /  ##__##        \
----------------------------------------------------------------------------
                                        

");
		color();

		float entrada1 , entrada2 = 0;
		double precio , res = 0;
		precio = 293.60;


		Console.WriteLine("la gasolina esta a RD {0} el galon" , precio);

		Console.Write("cantidad de km por galón :");
		float.TryParse(Console.ReadLine(), out entrada1);

		Console.Write("distancia a recorrer :");
		float.TryParse(Console.ReadLine(), out entrada2);

		res = (entrada1 / entrada2) * precio;

		Console.WriteLine("");
		Console.WriteLine("usted gastara RD{0} ", res);

		Console.ReadKey();
	}
	//ejercicio - 16  ************************************
	public static void Video()
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(@"
░░░░░░░░░░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░
██░░██░░░░░░░░░░░▄█░░░░░░████░░████████▄
██▄▄██░░░░░░░░░░░████░░██████░░█████████
▀████▀░████░█░░█░████░░█░██░█░▄▄░█░░▄▄██
░░██░░░█░░█░█▄▄█░████░░█░░░░█░▀▀░█░░▄▄██
░░██░░░████░████░▀███▄▄█▄▄▄▄█▄▄▄▄█▄▄▄▄█▀
░░░░░░░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀░░
                                        

");
		color();


		var uri = "https://youtu.be/n7yO72ryv8s";
		var psi = new System.Diagnostics.ProcessStartInfo();
		psi.UseShellExecute = true;
		psi.FileName = uri;
		System.Diagnostics.Process.Start(psi);
		color();



	}
	public static void color()
    {
		
		Random r = new Random();

				int coco = r.Next(1,9);

				if (coco == 1) {
					Console.ForegroundColor = ConsoleColor.Blue;
				} else if (coco == 2) {
					Console.ForegroundColor = ConsoleColor.Cyan;
				}
				else if (coco == 3)
				{
			        Console.ForegroundColor = ConsoleColor.Green;
		}
		else if (coco == 4)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
		}
		else if (coco == 5)
		{
			Console.ForegroundColor = ConsoleColor.Magenta;
		}
		else if (coco == 6)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
		else if (coco == 7)
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		else if (coco == 8)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
		}

		else if (coco == 9)
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
		}



	}
}
