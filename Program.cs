////////Punto 1///////
/*using ClasesCalculadora;

//Calculadora miCalculadora = new Calculadora(acá mando el valorInicial como parametro asi lo inicializo);
double valorDouble;

Console.Write("Ingrese un numero: ");
string valor = Console.ReadLine();
double.TryParse(valor, out valorDouble);
Calculadora miCalculadora = new Calculadora(valorDouble);

string opcion, num1;
int opcionConvert;
double num1Convert, resultado;
do
{
    Console.WriteLine("\n");
    Console.WriteLine("Menu Principal:");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) Restar");
    Console.WriteLine("3) Multiplicar");
    Console.WriteLine("4) Dividir");
    Console.WriteLine("5) Limpiar");
    Console.WriteLine("6) Salir");
    Console.Write("Ingrese la opcion deseada:");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionConvert);

    switch (opcionConvert)
    {
        case 1:
            Console.Write("Ingrese el numero que se sumara al valor ingresado anteriormente: ");
            num1 = Console.ReadLine();
            double.TryParse(num1, out num1Convert);
            miCalculadora.Sumar(num1Convert);
            resultado = miCalculadora.Resultado;
            Console.WriteLine("El resultado obtenido es: " + resultado);
            break;
        case 2:
            Console.Write("Ingrese el numero que se restara al valor ingresado anteriormente: ");
            num1 = Console.ReadLine();
            double.TryParse(num1, out num1Convert);
            miCalculadora.Restar(num1Convert);
            resultado = miCalculadora.Resultado;
            Console.WriteLine("El resultado obtenido es: " + resultado);
            break;
        case 3:
            Console.Write("Ingrese el numero que se multiplicara con el valor ingresado anteriormente: ");
            num1 = Console.ReadLine();
            double.TryParse(num1, out num1Convert);
            miCalculadora.Multiplicar(num1Convert);
            resultado = miCalculadora.Resultado;
            Console.WriteLine("El resultado obtenido es: " + resultado);
            break;
        case 4:
            Console.Write("Ingrese el numero que dividira al valor ingresado anteriormente: ");
            num1 = Console.ReadLine();
            double.TryParse(num1, out num1Convert);
            miCalculadora.Dividir(num1Convert);
            resultado = miCalculadora.Resultado;
            Console.WriteLine("El resultado obtenido es: " + resultado);
            break;
        case 5:
            miCalculadora.Limpiar();
            Console.WriteLine("El valor fue limpiado correctamente");
            resultado = miCalculadora.Resultado;
            Console.WriteLine("El resultado obtenido es: " + resultado);
            break;
        case 6:
            break;
        default:
            break;
    }

} while (opcionConvert != 1 && opcionConvert != 2 && opcionConvert != 3 && opcionConvert != 4 && opcionConvert != 5 && opcionConvert != 6);
*/


