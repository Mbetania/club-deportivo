        using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    namespace TP1DSOO
    {
        internal class Actividad
        {
            public string Nombre { get; private set; }
            public int Cupos { get; private set; }

            public Actividad(string nombre, int cupos)
            {
                Nombre = nombre;
                Cupos = cupos;
            }

            // metodo para reservar un cupo
            public bool ReservarCupo()
            {
                if (Cupos > 0)
                {
                    Cupos--;
                    return true;
                }
                return false;
            }
        }
    }           