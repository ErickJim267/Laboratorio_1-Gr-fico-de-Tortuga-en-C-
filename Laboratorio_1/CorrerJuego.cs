using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class CorrerJuego
    {
        static void Main(string[] args)
        {
            var juego = new Juego();
            juego.CicloJuego();

            Console.WriteLine("\nHasta Luego\n"); //Mensaje final
        }
    }
}
