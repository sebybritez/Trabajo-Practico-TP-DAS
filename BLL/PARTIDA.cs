using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class PARTIDA
    {
        private MP_PARTIDA mp = new MP_PARTIDA();

        public int Guardar(BE.PARTIDA partida)
        {
            return mp.Insertar(partida);
        }

        public List<BE.PARTIDA> Listar()
        {
            return mp.Listar();
        }
    }
}

