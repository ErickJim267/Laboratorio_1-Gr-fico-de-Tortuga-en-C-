namespace Laboratorio_1
{
    public class Liebre : Tortuga
        //Liebre hereda de Tortuga
        //Yo quiero que liebre herede los movimientos de Tortuga
        //pero, haré sobreescritura para ajustar los movimientos a lo que pide el lab e iniciando en la posición 30
    {
        public Liebre(char LiebreY, int posX, int posY, int mover)
        {
            Simbolo_Tortuga = LiebreY;
            PosX = 30;
            PosY = 30;
            Mover = mover;
        }
        public char LiebreY { get; set; }
        public new int PosX { get; set; }
        public new int PosY { get; set; }
        public new int Mover { get; set; }
    }
    /*
    public void Caminar(Todas_Direcciones.Direcciones direccion, int espacios, Pluma.Acciones_Pluma pluma)
    {
        if (Validacion_Movimiento(direccion, espacios))
        {
            var Dibujar = (pluma == Pluma.Acciones_Pluma.Abajo);

            switch (direccion)
            {
                case Todas_Direcciones.Direcciones.Arriba:
                    if (Dibujar) Piso.Actualizar_PisoX(PosY, espacios, +1, PosX);
                    PosY -= espacios;
                    break;
                case Todas_Direcciones.Direcciones.Abajo:
                    if (Dibujar) Piso.Actualizar_PisoX(PosY, espacios, -1, PosX);
                    PosY += espacios;
                    break;
                case Todas_Direcciones.Direcciones.Derecha:
                    if (Dibujar) Piso.Actualizar_PisoY(PosX, espacios, -1, PosY);
                    PosX -= espacios;
                    break;
                case Todas_Direcciones.Direcciones.Izquierda:
                    if (Dibujar) Piso.Actualizar_PisoY(PosX, espacios, +1, PosY);
                    PosX += espacios;
                    break;
            };
        }
    }*/
}
     