using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio_1
{
    public class Pluma //Como debemos recordar el estado de la pluma, la clase no puede ser static.
    {
        private Acciones_Pluma _accion_Pluma;
        public enum Acciones_Pluma 
        {
            Arriba = 1,
            Abajo = 2
        };
        public Pluma()
        {
            Accion_Pluma = Acciones_Pluma.Arriba; //Este valor es por defecto, para que la pluma inicie hacia arriba
        }

        //Se le asigna un comportamiento según el número ingresado por el usuario 1 Arriba o 2 Abajo
        public Acciones_Pluma Accion_Pluma
        {
            get { return _accion_Pluma; }
            set
            {
                switch ((int)value)
                {
                    case 1:
                        _accion_Pluma = Acciones_Pluma.Arriba;
                        break;
                    case 2:
                        _accion_Pluma = Acciones_Pluma.Abajo;
                        break;
                    default:
                        Informacion.Acciones_Invalidas();
                        break;
                }
            }
        }
        //Estado actual de la pluma
        public override string ToString()
        {
            return String.Format("La pluma está {0}", Accion_Pluma == Acciones_Pluma.Abajo ? "Dibujando" : "No dibujando");
            
        }
    }
    
}
