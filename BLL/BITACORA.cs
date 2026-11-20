using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class BITACORA
    {
        private MP_BITACORA mp = new MP_BITACORA();

        public void Registrar(int idUsuario, string evento, string detalle)
        {
            BE.BITACORA b = new BE.BITACORA();
            b.IdUsuario = idUsuario;
            b.Evento = evento;
            b.Detalle = detalle;
            mp.Insertar(b);
        }

        public List<BE.BITACORA> Listar()
        {
            return mp.Listar();
        }
    }
}

