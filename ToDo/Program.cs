using ToDoTarea;

List<Tarea> tareasPendientes = new List<Tarea>();

List<Tarea> tareasRealizadas = new List<Tarea>();

Random numeroAleatorio = new Random();

int numTareas = 0, opcion; ;

string opcion_texto, numTareas_texto;

bool valido = false;
do
{



    do
    {
        Console.WriteLine("-------Menu-------");
        Console.WriteLine("1-Agregar Tarea/s");
        Console.WriteLine("2-Ver tareas Pendientes");
        Console.WriteLine("3-marcar tarea como realizada");
        Console.WriteLine("4-Ver tareas Realizadas");
        Console.WriteLine("5-Consultar tarea por descripcion (solo tareas pendientes)");
        Console.WriteLine("0-salir");

        opcion_texto = Console.ReadLine();

        if (!int.TryParse(opcion_texto, out opcion) || (opcion < 0 || opcion > 5))
        {
            Console.WriteLine("Opcion ingresada invalida...");
        }

    } while (!int.TryParse(opcion_texto, out opcion) || (opcion < 0 || opcion > 5));

    if (opcion == 0)
    {
        break;
    }

    switch (opcion)
    {
        case 1:
            do
            {
                Console.WriteLine("Ingrese cuantas tareas desea agregar");

                numTareas_texto = Console.ReadLine();

                if (!int.TryParse(numTareas_texto, out numTareas) || numTareas <= 0)
                {
                    Console.WriteLine("numero ingresado invalido...");
                }
            } while (!int.TryParse(numTareas_texto, out numTareas) || numTareas <= 0);

            for (int i = 0; i < numTareas; i++)
            {

                Tarea nueva = new Tarea();

                nueva.tareaID = 1 + i;

                Console.WriteLine("Ingrese una descripcion de la tarea: " + (i + 1));

                nueva.descripcion = Console.ReadLine();

                nueva.validarDuracion();

                tareasPendientes.Add(nueva);

            }

            break;

        case 2:

            Tarea.mostrarTareasPendientes(tareasPendientes);

            break;

        case 4:

            if (tareasRealizadas.Count == 0)
            {
                Console.WriteLine("La lista de tareas realizadas esta vacia");
            }
            else
            {
                foreach (Tarea t in tareasRealizadas)
                {
                    Console.WriteLine("-------DATOS TAREAS REALIZADAS-------");
                    Console.WriteLine("Tarea ID:" + t.tareaID);
                    Console.WriteLine("Tarea descripcion:" + t.descripcion);
                    Console.WriteLine("Tarea duracion:" + t.duracion);
                    Console.WriteLine("-----------------------------------------------");
                }
            }


            break;

        case 3:


            int cantTareas = Tarea.validarRespuesta();

            if (!(cantTareas == 0))
            {
                int[] Id_a_mover = Tarea.agregarID(cantTareas, tareasPendientes, numTareas);

                Tarea.moverTareas(Id_a_mover, tareasRealizadas, tareasPendientes, numTareas);

            }

            break;


        case 5:


            Tarea.buscarTarea(tareasPendientes);

            break;
    }

    string respuesta;

    do
    {
        Console.WriteLine("desea realizar alguna otra operacion? (si/no)");

        respuesta = Console.ReadLine().ToLower();

        if (respuesta != "no" && respuesta != "si")
        {
            valido = false;
            Console.WriteLine("Respuesta invalida...");
        }
        else
        {
            valido = true;
        }

    } while (!valido);


} while (valido);

Console.WriteLine("Nos vemos rey");