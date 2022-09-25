using System;

namespace Laboratorio_1
{
    public static class Informacion
    {
        public static void Instrucciones()
        {
            Console.WriteLine("Digite el comando de su elección para jugar con la Tortuga");
            Console.WriteLine("1 - Pluma Arriba, 2 - Pluma Abajo");
            Console.WriteLine("8 - Arriba, 5 - Abajo");
            Console.WriteLine("4 - Izquierda, 6 - Derecha");
            Console.WriteLine("5,X - Digite una cantidad menor a 30 para que la tortuga avance");
            Console.WriteLine("7 - Imprimir datos del tablero");
            Console.WriteLine("9 - Finalizar");
            //Console.WriteLine("");

        }
        //Manejo de errores
        public static string MsjError { get; set; }

        public static void Acciones_Invalidas() 
        {
            MsjError = "\nAcción de juego inválida! Por favor pruebe de nuevo usando 1 = Arriba o 2 = Abajo! (n_n) \n";
        }

        public static void Direcciones_Invalidas()
        {
            MsjError = "\nPor favor ingrese valores permitidos para realizar el movimiento! (n_n) \n";
        }
        public static void Datos_Invalidos()
        {
            MsjError = "\nPor favor ingrese sólo valores numéricos para jugar! (n_n) \n";
        }
        public static void Espacios_Invalidos()
        {
            MsjError = "\nUtilice valores entre 0 y 30 para realizar sus movimientos! (n_n) \n";
        }
        public static void Movimiento_Invalido(Todas_Direcciones.Direcciones direccion, int espacios)
        {
            MsjError = String.Format("\nMovimiento Inválido! Sólo puede moverese {0} espacios hacia {1}\n", espacios, direccion);
        }
    }
}
