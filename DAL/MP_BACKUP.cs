using System;

namespace DAL
{
    public class MP_BACKUP
    {
        private Acceso acceso = new Acceso();

        public void RealizarBackup(string rutaArchivo)
        {
            string rutaSegura = rutaArchivo.Replace("'", "''");
            string sql = string.Format(
                "BACKUP DATABASE [BATALLA_NAVAL] TO DISK = N'{0}' WITH FORMAT, INIT, NAME = N'Backup Batalla Naval';",
                rutaSegura);
            acceso.EjecutarSqlMaster(sql);
        }

        public void RealizarRestore(string rutaArchivo)
        {
            string rutaSegura = rutaArchivo.Replace("'", "''");
            string sql = string.Format(
                "ALTER DATABASE [BATALLA_NAVAL] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                "RESTORE DATABASE [BATALLA_NAVAL] FROM DISK = N'{0}' WITH REPLACE; " +
                "ALTER DATABASE [BATALLA_NAVAL] SET MULTI_USER;",
                rutaSegura);
            acceso.EjecutarSqlMaster(sql);
        }

        public string ObtenerRutaBackupPorDefecto()
        {
            try
            {
                string sql = "DECLARE @dir nvarchar(4000); " +
                             "EXEC master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE', N'Software\\Microsoft\\MSSQLServer\\MSSQLServer', N'BackupDirectory', @dir OUTPUT; " +
                             "SELECT @dir;";
                object res = acceso.LeerEscalarMaster(sql);
                if (res != null && res != DBNull.Value)
                {
                    return res.ToString();
                }
            }
            catch
            {
            }
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}

