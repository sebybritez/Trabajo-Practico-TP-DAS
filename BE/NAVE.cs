using System;

namespace BE
{
    public class NAVE
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int tamano;
        public int Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }

        private int filaInicio;
        public int FilaInicio
        {
            get { return filaInicio; }
            set { filaInicio = value; }
        }

        private int columnaInicio;
        public int ColumnaInicio
        {
            get { return columnaInicio; }
            set { columnaInicio = value; }
        }

        private bool esHorizontal;
        public bool EsHorizontal
        {
            get { return esHorizontal; }
            set { esHorizontal = value; }
        }

        private bool colocada;
        public bool Colocada
        {
            get { return colocada; }
            set { colocada = value; }
        }

        private int impactos;
        public int Impactos
        {
            get { return impactos; }
            set { impactos = value; }
        }

        public bool EstaHundida
        {
            get { return colocada && impactos >= tamano; }
        }

        public NAVE()
        {
        }

        public NAVE(string nombre, int tamano)
        {
            this.nombre = nombre;
            this.tamano = tamano;
            this.filaInicio = -1;
            this.columnaInicio = -1;
            this.esHorizontal = true;
            this.colocada = false;
            this.impactos = 0;
        }

        public bool OcupaCasillero(int fila, int columna)
        {
            if (!colocada) return false;

            if (esHorizontal)
            {
                return fila == filaInicio && columna >= columnaInicio && columna < columnaInicio + tamano;
            }
            else
            {
                return columna == columnaInicio && fila >= filaInicio && fila < filaInicio + tamano;
            }
        }

        public override string ToString()
        {
            string estado = colocada ? "[Ubicada]" : "[Pendiente]";
            return string.Format("{0} ({1} cas.) {2}", nombre, tamano, estado);
        }
    }
}

