using System;

namespace BE
{
    public class BITACORA
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int idUsuario;
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string nombreUsuario;
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private string evento;
        public string Evento
        {
            get { return evento; }
            set { evento = value; }
        }

        private string detalle;
        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
    }
}

