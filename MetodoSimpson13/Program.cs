// Título
using MetodoSimpson13.utils;

Console.WriteLine(new string('-', 60));
Console.WriteLine("Método de Simpson 1/3");
Console.WriteLine(new string('-', 60));

bool continuar = false;
do
{
    // Selección de la ecuación para integrar
    Console.WriteLine("Seleccione la ecuación a integrar:");
    Console.WriteLine("1. x^2 + 2x + 1");
    Console.WriteLine("2. x^3 + 2x^2 + 3x + 4");
    Console.WriteLine("3. x^4 + 2x^3 + 3x^2 + 4x + 5");
    Console.Write(">>");
    int opcion = int.Parse(Console.ReadLine()!);

    Func<double, double> f = opcion switch
    {
        1 => x => Ecuaciones.EqUno(x),
        2 => x => Ecuaciones.EqDos(x),
        3 => x => Ecuaciones.EqTres(x),
        _ => throw new ArgumentException("Opción no válida.")
    };

    // Selección de los límites de integración y el número de intervalos
    Console.WriteLine("Ingrese el limite inferior de la integral:");
    Console.Write(">>");
    double lim_inf = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Ingrese el limite superior de la integral:");
    Console.Write(">>");
    double lim_sup = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Ingrese el número de intervalos (debe ser par):");
    Console.Write(">>");
    int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine("¿Desea ver información adicional? (s/n)");
    Console.Write(">>");
    bool info = Console.ReadLine()!.ToLower() == "s";

    if (info) Console.WriteLine(new string('-', 60));

    // Calcular la integral
    double resultado = Simpson13.Calcular(f, lim_inf, lim_sup, n, info);

    Console.WriteLine(new string('-', 60));

    // Impresión de resultados
    Console.WriteLine($"El resultado de la integral es: {resultado} u^2");

    Console.WriteLine(new string('-', 60));

    Console.WriteLine("¿Desea realizar otra operación? (s/n)");
    Console.Write(">>");
    continuar = Console.ReadLine()!.ToLower() == "s";

} while (continuar != false);