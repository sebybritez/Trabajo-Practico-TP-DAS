using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormBitacora : Form
    {
        private BLL.BITACORA gestorBitacora = new BLL.BITACORA();
        private List<BE.BITACORA> listaCompleta = new List<BE.BITACORA>();

        public FormBitacora()
        {
            InitializeComponent();
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("Todos");
            cmbFiltro.Items.Add("Inicio de sesión");
            cmbFiltro.Items.Add("Cierre de sesión");
            cmbFiltro.Items.Add("Comienzo de partida");
            cmbFiltro.Items.Add("Finalización de partida");
            cmbFiltro.SelectedIndex = 0;

            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                listaCompleta = gestorBitacora.Listar();
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltro()
        {
            string filtro = cmbFiltro.SelectedItem != null ? cmbFiltro.SelectedItem.ToString() : "Todos";

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Fecha y Hora");
            dt.Columns.Add("Usuario");
            dt.Columns.Add("Evento");
            dt.Columns.Add("Detalle");

            foreach (BE.BITACORA b in listaCompleta)
            {
                if (filtro == "Todos" || b.Evento == filtro)
                {
                    dt.Rows.Add(b.Id, b.Fecha.ToString("dd/MM/yyyy HH:mm:ss"), b.NombreUsuario, b.Evento, b.Detalle);
                }
            }

            dgvBitacora.DataSource = dt;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

