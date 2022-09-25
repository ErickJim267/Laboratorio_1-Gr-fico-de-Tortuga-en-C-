namespace Laboratorio_1
{
    internal interface InterfazCorrerJuego
    {
        static void Main(string[] args)
        {
            var juego = new Juego();
            juego.CicloJuego();

            Console.WriteLine("\nHasta Luego\n"); //Mensaje final
        }
    }
}
