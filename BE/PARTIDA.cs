using System;

namespace BE
{
    public class PARTIDA
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

        private int idJugador1;
        public int IdJugador1
        {
            get { return idJugador1; }
            set { idJugador1 = value; }
        }

        private string nombreJugador1;
        public string NombreJugador1
        {
            get { return nombreJugador1; }
            set { nombreJugador1 = value; }
        }

        private int idJugador2;
        public int IdJugador2
        {
            get { return idJugador2; }
            set { idJugador2 = value; }
        }

        private string nombreJugador2;
        public string NombreJugador2
        {
            get { return nombreJugador2; }
            set { nombreJugador2 = value; }
        }

        private int impactosJ1;
        public int ImpactosJ1
        {
            get { return impactosJ1; }
            set { impactosJ1 = value; }
        }

        private int impactosJ2;
        public int ImpactosJ2
        {
            get { return impactosJ2; }
            set { impactosJ2 = value; }
        }

        private int idGanador;
        public int IdGanador
        {
            get { return idGanador; }
            set { idGanador = value; }
        }

        private string nombreGanador;
        public string NombreGanador
        {
            get { return nombreGanador; }
            set { nombreGanador = value; }
        }

        private int duracionSegundos;
        public int DuracionSegundos
        {
            get { return duracionSegundos; }
            set { duracionSegundos = value; }
        }

        private string archivoXml;
        public string ArchivoXml
        {
            get { return archivoXml; }
            set { archivoXml = value; }
        }

        public string DuracionFormateada
        {
            get
            {
                TimeSpan ts = TimeSpan.FromSeconds(duracionSegundos);
                return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
            }
        }
    }
}

