using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormBackup : Form
    {
        private BLL.BACKUP gestorBackup = new BLL.BACKUP();
        private string carpetaDefecto;

        public FormBackup()
        {
            InitializeComponent();
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {
            carpetaDefecto = gestorBackup.ObtenerRutaPorDefecto();
            string nombreSugerido = string.Format("BATALLA_NAVAL_{0:yyyyMMdd_HHmmss}.bak", DateTime.Now);
            txtRutaBackup.Text = Path.Combine(carpetaDefecto, nombreSugerido);
        }

        private void btnExaminarBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar Backup de Base de Datos";
            sfd.Filter = "Archivo de Backup (*.bak)|*.bak";
            sfd.InitialDirectory = carpetaDefecto;
            sfd.FileName = string.Format("BATALLA_NAVAL_{0:yyyyMMdd_HHmmss}.bak", DateTime.Now);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = sfd.FileName;
            }
        }

        private void btnRealizarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRutaBackup.Text))
                {
                    MessageBox.Show("Seleccione la ruta donde guardar el backup.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gestorBackup.RealizarBackup(txtRutaBackup.Text.Trim());
                txtRutaRestore.Text = txtRutaBackup.Text.Trim();
                MessageBox.Show("Backup generado correctamente en:\n" + txtRutaBackup.Text.Trim(),
                    "Backup exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el backup:\n" + ex.Message +
                    "\n\nNota: asegúrese de elegir una carpeta donde el servicio de SQL Server tenga permisos de escritura (por ejemplo la carpeta por defecto de Backup de SQL Server).",
                    "Error de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminarRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo de Backup para Restore";
            ofd.Filter = "Archivo de Backup (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
            ofd.InitialDirectory = carpetaDefecto;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaRestore.Text = ofd.FileName;
            }
        }

        private void btnRealizarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRutaRestore.Text))
                {
                    MessageBox.Show("Seleccione un archivo .bak para restaurar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Está seguro que desea restaurar la base de datos BATALLA_NAVAL?\nSe sobrescribirán los datos actuales.",
                    "Confirmar Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r != DialogResult.Yes) return;

                gestorBackup.RealizarRestore(txtRutaRestore.Text.Trim());
                MessageBox.Show("Base de datos restaurada correctamente.", "Restore exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos:\n" + ex.Message,
                    "Error de Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
