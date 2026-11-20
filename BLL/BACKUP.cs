using System;
using System.IO;
using DAL;

namespace BLL
{
    public class BACKUP
    {
        private MP_BACKUP mp = new MP_BACKUP();

        public void RealizarBackup(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("Debe indicar una ruta válida para el archivo de backup.");
            }
            mp.RealizarBackup(rutaArchivo);
        }

        public void RealizarRestore(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("Debe indicar una ruta válida para el archivo de backup.");
            }
            mp.RealizarRestore(rutaArchivo);
        }

        public string ObtenerRutaPorDefecto()
        {
            return mp.ObtenerRutaBackupPorDefecto();
        }
    }
}
