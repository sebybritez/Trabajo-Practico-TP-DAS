using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private BLL.USUARIO gestorUsuario = new BLL.USUARIO();
        private BLL.BITACORA gestorBitacora = new BLL.BITACORA();

        private BE.USUARIO jug1 = null;
        private BE.USUARIO jug2 = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLoginJ1_Click(object sender, EventArgs e)
        {
            try
            {
                if (jug1 != null)
                {
                    MessageBox.Show("Primero cierre la sesión del Jugador 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BE.USUARIO u = gestorUsuario.Login(txtUserJ1.Text, txtPassJ1.Text);
                if (u == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (jug2 != null && jug2.Id == u.Id)
                {
                    MessageBox.Show("Ese usuario ya inició sesión como Jugador 2.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                jug1 = u;
                lblEstadoJ1.Text = "Conectado: " + jug1.Nombre;
                lblEstadoJ1.ForeColor = Color.DarkGreen;
                txtPassJ1.Text = "";

                gestorBitacora.Registrar(jug1.Id, "Inicio de sesión", "Inicio de sesión como Jugador 1");
                MessageBox.Show("Bienvenido " + jug1.Nombre + " (Jugador 1).", "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogoutJ1_Click(object sender, EventArgs e)
        {
            if (jug1 == null) return;

            try
            {
                gestorBitacora.Registrar(jug1.Id, "Cierre de sesión", "Cierre de sesión Jugador 1");
            }
            catch
            {
            }

            string nombre = jug1.Nombre;
            jug1 = null;
            lblEstadoJ1.Text = "Estado: Sin sesión";
            lblEstadoJ1.ForeColor = Color.DarkRed;
            txtUserJ1.Text = "";
            txtPassJ1.Text = "";
            MessageBox.Show("Sesión cerrada: " + nombre, "Cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoginJ2_Click(object sender, EventArgs e)
        {
            try
            {
                if (jug2 != null)
                {
                    MessageBox.Show("Primero cierre la sesión del Jugador 2.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BE.USUARIO u = gestorUsuario.Login(txtUserJ2.Text, txtPassJ2.Text);
                if (u == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (jug1 != null && jug1.Id == u.Id)
                {
                    MessageBox.Show("Ese usuario ya inició sesión como Jugador 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                jug2 = u;
                lblEstadoJ2.Text = "Conectado: " + jug2.Nombre;
                lblEstadoJ2.ForeColor = Color.DarkGreen;
                txtPassJ2.Text = "";

                gestorBitacora.Registrar(jug2.Id, "Inicio de sesión", "Inicio de sesión como Jugador 2");
                MessageBox.Show("Bienvenido " + jug2.Nombre + " (Jugador 2).", "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogoutJ2_Click(object sender, EventArgs e)
        {
            if (jug2 == null) return;

            try
            {
                gestorBitacora.Registrar(jug2.Id, "Cierre de sesión", "Cierre de sesión Jugador 2");
            }
            catch
            {
            }

            string nombre = jug2.Nombre;
            jug2 = null;
            lblEstadoJ2.Text = "Estado: Sin sesión";
            lblEstadoJ2.ForeColor = Color.DarkRed;
            txtUserJ2.Text = "";
            txtPassJ2.Text = "";
            MessageBox.Show("Sesión cerrada: " + nombre, "Cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRegUser.Text) || string.IsNullOrWhiteSpace(txtRegPass.Text))
                {
                    MessageBox.Show("Complete usuario y contraseña.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtRegPass.Text != txtRegPass2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BE.USUARIO nuevo = new BE.USUARIO();
                nuevo.Nombre = txtRegUser.Text.Trim();
                nuevo.Contrasena = txtRegPass.Text;

                bool pudo = gestorUsuario.Registrar(nuevo);
                if (pudo)
                {
                    MessageBox.Show("Usuario registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRegUser.Text = "";
                    txtRegPass.Text = "";
                    txtRegPass2.Text = "";
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre.", "Registro rechazado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (jug1 == null || jug2 == null)
            {
                MessageBox.Show("Deben iniciar sesión ambos jugadores antes de comenzar la partida.", "Faltan jugadores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fase 1: Ubicación de naves Jugador 1
            MessageBox.Show("Turno de " + jug1.Nombre + " para ubicar su flota.\n(" + jug2.Nombre + " no debe mirar la pantalla).",
                "Fase de Ubicación - Jugador 1", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormUbicacion fUb1 = new FormUbicacion(jug1);
            if (fUb1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Fase 2: Ubicación de naves Jugador 2
            MessageBox.Show("Turno de " + jug2.Nombre + " para ubicar su flota.\n(" + jug1.Nombre + " no debe mirar la pantalla).",
                "Fase de Ubicación - Jugador 2", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormUbicacion fUb2 = new FormUbicacion(jug2);
            if (fUb2.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Fase 3: Partida
            FormJuego fJuego = new FormJuego(jug1, jug2, fUb1.TableroArmado, fUb2.TableroArmado);
            fJuego.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas f = new FormEstadisticas();
            f.ShowDialog();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            FormBitacora f = new FormBitacora();
            f.ShowDialog();
        }

        private void btnHistorialXml_Click(object sender, EventArgs e)
        {
            FormHistorialXML f = new FormHistorialXML();
            f.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FormBackup f = new FormBackup();
            f.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (jug1 != null)
                {
                    gestorBitacora.Registrar(jug1.Id, "Cierre de sesión", "Cierre automático al salir de la aplicación (Jugador 1)");
                }
                if (jug2 != null)
                {
                    gestorBitacora.Registrar(jug2.Id, "Cierre de sesión", "Cierre automático al salir de la aplicación (Jugador 2)");
                }
            }
            catch
            {
            }
        }
    }
}

