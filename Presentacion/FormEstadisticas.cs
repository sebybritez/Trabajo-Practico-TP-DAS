using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEstadisticas : Form
    {
        private BLL.USUARIO gestorUsuario = new BLL.USUARIO();

        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            try
            {
                List<BE.USUARIO> usuarios = gestorUsuario.Listar();
                DataTable dt = new DataTable();
                dt.Columns.Add("Jugador");
                dt.Columns.Add("Jugadas", typeof(int));
                dt.Columns.Add("Ganadas", typeof(int));
                dt.Columns.Add("Perdidas", typeof(int));
                dt.Columns.Add("Empatadas", typeof(int));
                dt.Columns.Add("Promedio Victorias (%)");
                dt.Columns.Add("Tiempo Total Jugado");
                dt.Columns.Add("Segundos Totales", typeof(int));

                foreach (BE.USUARIO u in usuarios)
                {
                    dt.Rows.Add(
                        u.Nombre,
                        u.PartidasJugadas,
                        u.Ganadas,
                        u.Perdidas,
                        u.Empatadas,
                        u.PromedioVictorias.ToString("0.00") + " %",
                        u.TiempoJugadoFormateado,
                        u.SegundosJugados
                    );
                }

                dgvEstadisticas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

