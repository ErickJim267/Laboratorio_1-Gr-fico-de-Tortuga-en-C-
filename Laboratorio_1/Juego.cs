using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    public class Juego
    {
        private int _opcion;
        private Pluma _pluma;
        private Tortuga _tortuga;
        private bool _finalizar;
        private Piso _piso;

        public Juego()
        {
            _pluma = new Pluma();
            _tortuga = new Tortuga();
            _piso = new Piso();
            _finalizar = false;
        }
        public void CicloJuego()
        {
            do
            {
                //Preparar la pantalla para mostrar la info
                Console.Clear();
                Console.WriteLine(Informacion.MsjError);//Se muestran los mensajes de error cuando los hay
                Informacion.MsjError = "";
                _piso.Dibujar_Piso(_tortuga.PosX, _tortuga.PosY, _tortuga.Simbolo_Tortuga);
                Informacion.Instrucciones();
                Console.WriteLine(_pluma); //Muestra estado de la pluma
                Console.WriteLine("Seleccione su opción: ");

                if (int.TryParse(Console.ReadLine(), out _opcion)) //Para asegurarme que ingresan digitos
                {
                    if (_opcion > 0 && _opcion < 3) // el input sera 1 o 2
                    {
                        _pluma.Accion_Pluma = (Pluma.Acciones_Pluma)_opcion; //Convertir el input a numero
                    }
                    else if (_opcion > 2 && _opcion <= 8) // opciones de 3 a 8 para las direcciones
                    {
                        var direccion = (Todas_Direcciones.Direcciones) _opcion; // convierte el input de num a string
                        Console.WriteLine("La Tortuga se está moviendo {0}", direccion); //muestra la direccion seleccionada
                        Console.WriteLine("Ingrese el número de espacios para moverse: ");
                        int espacios;

                        if (int.TryParse(Console.ReadLine(), out espacios))//Para asegurarnos que los espacios son enteros
                        {
                            _tortuga.Caminar(direccion, espacios, _pluma.Accion_Pluma);
                        }
                        else
                        {
                            Informacion.Datos_Invalidos();
                        }
                    }
                    else if (_opcion == 9)
                    {
                        _finalizar = true; // finaliza el juego
                    }
                }
                else
                {
                    Informacion.Acciones_Invalidas();
                };

            } while (!_finalizar);
        }
    }
}
