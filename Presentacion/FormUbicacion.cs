using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormUbicacion : Form
    {
        private BE.USUARIO jugador;
        private BLL.BATALLA_NAVAL logica = new BLL.BATALLA_NAVAL();
        private Button[,] botones = new Button[BE.TABLERO.TAMANO, BE.TABLERO.TAMANO];

        public BE.TABLERO TableroArmado { get; private set; }

        public FormUbicacion(BE.USUARIO jugadorActual)
        {
            InitializeComponent();
            this.jugador = jugadorActual;
            this.TableroArmado = new BE.TABLERO();
        }

        private void FormUbicacion_Load(object sender, EventArgs e)
        {
            GestorImagenes.Cargar();
            lblTitulo.Text = "Ubicación de Flota - Jugador: " + jugador.Nombre + " (Tablero 15 x 15)";
            CrearGrillaTablero();
            RefrescarListaNaves();
            if (lstNaves.Items.Count > 0) lstNaves.SelectedIndex = 0;
            RefrescarTablero();
        }

        private void CrearGrillaTablero()
        {
            int tam = 28;
            int offsetX = 28;
            int offsetY = 26;

            // Encabezados de columnas A - O
            for (int c = 0; c < BE.TABLERO.TAMANO; c++)
            {
                Label lblCol = new Label();
                lblCol.Text = ((char)('A' + c)).ToString();
                lblCol.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                lblCol.TextAlign = ContentAlignment.MiddleCenter;
                lblCol.Location = new Point(offsetX + c * tam, 4);
                lblCol.Size = new Size(tam, 20);
                pnlTablero.Controls.Add(lblCol);
            }

            // Encabezados de filas 1 - 15 y botones
            for (int f = 0; f < BE.TABLERO.TAMANO; f++)
            {
                Label lblFila = new Label();
                lblFila.Text = (f + 1).ToString();
                lblFila.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                lblFila.TextAlign = ContentAlignment.MiddleCenter;
                lblFila.Location = new Point(2, offsetY + f * tam);
                lblFila.Size = new Size(24, tam);
                pnlTablero.Controls.Add(lblFila);

                for (int c = 0; c < BE.TABLERO.TAMANO; c++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(offsetX + c * tam, offsetY + f * tam);
                    btn.Size = new Size(tam, tam);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(30, 80, 130);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.BackColor = Color.LightSkyBlue;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Tag = new Point(f, c);
                    btn.Click += Celda_Click;

                    botones[f, c] = btn;
                    pnlTablero.Controls.Add(btn);
                }
            }
        }

        private void Celda_Click(object sender, EventArgs e)
        {
            if (lstNaves.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una nave de la lista primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Button btn = (Button)sender;
            Point pos = (Point)btn.Tag;
            int fila = pos.X;
            int col = pos.Y;

            BE.NAVE nave = TableroArmado.Naves[lstNaves.SelectedIndex];
            bool horizontal = rbHorizontal.Checked;

            bool colocada = logica.ColocarNave(TableroArmado, nave, fila, col, horizontal);
            if (!colocada)
            {
                MessageBox.Show("No se puede ubicar '" + nave.Nombre + "' en esa posición (se sale del tablero o se superpone con otra nave).",
                    "Posición inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idxActual = lstNaves.SelectedIndex;
            RefrescarListaNaves();
            RefrescarTablero();

            // Seleccionar automáticamente la siguiente nave pendiente
            for (int i = 0; i < TableroArmado.Naves.Count; i++)
            {
                if (!TableroArmado.Naves[i].Colocada)
                {
                    lstNaves.SelectedIndex = i;
                    return;
                }
            }
            lstNaves.SelectedIndex = idxActual;
        }

        private void RefrescarListaNaves()
        {
            int seleccionado = lstNaves.SelectedIndex;
            lstNaves.Items.Clear();
            foreach (BE.NAVE nave in TableroArmado.Naves)
            {
                lstNaves.Items.Add(nave.ToString());
            }
            if (seleccionado >= 0 && seleccionado < lstNaves.Items.Count)
            {
                lstNaves.SelectedIndex = seleccionado;
            }
        }

        private void RefrescarTablero()
        {
            for (int f = 0; f < BE.TABLERO.TAMANO; f++)
            {
                for (int c = 0; c < BE.TABLERO.TAMANO; c++)
                {
                    Button btn = botones[f, c];
                    btn.Text = "";
                    if (TableroArmado.Celdas[f, c] == 1)
                    {
                        btn.BackColor = Color.DarkSlateGray;
                        btn.BackgroundImage = GestorImagenes.ObtenerImagenNave(TableroArmado, f, c);
                    }
                    else
                    {
                        btn.BackColor = Color.LightSkyBlue;
                        btn.BackgroundImage = GestorImagenes.Mar;
                    }
                }
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            logica.UbicarFlotaAleatoria(TableroArmado);
            RefrescarListaNaves();
            RefrescarTablero();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TableroArmado.Reiniciar();
            RefrescarListaNaves();
            if (lstNaves.Items.Count > 0) lstNaves.SelectedIndex = 0;
            RefrescarTablero();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!logica.TodasLasNavesUbicadas(TableroArmado))
            {
                MessageBox.Show("Debe ubicar las 5 naves antes de confirmar.", "Faltan naves", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

