using System;
using System.Linq;
using misClases;

////////Punto 1///////
/*double valorDouble;
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

//////////Punto 2////////////
Empleado[] misEmpleados = new Empleado[3];

misEmpleados[0] = new Empleado
{
    Nombre = "Juan",
    Apellido = "Perez",
    FechaNacimiento = new DateTime(1980, 5, 15),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2005, 6, 1),
    SueldoBasico = 650000,
    Cargo = "Ingeniero"
};

misEmpleados[1] = new Empleado
{
    Nombre = "Ana",
    Apellido = "Gomez",
    FechaNacimiento = new DateTime(1975, 3, 10),
    EstadoCivil = 'S',
    FechaIngreso = new DateTime(1995, 8, 20),
    SueldoBasico = 500000,
    Cargo = "Especialista"
};

misEmpleados[2] = new Empleado
{
    Nombre = "Luis",
    Apellido = "Martinez",
    FechaNacimiento = new DateTime(1990, 11, 23),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2012, 2, 15),
    SueldoBasico = 450000,
    Cargo = "Analista",
};

// Calcular el monto total de salarios
double montoTotalSalarios = misEmpleados.Sum(e => e.CalcularSalario());
Console.WriteLine($"Monto total de salarios: ${montoTotalSalarios}");
// Encontrar el empleado más próximo a jubilarse
Empleado proximoJubilacion = misEmpleados.OrderBy(e => e.AniosParaJubilacion).First();

Console.WriteLine("Empleado más próximo a jubilarse");
Console.WriteLine($"Nombre: {proximoJubilacion.Nombre}");
Console.WriteLine($"Apellido: {proximoJubilacion.Apellido}");
Console.WriteLine($"Edad: {proximoJubilacion.Edad}");
Console.WriteLine($"Antigüedad: {proximoJubilacion.Antiguedad}");
Console.WriteLine($"Años para jubilación: {proximoJubilacion.AniosParaJubilacion}");
Console.WriteLine($"Salario: {proximoJubilacion.CalcularSalario()}");

