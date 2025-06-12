namespace ToDoTarea
{

    public class Tarea
    {
        public int tareaID;
        public string descripcion;
        public int duracion;

        public void validarDuracion()
        {
            string duracionTarea;

            do
            {
                Console.WriteLine("Ingrese la duracion de la tarea");

                duracionTarea = Console.ReadLine();

                if (!int.TryParse(duracionTarea, out duracion) || !(duracion >= 10) || !(duracion <= 100))
                {
                    Console.WriteLine("Escribiste mal la duracion pibe");
                }

            } while (!int.TryParse(duracionTarea, out duracion) || !(duracion >= 10) || !(duracion <= 100));


        }

        public static void mostrarTareasPendientes(List<Tarea> tareasPendientes)
        {
            foreach (Tarea t in tareasPendientes)
            {
                Console.WriteLine("-------DATOS TAREAS PENDIENTES-------");
                Console.WriteLine("Tarea ID:" + t.tareaID);
                Console.WriteLine("Tarea descripcion:" + t.descripcion);
                Console.WriteLine("Tarea duracion:" + t.duracion);
                Console.WriteLine("-----------------------------------------------");
            }
        }

        public static int validarRespuesta()
        {



            string cant_tareas;

            int cantTareas = 0;


            do
            {
                Console.WriteLine("Ingrese cuantas tareas desea mover");

                cant_tareas = Console.ReadLine();

                if (!int.TryParse(cant_tareas, out cantTareas))
                {
                    Console.WriteLine("Vuelva a escribir la cantidad de tareas maestro");
                }
                if (cantTareas < 0)
                {
                    Console.WriteLine("Bro, no podes mover esa cantidad de tareas, elegi un valor valido dale c:");
                }
                if (cantTareas == 0)
                {
                    Console.WriteLine("Ok, entonces no movamos ninguna");
                    
                }

            } while (!int.TryParse(cant_tareas, out cantTareas) || cantTareas < 0);




            return cantTareas;
        }


        public static int[] agregarID(int cantTareas, List<Tarea> tareasPendientes, int numeroTareas)
        {
            int[] IdTareas = new int[cantTareas];



            for (int i = 0; i < cantTareas; i++)
            {
                int id;
                bool valido;
                do
                {


                    Console.WriteLine("Ingrese el id de la tarea: " + (i + 1));

                    string id_num = Console.ReadLine();

                    valido = false;

                    if (int.TryParse(id_num, out id))
                    {

                        foreach (Tarea t in tareasPendientes)
                        {
                            if (t.tareaID == id)
                            {
                                valido = true;
                                break;
                            }
                        }

                        Console.WriteLine("Se ha cambiado el contenido de la lista");

                    }
                    if (!valido)
                    {
                        Console.WriteLine("No hay ninguna tarea con ese id maestro, proba de nuevo");
                    }

                } while (!valido);

                IdTareas[i] = id;
            }

            return IdTareas;
        }

        public static void moverTareas(int[] idTarea, List<Tarea> tareasRealizadas, List<Tarea> tareasPendientes, int numeroTareas)
        {

            List<Tarea> tareasParaMover = new List<Tarea>();

            foreach (int id in idTarea)
            {
                foreach (Tarea t in tareasPendientes)
                {
                    if (id == t.tareaID)
                    {
                        tareasParaMover.Add(t);
                        break;
                    }
                }
            }
            foreach (Tarea t in tareasParaMover)
            {
                tareasRealizadas.Add(t);
                tareasPendientes.Remove(t);

            }

        }

        public static void buscarTarea(List<Tarea> tareasPendientes)
        {

            bool valido;

            string respuesta;

            do
            {

                bool encontrada = false;

                do
                {
                    Console.WriteLine("Ingrese la descripcion");

                    string descripcionBuscar = Console.ReadLine();

                    foreach (Tarea t in tareasPendientes)
                    {
                        if (descripcionBuscar == t.descripcion)
                        {
                            Console.WriteLine("------Tarea pendiente buscada------");
                            Console.WriteLine("Id de la tarea: " + t.tareaID);
                            Console.WriteLine("descripcion de la tarea: " + t.descripcion);
                            Console.WriteLine("duracion de la tarea: " + t.duracion);
                            encontrada = true;
                        }

                    }

                    if (!encontrada)
                    {
                        Console.WriteLine("no existe tarea con esa descripcion ,proba otra");
                    }
                } while (!encontrada);

                do
                {
                    Console.WriteLine("Desea buscar alguna otra tarea por descripcion? (si/no)");

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

            } while (respuesta == "si");

            Console.WriteLine("De una maestro 😎");
        }


    }

}