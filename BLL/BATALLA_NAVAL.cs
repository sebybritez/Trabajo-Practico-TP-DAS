using System;

namespace BLL
{
    public class BATALLA_NAVAL
    {
        private Random random = new Random();

        public string ObtenerCoordenada(int fila, int columna)
        {
            char letraColumna = (char)('A' + columna);
            return string.Format("{0}{1}", letraColumna, fila + 1);
        }

        public bool PuedeColocarNave(BE.TABLERO tablero, BE.NAVE nave, int fila, int columna, bool esHorizontal)
        {
            if (fila < 0 || columna < 0 || fila >= BE.TABLERO.TAMANO || columna >= BE.TABLERO.TAMANO)
            {
                return false;
            }

            if (esHorizontal)
            {
                if (columna + nave.Tamano > BE.TABLERO.TAMANO)
                {
                    return false;
                }
                for (int c = columna; c < columna + nave.Tamano; c++)
                {
                    if (tablero.Celdas[fila, c] != 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (fila + nave.Tamano > BE.TABLERO.TAMANO)
                {
                    return false;
                }
                for (int f = fila; f < fila + nave.Tamano; f++)
                {
                    if (tablero.Celdas[f, columna] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void QuitarNave(BE.TABLERO tablero, BE.NAVE nave)
        {
            if (!nave.Colocada) return;

            for (int i = 0; i < nave.Tamano; i++)
            {
                int f = nave.EsHorizontal ? nave.FilaInicio : nave.FilaInicio + i;
                int c = nave.EsHorizontal ? nave.ColumnaInicio + i : nave.ColumnaInicio;
                tablero.Celdas[f, c] = 0;
            }

            nave.Colocada = false;
            nave.FilaInicio = -1;
            nave.ColumnaInicio = -1;
            nave.Impactos = 0;
        }

        public bool ColocarNave(BE.TABLERO tablero, BE.NAVE nave, int fila, int columna, bool esHorizontal)
        {
            // Si ya estaba colocada, la sacamos primero para permitir reubicarla
            bool estabaColocada = nave.Colocada;
            int filaAnt = nave.FilaInicio;
            int colAnt = nave.ColumnaInicio;
            bool horizAnt = nave.EsHorizontal;

            if (estabaColocada)
            {
                QuitarNave(tablero, nave);
            }

            if (!PuedeColocarNave(tablero, nave, fila, columna, esHorizontal))
            {
                // Restaurar posición anterior si existía
                if (estabaColocada)
                {
                    ColocarNaveInterno(tablero, nave, filaAnt, colAnt, horizAnt);
                }
                return false;
            }

            ColocarNaveInterno(tablero, nave, fila, columna, esHorizontal);
            return true;
        }

        private void ColocarNaveInterno(BE.TABLERO tablero, BE.NAVE nave, int fila, int columna, bool esHorizontal)
        {
            for (int i = 0; i < nave.Tamano; i++)
            {
                int f = esHorizontal ? fila : fila + i;
                int c = esHorizontal ? columna + i : columna;
                tablero.Celdas[f, c] = 1;
            }

            nave.FilaInicio = fila;
            nave.ColumnaInicio = columna;
            nave.EsHorizontal = esHorizontal;
            nave.Colocada = true;
            nave.Impactos = 0;
        }

        public void UbicarFlotaAleatoria(BE.TABLERO tablero)
        {
            tablero.Reiniciar();

            foreach (BE.NAVE nave in tablero.Naves)
            {
                bool ubicada = false;
                int intentos = 0;

                while (!ubicada && intentos < 1000)
                {
                    intentos++;
                    bool horizontal = random.Next(0, 2) == 0;
                    int fila = random.Next(0, BE.TABLERO.TAMANO);
                    int columna = random.Next(0, BE.TABLERO.TAMANO);

                    if (PuedeColocarNave(tablero, nave, fila, columna, horizontal))
                    {
                        ColocarNaveInterno(tablero, nave, fila, columna, horizontal);
                        ubicada = true;
                    }
                }
            }
        }

        public bool TodasLasNavesUbicadas(BE.TABLERO tablero)
        {
            foreach (BE.NAVE nave in tablero.Naves)
            {
                if (!nave.Colocada)
                {
                    return false;
                }
            }
            return true;
        }

        public string ProcesarDisparo(BE.TABLERO tableroObjetivo, int fila, int columna, out string naveAfectada)
        {
            naveAfectada = "";
            int estado = tableroObjetivo.Celdas[fila, columna];

            if (estado == 2 || estado == 3 || estado == 4)
            {
                return "YaDisparado";
            }

            if (estado == 0)
            {
                tableroObjetivo.Celdas[fila, columna] = 2;
                return "Agua";
            }

            // Estado == 1 (Nave)
            tableroObjetivo.Celdas[fila, columna] = 3;

            foreach (BE.NAVE nave in tableroObjetivo.Naves)
            {
                if (nave.OcupaCasillero(fila, columna))
                {
                    nave.Impactos++;
                    naveAfectada = nave.Nombre;

                    if (nave.EstaHundida)
                    {
                        // Marcamos todas las celdas de la nave como hundidas (4)
                        for (int i = 0; i < nave.Tamano; i++)
                        {
                            int f = nave.EsHorizontal ? nave.FilaInicio : nave.FilaInicio + i;
                            int c = nave.EsHorizontal ? nave.ColumnaInicio + i : nave.ColumnaInicio;
                            tableroObjetivo.Celdas[f, c] = 4;
                        }
                        return "Hundido";
                    }

                    return "Tocado";
                }
            }

            return "Tocado";
        }

        public bool TodasLasNavesHundidas(BE.TABLERO tablero)
        {
            foreach (BE.NAVE nave in tablero.Naves)
            {
                if (!nave.EstaHundida)
                {
                    return false;
                }
            }
            return true;
        }

        public int ContarNavesRestantes(BE.TABLERO tablero)
        {
            int restantes = 0;
            foreach (BE.NAVE nave in tablero.Naves)
            {
                if (!nave.EstaHundida)
                {
                    restantes++;
                }
            }
            return restantes;
        }
    }
}

