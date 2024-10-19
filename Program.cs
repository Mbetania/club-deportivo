using TP1DSOO;

internal class Program
{



    private static void Main(string[] args)
    {
        ClubDeportivo club = new ClubDeportivo();
        string? option = "";

        // algunas actividades
        club.AgregarActividad("futbol", 25); //sin acento para evitar  bardillo
        club.AgregarActividad("natacion", 15);
        club.AgregarActividad("basket", 30);



        do
        {

            //limpiamos la chanchada
            Console.Clear();

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("------CLUB DEPORTIVO -------- \n");
            Console.WriteLine("Sistema de Control de Socios \n\n\n\n");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1 - Dar de alta nuevo Socio");
            Console.WriteLine("2 - Inscribir a actividad");
            Console.WriteLine("3 - Mostrar Socios");
            Console.WriteLine("4 - Salir"); ;
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    club.DarAltaSocio();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ingrese el ID del socio:");
                    int idSocio = int.Parse(Console.ReadLine() ??  "0");
                    Console.WriteLine("Ingrese el nombre de la actividad (en minúscula y sin acentuación):");
                    string nombreActividad = Console.ReadLine() ?? "";
                    string resultado = club.InscribirActividad(nombreActividad, idSocio);
                    Console.Clear();
                    Console.WriteLine(resultado);
                    break;
                case "3":
                    Console.Clear();
                    club.MostrarSocios();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Por favor seleccione una opción correcta.");
                    break;
            }
            // Esperar a que el usuario presione una tecla antes de continuar
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();


        } while (option != "4");
    }



}