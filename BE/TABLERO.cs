using System.Collections.Generic;

namespace BE
{
    public class TABLERO
    {
        public const int TAMANO = 15;

        // Estados de cada casillero:
        // 0 = Agua (sin disparar)
        // 1 = Nave intacta
        // 2 = Agua (disparado)
        // 3 = Tocado
        // 4 = Hundido
        private int[,] celdas;
        public int[,] Celdas
        {
            get { return celdas; }
            set { celdas = value; }
        }

        private List<NAVE> naves;
        public List<NAVE> Naves
        {
            get { return naves; }
            set { naves = value; }
        }

        public TABLERO()
        {
            celdas = new int[TAMANO, TAMANO];
            naves = CrearFlotaInicial();
        }

        public static List<NAVE> CrearFlotaInicial()
        {
            List<NAVE> flota = new List<NAVE>();
            flota.Add(new NAVE("Batalla Naval", 5));
            flota.Add(new NAVE("Barcos Portaaviones", 4));
            flota.Add(new NAVE("Fragatas", 3));
            flota.Add(new NAVE("Buque", 2));
            flota.Add(new NAVE("Acorazados", 1));
            return flota;
        }

        public void Reiniciar()
        {
            celdas = new int[TAMANO, TAMANO];
            naves = CrearFlotaInicial();
        }
    }
}

