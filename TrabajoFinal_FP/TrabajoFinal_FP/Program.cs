namespace TrabajoFinal_FP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("    SISTEMA DE GESTIÓN DEL HOTEL    ");
                Console.WriteLine("1. Gestión de Habitaciones");
                Console.WriteLine("2. Gestión de Huéspedes");
                Console.WriteLine("3. Gestión de Reservas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("====================================");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MenuHabitaciones();
                        break;
                    case 2:
                        MenuHuespedes();
                        break;
                    case 3:
                        MenuReservas();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);

        }

        static void MenuHabitaciones()
        {
            int opcion;
            do
            {
                Console.WriteLine("=== Gestión de Habitaciones ===");
                Console.WriteLine("1. Registrar Habitación");
                Console.WriteLine("2. Mostrar Habitaciones");
                Console.WriteLine("3. Modificar Habitación");
                Console.WriteLine("4. Eliminar Habitación");
                Console.WriteLine("5. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Registrar Habitación");
                        break;
                    case 2:
                        Console.WriteLine("Mostrar Habitaciones");
                        break;
                    case 3:
                        Console.WriteLine("Modificar Habitación");
                        break;
                    case 4:
                        Console.WriteLine("Eliminar Habitación");
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al Menú Principal...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 5);
        }

        static void MenuHuespedes()
        {
            int opcion;
            do
            {
                Console.WriteLine("=== Gestión de Huéspedes ===");
                Console.WriteLine("1. Registrar Huésped");
                Console.WriteLine("2. buscar Huésped");
                Console.WriteLine("3. Modificar Huésped");
                Console.WriteLine("4. Eliminar Huésped");
                Console.WriteLine("5. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Registrar Huésped");
                        break;
                    case 2:
                        Console.WriteLine("buscar Huéspedes");
                        break;
                    case 3:
                        Console.WriteLine("Modificar Huésped");
                        break;
                    case 4:
                        Console.WriteLine("Eliminar Huésped");
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al Menú Principal...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 5);
        }

        static void MenuReservas()
        {
            int opcion;
            do
            {
                Console.WriteLine("=== Gestión de Reservas ===");
                Console.WriteLine("1. Registrar Reserva");
                Console.WriteLine("2. Mostrar Reservas");
                Console.WriteLine("3. Modificar Reserva");
                Console.WriteLine("4. Eliminar Reserva");
                Console.WriteLine("5. MOstrar todas las Reservas");
                Console.WriteLine("6. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Registrar Reserva");
                        break;
                    case 2:
                        Console.WriteLine("Mostrar Reservas");
                        break;
                    case 3:
                        Console.WriteLine("Modificar Reserva");
                        break;
                    case 4:
                        Console.WriteLine("Eliminar Reserva");
                        break;
                    case 5:
                        Console.WriteLine("Mostrar todas las Reservas");
                        break;
                    case 6:
                        Console.WriteLine("Volviendo al Menú Principal...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 5);
        }

        static int maxHabitaciones = 20;
        static int[] numeroHabitación = new int[maxHabitaciones];
        static string[] tipoHabitación = new string[maxHabitaciones];
        static double[] precioHabitación = new double[maxHabitaciones];
        static bool[] disponibilidadHabitación = new bool[maxHabitaciones];
        static int contadorHabitaciones = 0;

        static void RegistrarHabitacion()
        {
            if (contadorHabitaciones < maxHabitaciones)
            {
                Console.WriteLine("=== Registro de Habitación ===");

                Console.Write("Ingrese el número de habitación: ");
                numeroHabitación[contadorHabitaciones] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el tipo de habitación (Sencilla, Doble, Suite): ");
                tipoHabitación[contadorHabitaciones] = Console.ReadLine();

                Console.Write("Ingrese el precio de la habitación: ");
                precioHabitación[contadorHabitaciones] = double.Parse(Console.ReadLine());

                Console.Write("¿La habitación está disponible? (1=Si, 2=No): ");
                int disponibilidadHabitacion = int.Parse(Console.ReadLine());
                disponibilidadHabitación[contadorHabitaciones] = true; // Por defecto, la habitación está disponible

                contadorHabitaciones++;
                Console.WriteLine("Habitación registrada exitosamente.");
            }
            else
            {
                Console.WriteLine("No se pueden registrar más habitaciones. Capacidad máxima alcanzada.");
            }
        }

        static void MostrarHabitaciones()
        {
            Console.WriteLine("=== Lista de Habitaciones ===");

            if (contadorHabitaciones == 0)
            {
                Console.WriteLine("No hay habitaciones registradas.");
                return;
            }
            else
            {
                for (int i = 0; i < contadorHabitaciones; i++)
                {
                    Console.WriteLine("Número de Habitación: " + numeroHabitación[i]);
                    Console.WriteLine("Tipo de Habitación: " + tipoHabitación[i]);
                    Console.WriteLine("Precio de Habitación: $" + precioHabitación[i]);
                    Console.WriteLine("Disponibilidad: " + (disponibilidadHabitación[i] ? "Si" : "No"));
                }
            }
        }

        static void ModificarHabitacion()
        {
            Console.WriteLine("=== Modificar Habitación ===");

            Console.Write("Ingrese el número de habitación a modificar: ");
            int numHabitacion = int.Parse(Console.ReadLine());
            int indice = -1;

            for (int i = 0; i < contadorHabitaciones; i++)
            {
                if (numeroHabitación[i] == numHabitacion)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine("Ingrese nuevo tipo de habitación: ");
                tipoHabitación[indice] = Console.ReadLine();

                Console.WriteLine("Ingrese nuevo precio de habitación: ");
                precioHabitación[indice] = double.Parse(Console.ReadLine());

                Console.WriteLine("¿La habitación está disponible? (1=Si, 2=No): ");
                int disponibilidadHabitacion = int.Parse(Console.ReadLine());
                disponibilidadHabitación[indice] = (disponibilidadHabitacion == 1);

                Console.WriteLine("Habitación modificada exitosamente.");
            }
            else
            {
                Console.WriteLine("Habitación no encontrada.");
            }
        }

        static void EliminarHabitación()
        {
            Console.WriteLine("=== Eliminar Habitación ===");

            Console.Write("Ingrese el número de habitación a eliminar: ");
            int numHabitacion = int.Parse(Console.ReadLine());
            int indice = -1;

            for (int i = 0; i < contadorHabitaciones; i++)
            {
                if (numeroHabitación[i] == numHabitacion)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                for (int j = indice; j < contadorHabitaciones - 1; j++)
                {
                    numeroHabitación[j] = numeroHabitación[j + 1];
                    tipoHabitación[j] = tipoHabitación[j + 1];
                    precioHabitación[j] = precioHabitación[j + 1];
                    disponibilidadHabitación[j] = disponibilidadHabitación[j + 1];
                }

                contadorHabitaciones--;
                Console.WriteLine("Habitación eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("Habitación no encontrada.");
            }
        }

        static int maxHuespedes = 20;
        static string[] nombreHuesped = new string[maxHuespedes];
        static string[] documentoHuesped = new string[maxHuespedes];
        static string[] telefonoHuesped = new string[maxHuespedes];
        static string[] emailHuesped = new string[maxHuespedes];
        static string[] nacionalidadHuesped = new string[maxHuespedes];
        static int contadorHuespedes = 0;

        static void RegistrarHuesped()
        {
            if (contadorHuespedes < maxHuespedes)
            {
                Console.WriteLine("=== Registro de Huésped ===");

                Console.Write("Ingrese el nombre completo del huésped: ");
                nombreHuesped[contadorHuespedes] = Console.ReadLine();

                Console.Write("Ingrese el documento de indentidad del huésped: ");
                documentoHuesped[contadorHuespedes] = Console.ReadLine();

                Console.Write("Ingrese el teléfono del huésped: ");
                telefonoHuesped[contadorHuespedes] = Console.ReadLine();

                Console.Write("Ingrese el email del huésped: ");
                emailHuesped[contadorHuespedes] = Console.ReadLine();

                Console.Write("Ingrese la nacionalidad del huésped: ");
                nacionalidadHuesped[contadorHuespedes] = Console.ReadLine();

                contadorHuespedes++;
                Console.WriteLine("Huésped registrado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se pueden registrar más huéspedes. Capacidad máxima alcanzada.");
            }
        }

        static void MostrarHuespedes()
        {
            Console.WriteLine("=== Lista de Huéspedes ===");

            if (contadorHuespedes == 0)
            {
                Console.WriteLine("No hay huéspedes registrados.");
                return;
            }
            else
            {
                for (int i = 0; i < contadorHuespedes; i++)
                {
                    Console.WriteLine("Nombre del Huésped: " + nombreHuesped[i]);
                    Console.WriteLine("Documento de Identidad: " + documentoHuesped[i]);
                    Console.WriteLine("Teléfono: " + telefonoHuesped[i]);
                    Console.WriteLine("Email: " + emailHuesped[i]);
                    Console.WriteLine("Nacionalidad: " + nacionalidadHuesped[i]);
                }
            }
        }

        static void BuscarHuesped()
        {
            Console.WriteLine("=== Buscar Huésped ===");
            Console.Write("Ingrese el documento de identidad del huésped a buscar: ");
            string docHuesped = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < contadorHuespedes; i++)
            {
                if (documentoHuesped[i] == docHuesped)
                {
                    Console.WriteLine("Nombre del Huésped: " + nombreHuesped[i]);
                    Console.WriteLine("Documento de Identidad: " + documentoHuesped[i]);
                    Console.WriteLine("Teléfono: " + telefonoHuesped[i]);
                    Console.WriteLine("Email: " + emailHuesped[i]);
                    Console.WriteLine("Nacionalidad: " + nacionalidadHuesped[i]);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Huésped no encontrado.");
            }
        }

        static void ModificarHuesped()
        {
            Console.WriteLine("=== Modificar Huésped ===");

            Console.Write("Ingrese el documento de identidad del huésped a modificar: ");
            string docHuesped = Console.ReadLine();
            int indice = -1;

            for (int i = 0; i < contadorHuespedes; i++)
            {
                if (documentoHuesped[i] == docHuesped)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine("Ingrese nuevo nombre completo del huésped: ");
                nombreHuesped[indice] = Console.ReadLine();

                Console.WriteLine("Ingrese nuevo teléfono del huésped: ");
                telefonoHuesped[indice] = Console.ReadLine();

                Console.WriteLine("Ingrese nuevo email del huésped: ");
                emailHuesped[indice] = Console.ReadLine();

                Console.WriteLine("Ingrese nueva nacionalidad del huésped: ");
                nacionalidadHuesped[indice] = Console.ReadLine();

                Console.WriteLine("Huésped modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("Huésped no encontrado.");
            }
        }

        static void EliminarHuesped()
        {
            Console.WriteLine("=== Eliminar Huésped ===");

            Console.Write("Ingrese el documento de identidad del huésped a eliminar: ");
            string docHuesped = Console.ReadLine();
            int indice = -1;

            for (int i = 0; i < contadorHuespedes; i++)
            {
                if (documentoHuesped[i] == docHuesped)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                for (int j = indice; j < contadorHuespedes - 1; j++)
                {
                    nombreHuesped[j] = nombreHuesped[j + 1];
                    documentoHuesped[j] = documentoHuesped[j + 1];
                    telefonoHuesped[j] = telefonoHuesped[j + 1];
                    emailHuesped[j] = emailHuesped[j + 1];
                    nacionalidadHuesped[j] = nacionalidadHuesped[j + 1];
                }
                contadorHuespedes--;
                Console.WriteLine("Huésped eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Huésped no encontrado.");
            }
        }

        static int maxReservasPorHabitacion = 5;
        static int maxReservas = 100;
        static string[,] docReserva = new string[maxReservasPorHabitacion, maxReservas];
        static string[,] fechaIngreso = new string[maxReservasPorHabitacion, maxReservas];
        static string[,] fechaSalida = new string[maxReservasPorHabitacion, maxReservas];
        static double[,] TotalPagar = new double[maxReservasPorHabitacion, maxReservas];
        static int[] contadorReservasPorHabitacion = new int[maxReservasPorHabitacion];

        static void RegistarReserva()
        {
            Console.WriteLine("=== Registro de Reserva ===");

            Console.Write("Ingrese el número de habitación para la reserva: ");
            int numHabitacion = int.Parse(Console.ReadLine());
            int indiceHab = -1;

            for (int i = 0; i < contadorHabitaciones; i++)
            {
                if (numeroHabitación[i] == numHabitacion)
                {
                    indiceHab = i;
                    break;
                }
            }
            if(indiceHab == -1)
            {
                Console.WriteLine("Habitación no encontrada.");
            }

            if (contadorReservasPorHabitacion[indiceHab] >= maxReservas)
            {
                Console.WriteLine("No se pueden registrar más reservas para esta habitación. Capacidad máxima alcanzada.");
                return;
            }

            Console.Write("Ingrese el documento de identidad del huésped: ");
            string docHuesped = Console.ReadLine();
            bool huespedExiste = false;

            for (int i = 0; i < contadorHuespedes; i++)
            {
                if (documentoHuesped[i] == docHuesped)
                {
                    huespedExiste = true;
                    break;
                }
            }
            if (!huespedExiste)
            {
                Console.WriteLine("Huésped no encontrado. Registre al huésped antes de hacer una reserva.");
                return;
            }

            int posicionReserva = contadorReservasPorHabitacion[indiceHab];

            Console.Write("Ingrese la fecha de ingreso (dd/mm/yyyy): ");
            fechaIngreso[indiceHab, posicionReserva] = Console.ReadLine();
            Console.Write("Ingrese la fecha de salida (dd/mm/yyyy): ");
            fechaSalida[indiceHab, posicionReserva] = Console.ReadLine();
            Console.Write("Ingrese numero de noches: ");
            int numNoches = int.Parse(Console.ReadLine());

            TotalPagar[indiceHab, posicionReserva] = precioHabitación[indiceHab] * numNoches;
            docReserva[indiceHab, posicionReserva] = docHuesped;
            contadorReservasPorHabitacion[indiceHab]++;

            Console.WriteLine("Reserva registrada exitosamente. Total a pagar: $" + TotalPagar[indiceHab, posicionReserva]);
        }
    }

}
