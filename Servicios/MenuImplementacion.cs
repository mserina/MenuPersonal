using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPersonal.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string saludo = "Bienvenido Warrior Game";
            Console.WriteLine(saludo);
        }

        public int mostrarmostrarMenuYOpciones()
        {
            int opcionSeleccionada;
            Console.WriteLine("###############################");
            Console.WriteLine("0. JUGAR");
            Console.WriteLine("1. AJUSTES");
            Console.WriteLine("2. SALIR");
            Console.WriteLine("###############################");


        }
    }
}
