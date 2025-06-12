using espacioCalculadora;

int num = 0;
double numero;
string opcion, opcion_numero;
Calculadora miCalculadora = new Calculadora();
List<Operacion> TipoOperacion = new List<Operacion>();
do
{
    Console.WriteLine("----------------------------MENU----------------------------");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-multiplicar");
    Console.WriteLine("4-dividir");
    Console.WriteLine("0-salir");

    opcion = Console.ReadLine();

    while (!int.TryParse(opcion, out num) || !(num <= 4) || !(num >= 0))
    {
        Console.WriteLine("Ingrese un dato valido porfavor");
        opcion = Console.ReadLine();
    }

    if (num == 0)
    {
        Console.WriteLine("Gracias por usar mi calculadora maestro.");
        break;
    }

    Console.WriteLine("Ingresa cualquier numero");
    opcion_numero = Console.ReadLine();

    while (!double.TryParse(opcion_numero, out numero))
    {
        Console.WriteLine("Ingrese un dato valido porfavor");
        opcion_numero = Console.ReadLine();
    }

    switch (num)
    {
        case 1:

            miCalculadora.Sumar(numero);

            break;

        case 2:
            miCalculadora.Restar(numero);
            break;

        case 3:
            miCalculadora.Multiplicar(numero);
            break;

        case 4:
            miCalculadora.Dividir(numero);
            break;

    }

} while (num != 0);