﻿using espacioCalculadora;

int num = 0;
double numero;
string opcion, opcion_numero;
Calculadora miCalculadora = new Calculadora();
List<Operacion> TipoOperacion = new List<Operacion>();
double resultadoAnterior = 0;
do
{
    Operacion historial = new Operacion();
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

    resultadoAnterior = miCalculadora.Resultado;

    switch (num)
    {
        case 1:

            resultadoAnterior = miCalculadora.Sumar(numero);

            historial.OperacionTipo = Operacion.TipoOperacion.Suma;

            break;

        case 2:
            resultadoAnterior = miCalculadora.Restar(numero);

            historial.OperacionTipo = Operacion.TipoOperacion.Resta;

            break;

        case 3:
            resultadoAnterior = miCalculadora.Multiplicar(numero);

            historial.OperacionTipo = Operacion.TipoOperacion.Multiplicacion;

            break;

        case 4:
            resultadoAnterior = miCalculadora.Dividir(numero);

            historial.OperacionTipo = Operacion.TipoOperacion.Division;

            break;

    }


    historial.resultado_anterior = resultadoAnterior;



    historial.nuevo_valor = numero;

    TipoOperacion.Add(historial);




} while (num != 0);

foreach (Operacion t in TipoOperacion)
{
    Console.WriteLine("----------historial---------- ");
    Console.WriteLine("Operacion: " + t.OperacionTipo);
    Console.WriteLine("nuevo numero ingresado: " + t.nuevo_valor);
    Console.WriteLine("Resultado: " + t.resultado_anterior);
    
}