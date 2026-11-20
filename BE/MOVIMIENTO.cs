using System;

namespace BE
{
    public class MOVIMIENTO
    {
        private int numeroTurno;
        public int NumeroTurno
        {
            get { return numeroTurno; }
            set { numeroTurno = value; }
        }

        private DateTime fechaHora;
        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        private string jugador;
        public string Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        private int fila;
        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        private int columna;
        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }

        private string coordenada;
        public string Coordenada
        {
            get { return coordenada; }
            set { coordenada = value; }
        }

        private string resultado;
        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        private string naveAfectada;
        public string NaveAfectada
        {
            get { return naveAfectada; }
            set { naveAfectada = value; }
        }
    }
}

