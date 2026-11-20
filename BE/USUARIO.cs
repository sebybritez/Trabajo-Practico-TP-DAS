using System;

namespace BE
{
    public class USUARIO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string contrasena;
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        private int ganadas;
        public int Ganadas
        {
            get { return ganadas; }
            set { ganadas = value; }
        }

        private int perdidas;
        public int Perdidas
        {
            get { return perdidas; }
            set { perdidas = value; }
        }

        private int empatadas;
        public int Empatadas
        {
            get { return empatadas; }
            set { empatadas = value; }
        }

        private int segundosJugados;
        public int SegundosJugados
        {
            get { return segundosJugados; }
            set { segundosJugados = value; }
        }

        public int PartidasJugadas
        {
            get { return ganadas + perdidas + empatadas; }
        }

        public double PromedioVictorias
        {
            get
            {
                int total = PartidasJugadas;
                if (total == 0) return 0;
                return Math.Round((double)ganadas * 100.0 / total, 2);
            }
        }

        public string TiempoJugadoFormateado
        {
            get
            {
                TimeSpan ts = TimeSpan.FromSeconds(segundosJugados);
                return string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
            }
        }
    }
}

