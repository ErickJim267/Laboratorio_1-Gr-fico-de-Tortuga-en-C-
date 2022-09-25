namespace Laboratorio_1
{
    public static class Todas_Direcciones
    {
        private static Direcciones _direccion;
        //El ejercicio pide otra configuración para las direcciones,
        //pero pensé que hacerlo según la configuración típica del teclado numérico podría ser una mejora
        public enum Direcciones 
        {
            Arriba = 8,
            Derecha = 6, 
            Abajo = 5, 
            Izquierda = 4
        };
        public static Direcciones Direccion
        {
            get { return _direccion; }
            set
            {
                switch((int)value)
                {
                    case 8:
                        _direccion = Direcciones.Arriba;
                        break;
                    case 6:
                        _direccion = Direcciones.Derecha;
                        break;
                    case 5:
                        _direccion = Direcciones.Abajo;
                        break;
                    case 4:
                        _direccion = Direcciones.Izquierda;
                        break;
                    default:
                        Informacion.Direcciones_Invalidas();
                        break;

                }
            }

        }
    }
}
