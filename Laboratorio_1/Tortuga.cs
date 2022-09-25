using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    public class Tortuga
    {
        public Tortuga()
        {
            //La tortuga inicia en la posición 0,0 y con la pluma hacia arriba
            Simbolo_Tortuga = 'X';
            PosX = 0;
            PosY = 0;
            Mover = 0;

        }
        public char Simbolo_Tortuga { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public int Mover { get; set; }

        //Calculado por la direccion seleccionada , numero de espacios y la accion de la pluma
        public void Caminar(Todas_Direcciones.Direcciones direccion, int espacios, Pluma.Acciones_Pluma pluma)
        {
            if (Validacion_Movimiento(direccion, espacios) )
            {
                var Dibujar = (pluma == Pluma.Acciones_Pluma.Abajo);

                switch (direccion) 
                {
                    case Todas_Direcciones.Direcciones.Arriba:
                        if (Dibujar) Piso.Actualizar_PisoX(PosX, espacios, -1, PosY);
                        PosX -= espacios;
                        break;
                    case Todas_Direcciones.Direcciones.Abajo:
                        if (Dibujar) Piso.Actualizar_PisoX(PosX, espacios, +1, PosY);
                        PosX += espacios;
                        break;
                    case Todas_Direcciones.Direcciones.Derecha:
                        if (Dibujar) Piso.Actualizar_PisoY(PosY, espacios, +1, PosX);
                        PosY -= espacios;
                        break;
                    case Todas_Direcciones.Direcciones.Izquierda:
                        if (Dibujar) Piso.Actualizar_PisoY(PosY, espacios, -1, PosX);
                        PosY += espacios;
                        break;
                };
            }
        }
        //Controla si el movimiento resulta en una posición fuera del tablero
        //Mover arriba o izquierda: restar espacios; abajo o derecha sumar espacios
        private bool Validacion_Movimiento(Todas_Direcciones.Direcciones direccion, int espacios)
        {
            if (direccion == Todas_Direcciones.Direcciones.Arriba && (PosX - espacios) < 0)
            {
                Informacion.Movimiento_Invalido(direccion, PosX);
                return false;
            }//Restamos 1 porque el tam es 30 porque los indices son 0 - 29
            else if(direccion == Todas_Direcciones.Direcciones.Derecha && (PosY + espacios) > Piso.Tam_Tablero)
            {
                Informacion.Movimiento_Invalido(direccion, Piso.Tam_Tablero - PosY -1);
                return false;
            }//Restamos 1 porque el tam es 30 porque los indices son 0 - 29
            else if (direccion == Todas_Direcciones.Direcciones.Abajo && (PosX + espacios) > Piso.Tam_Tablero)
            {
                Informacion.Movimiento_Invalido(direccion, Piso.Tam_Tablero - PosX -1);
                return false;
            }
            else if (direccion == Todas_Direcciones.Direcciones.Izquierda && (PosY - espacios) < 0)
            {
                Informacion.Movimiento_Invalido(direccion, PosX);
                return false;
            }

            return true;
        }
    }
}
