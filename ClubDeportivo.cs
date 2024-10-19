using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DSOO
{
    internal class ClubDeportivo
    {
        private List<Socio> socios = new List<Socio>();
        private List<Actividad> actividades = new List<Actividad>();
        private int contadorId = 1;

        // Metodo para dar de alta un socio
        public void DarAltaSocio()
        {
            Console.WriteLine("Ingrese el nombre del nuevo socio:");
            string? nombre = Console.ReadLine();

            Socio nuevoSocio = new Socio(contadorId, nombre ?? "");
            socios.Add(nuevoSocio);

            Console.WriteLine($"El socio {nombre} ha sido dado de alta correctamente con el ID {contadorId}.");
            contadorId++;
        }

        // Metodo para agregar una actividad al club
        public void AgregarActividad(string nombreActividad, int cupos)
        {
            actividades.Add(new Actividad(nombreActividad, cupos));
            Console.WriteLine($"Actividad {nombreActividad} agregada con {cupos} cupos disponibles.");
        }

        // Método para inscribir a un socio en una actividad
        public string InscribirActividad(string nombreActividad, int idSocio)
        {
            Socio? socio = socios.Find(s => s.GetId() == idSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            if (socio.TieneTopeDeActividades())
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            Actividad?       actividad = actividades.Find(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            if (actividad.ReservarCupo())
            {
                socio.InscribirActividad(nombreActividad);
                return "INSCRIPCIÓN EXITOSA";
            }
            else
            {
                return "NO HAY CUPOS DISPONIBLES";
            }
        }

        // Método para mostrar los socios registrados
        public void MostrarSocios()
        {
            foreach (Socio socio in socios)
            {
                socio.MostrarInfo();
            }
        }

    }
}
