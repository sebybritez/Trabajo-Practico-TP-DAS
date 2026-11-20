using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormJuego : Form
    {
        private BE.USUARIO j1;
        private BE.USUARIO j2;
        private BE.TABLERO tablero1;
        private BE.TABLERO tablero2;

        private BLL.BATALLA_NAVAL logica = new BLL.BATALLA_NAVAL();
        private BLL.USUARIO gestorUsuario = new BLL.USUARIO();
        private BLL.BITACORA gestorBitacora = new BLL.BITACORA();
        private BLL.PARTIDA gestorPartida = new BLL.PARTIDA();
        private BLL.XML_PARTIDA gestorXml = new BLL.XML_PARTIDA();

        private Button[,] btnAtaque = new Button[BE.TABLERO.TAMANO, BE.TABLERO.TAMANO];
        private Button[,] btnPropio = new Button[BE.TABLERO.TAMANO, BE.TABLERO.TAMANO];

        private List<BE.MOVIMIENTO> movimientos = new List<BE.MOVIMIENTO>();
        private int turnoActual = 1; // 1 = Jugador 1, 2 = Jugador 2
        private int numeroMovimiento = 0;
        private int impactosJ1 = 0;
        private int impactosJ2 = 0;
        private int segundosTranscurridos = 0;
        private bool mostrarPropio = false;
        private bool partidaFinalizada = false;

        public FormJuego(BE.USUARIO jugador1, BE.USUARIO jugador2, BE.TABLERO tab1, BE.TABLERO tab2)
        {
            InitializeComponent();
            this.j1 = jugador1;
            this.j2 = jugador2;
            this.tablero1 = tab1;
            this.tablero2 = tab2;
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            GestorImagenes.Cargar();
            CrearGrilla(pnlAtaque, btnAtaque, true);
            CrearGrilla(pnlPropio, btnPropio, false);

            try
            {
                gestorBitacora.Registrar(j1.Id, "Comienzo de partida",
                    string.Format("Partida iniciada: {0} vs {1}", j1.Nombre, j2.Nombre));
            }
            catch
            {
            }

            ActualizarVista();
            timerPartida.Start();
        }

        private void CrearGrilla(Panel contenedor, Button[,] matriz, bool esAtaque)
        {
            int tam = 24;
            int offsetX = 26;
            int offsetY = 24;

            for (int c = 0; c < BE.TABLERO.TAMANO; c++)
            {
                Label lblCol = new Label();
                lblCol.Text = ((char)('A' + c)).ToString();
                lblCol.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
                lblCol.TextAlign = ContentAlignment.MiddleCenter;
                lblCol.Location = new Point(offsetX + c * tam, 2);
                lblCol.Size = new Size(tam, 20);
                contenedor.Controls.Add(lblCol);
            }

            for (int f = 0; f < BE.TABLERO.TAMANO; f++)
            {
                Label lblFila = new Label();
                lblFila.Text = (f + 1).ToString();
                lblFila.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
                lblFila.TextAlign = ContentAlignment.MiddleCenter;
                lblFila.Location = new Point(2, offsetY + f * tam);
                lblFila.Size = new Size(22, tam);
                contenedor.Controls.Add(lblFila);

                for (int c = 0; c < BE.TABLERO.TAMANO; c++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(offsetX + c * tam, offsetY + f * tam);
                    btn.Size = new Size(tam, tam);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(30, 80, 130);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
                    btn.Tag = new Point(f, c);

                    if (esAtaque)
                    {
                        btn.Click += CeldaAtaque_Click;
                    }
                    else
                    {
                        btn.TabStop = false;
                        btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    }

                    matriz[f, c] = btn;
                    contenedor.Controls.Add(btn);
                }
            }
        }

        private void ActualizarVista()
        {
            BE.USUARIO actual = (turnoActual == 1) ? j1 : j2;
            BE.USUARIO rival = (turnoActual == 1) ? j2 : j1;
            BE.TABLERO tabPropio = (turnoActual == 1) ? tablero1 : tablero2;
            BE.TABLERO tabEnemigo = (turnoActual == 1) ? tablero2 : tablero1;

            pnlSuperior.BackColor = (turnoActual == 1)
                ? Color.FromArgb(20, 50, 90)
                : Color.FromArgb(20, 85, 75);

            lblTurno.Text = "Turno actual: " + actual.Nombre;
            lblNavesInfo.Text = string.Format("Naves restantes: {0} ({1})  |  {2} ({3})",
                j1.Nombre, logica.ContarNavesRestantes(tablero1),
                j2.Nombre, logica.ContarNavesRestantes(tablero2));

            lblTituloAtaque.Text = string.Format("TABLERO DE ATAQUE (Disparar a {0})", rival.Nombre);
            lblTituloPropio.Text = mostrarPropio
                ? string.Format("MI TABLERO ({0})", actual.Nombre)
                : string.Format("MI TABLERO ({0} - Oculto)", actual.Nombre);
            btnTogglePropio.Text = mostrarPropio ? "Ocultar Mi Tablero" : "Mostrar Mi Tablero";

            for (int f = 0; f < BE.TABLERO.TAMANO; f++)
            {
                for (int c = 0; c < BE.TABLERO.TAMANO; c++)
                {
                    int estado = tabEnemigo.Celdas[f, c];
                    Button b = btnAtaque[f, c];
                    b.Text = "";

                    if (estado == 2) // Agua disparada
                    {
                        b.BackColor = Color.DodgerBlue;
                        b.BackgroundImage = GestorImagenes.Agua;
                    }
                    else if (estado == 3) // Tocado
                    {
                        b.BackColor = Color.DarkOrange;
                        b.BackgroundImage = GestorImagenes.Tocado;
                    }
                    else if (estado == 4) // Hundido
                    {
                        b.BackColor = Color.DarkRed;
                        b.BackgroundImage = GestorImagenes.Hundido;
                    }
                    else // 0 o 1 (oculto al atacante)
                    {
                        b.BackColor = Color.LightSkyBlue;
                        b.BackgroundImage = GestorImagenes.Mar;
                    }
                }
            }

            // Dibujar tablero propio
            for (int f = 0; f < BE.TABLERO.TAMANO; f++)
            {
                for (int c = 0; c < BE.TABLERO.TAMANO; c++)
                {
                    Button b = btnPropio[f, c];
                    b.Text = "";
                    if (!mostrarPropio)
                    {
                        b.BackColor = Color.DimGray;
                        b.BackgroundImage = GestorImagenes.Oculto;
                        continue;
                    }

                    int estado = tabPropio.Celdas[f, c];
                    if (estado == 1)
                    {
                        b.BackColor = Color.DarkSlateGray;
                        b.BackgroundImage = GestorImagenes.ObtenerImagenNave(tabPropio, f, c);
                    }
                    else if (estado == 2)
                    {
                        b.BackColor = Color.DodgerBlue;
                        b.BackgroundImage = GestorImagenes.Agua;
                    }
                    else if (estado == 3)
                    {
                        b.BackColor = Color.DarkOrange;
                        b.BackgroundImage = GestorImagenes.Tocado;
                    }
                    else if (estado == 4)
                    {
                        b.BackColor = Color.DarkRed;
                        b.BackgroundImage = GestorImagenes.Hundido;
                    }
                    else
                    {
                        b.BackColor = Color.LightSkyBlue;
                        b.BackgroundImage = GestorImagenes.Mar;
                    }
                }
            }
        }

        private void CeldaAtaque_Click(object sender, EventArgs e)
        {
            if (partidaFinalizada) return;

            Button btn = (Button)sender;
            Point pos = (Point)btn.Tag;
            int fila = pos.X;
            int col = pos.Y;

            BE.USUARIO atacante = (turnoActual == 1) ? j1 : j2;
            BE.TABLERO tabEnemigo = (turnoActual == 1) ? tablero2 : tablero1;

            string naveAfectada;
            string resultado = logica.ProcesarDisparo(tabEnemigo, fila, col, out naveAfectada);

            if (resultado == "YaDisparado")
            {
                MessageBox.Show("Ya disparaste en ese casillero. Elegí otro.", "Casillero repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            numeroMovimiento++;
            string coord = logica.ObtenerCoordenada(fila, col);

            if (resultado == "Tocado" || resultado == "Hundido")
            {
                if (turnoActual == 1) impactosJ1++;
                else impactosJ2++;
            }

            // Registrar movimiento para XML
            BE.MOVIMIENTO mov = new BE.MOVIMIENTO();
            mov.NumeroTurno = numeroMovimiento;
            mov.FechaHora = DateTime.Now;
            mov.Jugador = atacante.Nombre;
            mov.Fila = fila + 1;
            mov.Columna = col + 1;
            mov.Coordenada = coord;
            mov.Resultado = resultado;
            mov.NaveAfectada = naveAfectada;
            movimientos.Add(mov);

            // Mostrar resultado del turno
            if (resultado == "Agua")
            {
                lblResultado.Text = string.Format("Turno #{0} - {1} disparó en {2}: AGUA", numeroMovimiento, atacante.Nombre, coord);
                lblResultado.BackColor = Color.FromArgb(210, 235, 255);
                lblResultado.ForeColor = Color.Navy;
                lstHistorial.Items.Insert(0, string.Format("#{0} {1} {2}: Agua", numeroMovimiento, atacante.Nombre, coord));
            }
            else if (resultado == "Tocado")
            {
                lblResultado.Text = string.Format("Turno #{0} - {1} disparó en {2}: ¡TOCADO! ({3})", numeroMovimiento, atacante.Nombre, coord, naveAfectada);
                lblResultado.BackColor = Color.FromArgb(255, 230, 190);
                lblResultado.ForeColor = Color.DarkOrange;
                lstHistorial.Items.Insert(0, string.Format("#{0} {1} {2}: Tocado", numeroMovimiento, atacante.Nombre, coord));
            }
            else if (resultado == "Hundido")
            {
                lblResultado.Text = string.Format("Turno #{0} - {1} disparó en {2}: ¡HUNDIDO! ({3})", numeroMovimiento, atacante.Nombre, coord, naveAfectada);
                lblResultado.BackColor = Color.FromArgb(255, 210, 210);
                lblResultado.ForeColor = Color.DarkRed;
                lstHistorial.Items.Insert(0, string.Format("#{0} {1} {2}: HUNDIDO!", numeroMovimiento, atacante.Nombre, coord));
            }

            // Verificar si ganó
            if (logica.TodasLasNavesHundidas(tabEnemigo))
            {
                ActualizarVista();
                FinalizarPartida(atacante.Id, atacante.Nombre, "Hundió toda la flota rival");
                return;
            }

            // Cambiar de turno y ocultar tablero propio por privacidad
            turnoActual = (turnoActual == 1) ? 2 : 1;
            mostrarPropio = false;
            ActualizarVista();
        }

        private void FinalizarPartida(int idGanador, string nombreGanador, string motivo)
        {
            if (partidaFinalizada) return;
            partidaFinalizada = true;
            timerPartida.Stop();

            int duracion = Math.Max(1, segundosTranscurridos);

            BE.PARTIDA partida = new BE.PARTIDA();
            partida.Fecha = DateTime.Now;
            partida.IdJugador1 = j1.Id;
            partida.NombreJugador1 = j1.Nombre;
            partida.IdJugador2 = j2.Id;
            partida.NombreJugador2 = j2.Nombre;
            partida.ImpactosJ1 = impactosJ1;
            partida.ImpactosJ2 = impactosJ2;
            partida.IdGanador = idGanador;
            partida.NombreGanador = nombreGanador;
            partida.DuracionSegundos = duracion;

            string rutaXml = "";
            try
            {
                rutaXml = gestorXml.GuardarMovimientos(partida, movimientos);
                partida.ArchivoXml = rutaXml;

                gestorPartida.Guardar(partida);
                gestorUsuario.RegistrarResultadoPartida(j1, j2, idGanador, duracion);

                int idUsuarioBitacora = (idGanador != 0) ? idGanador : j1.Id;
                gestorBitacora.Registrar(idUsuarioBitacora, "Finalización de partida",
                    string.Format("Resultado: {0} ({1}) | Duración: {2}s", nombreGanador, motivo, duracion));
            }
            catch (Exception ex)
            {
                MessageBox.Show("La partida finalizó, pero ocurrió un error al guardar datos: " + ex.Message,
                    "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string msg = string.Format(
                "¡PARTIDA FINALIZADA!\n\n" +
                "Resultado: {0}\n" +
                "Motivo: {1}\n" +
                "Impactos {2}: {3}\n" +
                "Impactos {4}: {5}\n" +
                "Duración: {6}\n" +
                "Movimientos registrados en XML:\n{7}",
                (idGanador == 0 ? "EMPATE" : "Ganador: " + nombreGanador),
                motivo,
                j1.Nombre, impactosJ1,
                j2.Nombre, impactosJ2,
                partida.DuracionFormateada,
                rutaXml);

            MessageBox.Show(msg, "Fin de Partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnTogglePropio_Click(object sender, EventArgs e)
        {
            mostrarPropio = !mostrarPropio;
            ActualizarVista();
        }

        private void btnEmpate_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Ambos jugadores acuerdan terminar la partida en EMPATE?",
                "Acordar Empate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                FinalizarPartida(0, "Empate", "Empate acordado por ambos jugadores");
            }
        }

        private void btnRendirse_Click(object sender, EventArgs e)
        {
            BE.USUARIO actual = (turnoActual == 1) ? j1 : j2;
            BE.USUARIO rival = (turnoActual == 1) ? j2 : j1;

            DialogResult r = MessageBox.Show(
                string.Format("¿Seguro que {0} desea rendirse? La victoria será para {1}.", actual.Nombre, rival.Nombre),
                "Rendirse", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                FinalizarPartida(rival.Id, rival.Nombre, actual.Nombre + " se rindió");
            }
        }

        private void timerPartida_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            TimeSpan ts = TimeSpan.FromSeconds(segundosTranscurridos);
            lblTiempo.Text = string.Format("Tiempo: {0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
        }

        private void FormJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!partidaFinalizada)
            {
                DialogResult r = MessageBox.Show("La partida está en curso. Si cierra ahora se cancelará sin guardar resultado. ¿Desea salir?",
                    "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                timerPartida.Stop();
                try
                {
                    gestorBitacora.Registrar(j1.Id, "Finalización de partida",
                        string.Format("Partida cancelada sin finalizar ({0} vs {1})", j1.Nombre, j2.Nombre));
                }
                catch
                {
                }
            }
        }
    }
}

