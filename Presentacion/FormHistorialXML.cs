using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormHistorialXML : Form
    {
        private BLL.PARTIDA gestorPartida = new BLL.PARTIDA();
        private BLL.XML_PARTIDA gestorXml = new BLL.XML_PARTIDA();

        public FormHistorialXML()
        {
            InitializeComponent();
        }

        private void FormHistorialXML_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }

        private void CargarPartidas()
        {
            try
            {
                List<BE.PARTIDA> lista = gestorPartida.Listar();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Jugador 1");
                dt.Columns.Add("Jugador 2");
                dt.Columns.Add("Imp. J1", typeof(int));
                dt.Columns.Add("Imp. J2", typeof(int));
                dt.Columns.Add("Ganador");
                dt.Columns.Add("Duración");
                dt.Columns.Add("ArchivoXML");

                foreach (BE.PARTIDA p in lista)
                {
                    dt.Rows.Add(
                        p.Id,
                        p.Fecha.ToString("dd/MM/yyyy HH:mm"),
                        p.NombreJugador1,
                        p.NombreJugador2,
                        p.ImpactosJ1,
                        p.ImpactosJ2,
                        p.NombreGanador,
                        p.DuracionFormateada,
                        p.ArchivoXml
                    );
                }

                dgvPartidas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de partidas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPartidas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPartidas.CurrentRow == null) return;

            object val = dgvPartidas.CurrentRow.Cells["ArchivoXML"].Value;
            if (val == null) return;

            string ruta = val.ToString();
            CargarMovimientosXml(ruta);
        }

        private void CargarMovimientosXml(string rutaArchivo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rutaArchivo) || !File.Exists(rutaArchivo))
                {
                    dgvMovimientos.DataSource = null;
                    lblMovimientos.Text = "Movimientos registrados en XML: (archivo no encontrado)";
                    return;
                }

                List<BE.MOVIMIENTO> movs = gestorXml.LeerMovimientos(rutaArchivo);
                DataTable dt = new DataTable();
                dt.Columns.Add("Turno", typeof(int));
                dt.Columns.Add("Fecha y Hora");
                dt.Columns.Add("Jugador");
                dt.Columns.Add("Coordenada");
                dt.Columns.Add("Resultado");
                dt.Columns.Add("Nave Afectada");

                foreach (BE.MOVIMIENTO m in movs)
                {
                    dt.Rows.Add(
                        m.NumeroTurno,
                        m.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"),
                        m.Jugador,
                        m.Coordenada,
                        m.Resultado,
                        string.IsNullOrEmpty(m.NaveAfectada) ? "-" : m.NaveAfectada
                    );
                }

                dgvMovimientos.DataSource = dt;
                lblMovimientos.Text = "Movimientos registrados en XML (" + Path.GetFileName(rutaArchivo) + " - " + movs.Count + " turnos):";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo XML: " + ex.Message, "Error XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo XML de partida";
            ofd.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";

            string carpetaDefecto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PartidasXML");
            if (Directory.Exists(carpetaDefecto))
            {
                ofd.InitialDirectory = carpetaDefecto;
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CargarMovimientosXml(ofd.FileName);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

