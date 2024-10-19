using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1DSOO
{
    internal class Socio
    {
        private string nombre;
        private int id;
        private List<string> actividades = new List<string>();

        // Constructor
        public Socio(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetId()
        {
            return id;
        }

        public bool TieneTopeDeActividades()
        {
            return actividades.Count >= 3;
        }

        public void InscribirActividad(string actividad)
        {
            if (actividades.Count < 3)
            {
                actividades.Add(actividad);
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}");
            for (int i = 0; i < actividades.Count; i++)
            {
                Console.WriteLine($"Actividad {i + 1}: {actividades[i]}");
            }

        }

    }
}
