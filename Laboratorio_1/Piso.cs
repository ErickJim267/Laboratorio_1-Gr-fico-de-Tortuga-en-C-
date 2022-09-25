using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    public class Piso
    {
        public const int Tam_Tablero = 30;
        public const char Espacio_Usado = 'O';
        public const char Simbolo_Tablero = '~';

        public Piso()
        {
            PisoArray = new char[Tam_Tablero,Tam_Tablero];
            Iniciar_Piso();
         }

        public static char[,] PisoArray { get; set;}

        public void Iniciar_Piso() 
        {
            for (var i=0; i < Tam_Tablero; i++)
            {
                for (var j = 0; j < Tam_Tablero; j++)
                    PisoArray[i, j] = Simbolo_Tablero;

            }
        
        }
        //Crear el tablero y mostrar la tortuga
        public void Dibujar_Piso(int posX, int posY, char tortuga)
        {
            for (var i = 0; i < Tam_Tablero; i++)
            {
                for (var e = 0; e < Tam_Tablero; e++)
                {
                    if (i == posX && e == posY)
                        Console.Write(tortuga);
                    else
                        Console.Write(PisoArray[i, e]);
                }
                Console.WriteLine();
            }

        }
        //Actualizar aquí el Array
        public static void Actualizar_PisoX (int inicio, int iteracion, int incremento, int constante)
        {
            for (var i = 0; i < iteracion; i++)
                PisoArray[inicio + (i * incremento), constante] = Espacio_Usado;
        }
        public static void Actualizar_PisoY(int inicio, int iteracion, int incremento, int constante)
        {
            for (var i = 0; i < iteracion; i++)
                PisoArray[constante, inicio + (i * incremento)] = Espacio_Usado;
        }

    }
}
