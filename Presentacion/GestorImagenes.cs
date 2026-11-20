using System;
using System.Drawing;
using System.IO;

namespace Presentacion
{
    public static class GestorImagenes
    {
        private static bool cargadas = false;

        public static Image Mar { get; private set; }
        public static Image Agua { get; private set; }
        public static Image Tocado { get; private set; }
        public static Image Hundido { get; private set; }
        public static Image Oculto { get; private set; }

        public static Image BarcoUnico { get; private set; }
        public static Image BarcoHIzq { get; private set; }
        public static Image BarcoHMed { get; private set; }
        public static Image BarcoHDer { get; private set; }
        public static Image BarcoVArr { get; private set; }
        public static Image BarcoVMed { get; private set; }
        public static Image BarcoVAba { get; private set; }

        public static void Cargar()
        {
            if (cargadas) return;

            string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes");

            Mar = CargarImagen(baseDir, "mar.png");
            Agua = CargarImagen(baseDir, "agua.png");
            Tocado = CargarImagen(baseDir, "tocado.png");
            Hundido = CargarImagen(baseDir, "hundido.png");
            Oculto = CargarImagen(baseDir, "oculto.png");

            BarcoUnico = CargarImagen(baseDir, "barco_unico.png");
            BarcoHIzq = CargarImagen(baseDir, "barco_h_izq.png");
            BarcoHMed = CargarImagen(baseDir, "barco_h_med.png");
            BarcoHDer = CargarImagen(baseDir, "barco_h_der.png");
            BarcoVArr = CargarImagen(baseDir, "barco_v_arr.png");
            BarcoVMed = CargarImagen(baseDir, "barco_v_med.png");
            BarcoVAba = CargarImagen(baseDir, "barco_v_aba.png");

            cargadas = true;
        }

        private static Image CargarImagen(string carpeta, string archivo)
        {
            string ruta = Path.Combine(carpeta, archivo);
            if (!File.Exists(ruta)) return null;
            using (Image temp = Image.FromFile(ruta))
            {
                return new Bitmap(temp);
            }
        }

        public static Image ObtenerImagenNave(BE.TABLERO tablero, int fila, int col)
        {
            Cargar();

            foreach (BE.NAVE nave in tablero.Naves)
            {
                if (nave.OcupaCasillero(fila, col))
                {
                    if (nave.Tamano == 1)
                    {
                        return BarcoUnico;
                    }

                    if (nave.EsHorizontal)
                    {
                        if (col == nave.ColumnaInicio) return BarcoHIzq;
                        if (col == nave.ColumnaInicio + nave.Tamano - 1) return BarcoHDer;
                        return BarcoHMed;
                    }
                    else
                    {
                        if (fila == nave.FilaInicio) return BarcoVArr;
                        if (fila == nave.FilaInicio + nave.Tamano - 1) return BarcoVAba;
                        return BarcoVMed;
                    }
                }
            }

            return BarcoUnico;
        }
    }
}

