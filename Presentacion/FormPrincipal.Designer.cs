namespace Presentacion
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpJugador1;
        private System.Windows.Forms.Label lblUserJ1;
        private System.Windows.Forms.Label lblPassJ1;
        private System.Windows.Forms.TextBox txtUserJ1;
        private System.Windows.Forms.TextBox txtPassJ1;
        private System.Windows.Forms.Button btnLoginJ1;
        private System.Windows.Forms.Button btnLogoutJ1;
        private System.Windows.Forms.Label lblEstadoJ1;

        private System.Windows.Forms.GroupBox grpJugador2;
        private System.Windows.Forms.Label lblUserJ2;
        private System.Windows.Forms.Label lblPassJ2;
        private System.Windows.Forms.TextBox txtUserJ2;
        private System.Windows.Forms.TextBox txtPassJ2;
        private System.Windows.Forms.Button btnLoginJ2;
        private System.Windows.Forms.Button btnLogoutJ2;
        private System.Windows.Forms.Label lblEstadoJ2;

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.Label lblRegPass;
        private System.Windows.Forms.Label lblRegPass2;
        private System.Windows.Forms.TextBox txtRegUser;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.TextBox txtRegPass2;
        private System.Windows.Forms.Button btnRegistrar;

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnHistorialXml;
        private System.Windows.Forms.Button btnBackup;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpJugador1 = new System.Windows.Forms.GroupBox();
            this.lblUserJ1 = new System.Windows.Forms.Label();
            this.txtUserJ1 = new System.Windows.Forms.TextBox();
            this.lblPassJ1 = new System.Windows.Forms.Label();
            this.txtPassJ1 = new System.Windows.Forms.TextBox();
            this.btnLoginJ1 = new System.Windows.Forms.Button();
            this.btnLogoutJ1 = new System.Windows.Forms.Button();
            this.lblEstadoJ1 = new System.Windows.Forms.Label();
            this.grpJugador2 = new System.Windows.Forms.GroupBox();
            this.lblUserJ2 = new System.Windows.Forms.Label();
            this.txtUserJ2 = new System.Windows.Forms.TextBox();
            this.lblPassJ2 = new System.Windows.Forms.Label();
            this.txtPassJ2 = new System.Windows.Forms.TextBox();
            this.btnLoginJ2 = new System.Windows.Forms.Button();
            this.btnLogoutJ2 = new System.Windows.Forms.Button();
            this.lblEstadoJ2 = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.lblRegPass = new System.Windows.Forms.Label();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.lblRegPass2 = new System.Windows.Forms.Label();
            this.txtRegPass2 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnHistorialXml = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.grpJugador1.SuspendLayout();
            this.grpJugador2.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BATALLA NAVAL - 2 JUGADORES (15x15)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpJugador1
            // 
            this.grpJugador1.Controls.Add(this.lblUserJ1);
            this.grpJugador1.Controls.Add(this.txtUserJ1);
            this.grpJugador1.Controls.Add(this.lblPassJ1);
            this.grpJugador1.Controls.Add(this.txtPassJ1);
            this.grpJugador1.Controls.Add(this.btnLoginJ1);
            this.grpJugador1.Controls.Add(this.btnLogoutJ1);
            this.grpJugador1.Controls.Add(this.lblEstadoJ1);
            this.grpJugador1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpJugador1.Location = new System.Drawing.Point(20, 60);
            this.grpJugador1.Name = "grpJugador1";
            this.grpJugador1.Size = new System.Drawing.Size(245, 210);
            this.grpJugador1.TabIndex = 1;
            this.grpJugador1.TabStop = false;
            this.grpJugador1.Text = "Jugador 1 - Inicio de Sesión";
            // 
            // lblUserJ1
            // 
            this.lblUserJ1.AutoSize = true;
            this.lblUserJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserJ1.Location = new System.Drawing.Point(15, 30);
            this.lblUserJ1.Name = "lblUserJ1";
            this.lblUserJ1.Size = new System.Drawing.Size(50, 15);
            this.lblUserJ1.TabIndex = 0;
            this.lblUserJ1.Text = "Usuario:";
            // 
            // txtUserJ1
            // 
            this.txtUserJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserJ1.Location = new System.Drawing.Point(15, 50);
            this.txtUserJ1.Name = "txtUserJ1";
            this.txtUserJ1.Size = new System.Drawing.Size(212, 23);
            this.txtUserJ1.TabIndex = 1;
            // 
            // lblPassJ1
            // 
            this.lblPassJ1.AutoSize = true;
            this.lblPassJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassJ1.Location = new System.Drawing.Point(15, 82);
            this.lblPassJ1.Name = "lblPassJ1";
            this.lblPassJ1.Size = new System.Drawing.Size(70, 15);
            this.lblPassJ1.TabIndex = 2;
            this.lblPassJ1.Text = "Contraseña:";
            // 
            // txtPassJ1
            // 
            this.txtPassJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassJ1.Location = new System.Drawing.Point(15, 102);
            this.txtPassJ1.Name = "txtPassJ1";
            this.txtPassJ1.PasswordChar = '*';
            this.txtPassJ1.Size = new System.Drawing.Size(212, 23);
            this.txtPassJ1.TabIndex = 3;
            // 
            // btnLoginJ1
            // 
            this.btnLoginJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoginJ1.Location = new System.Drawing.Point(15, 138);
            this.btnLoginJ1.Name = "btnLoginJ1";
            this.btnLoginJ1.Size = new System.Drawing.Size(102, 30);
            this.btnLoginJ1.TabIndex = 4;
            this.btnLoginJ1.Text = "Iniciar Sesión";
            this.btnLoginJ1.Click += new System.EventHandler(this.btnLoginJ1_Click);
            // 
            // btnLogoutJ1
            // 
            this.btnLogoutJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogoutJ1.Location = new System.Drawing.Point(125, 138);
            this.btnLogoutJ1.Name = "btnLogoutJ1";
            this.btnLogoutJ1.Size = new System.Drawing.Size(102, 30);
            this.btnLogoutJ1.TabIndex = 5;
            this.btnLogoutJ1.Text = "Cerrar Sesión";
            this.btnLogoutJ1.Click += new System.EventHandler(this.btnLogoutJ1_Click);
            // 
            // lblEstadoJ1
            // 
            this.lblEstadoJ1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoJ1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEstadoJ1.Location = new System.Drawing.Point(15, 178);
            this.lblEstadoJ1.Name = "lblEstadoJ1";
            this.lblEstadoJ1.Size = new System.Drawing.Size(215, 22);
            this.lblEstadoJ1.TabIndex = 6;
            this.lblEstadoJ1.Text = "Estado: Sin sesión";
            // 
            // grpJugador2
            // 
            this.grpJugador2.Controls.Add(this.lblUserJ2);
            this.grpJugador2.Controls.Add(this.txtUserJ2);
            this.grpJugador2.Controls.Add(this.lblPassJ2);
            this.grpJugador2.Controls.Add(this.txtPassJ2);
            this.grpJugador2.Controls.Add(this.btnLoginJ2);
            this.grpJugador2.Controls.Add(this.btnLogoutJ2);
            this.grpJugador2.Controls.Add(this.lblEstadoJ2);
            this.grpJugador2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpJugador2.Location = new System.Drawing.Point(278, 60);
            this.grpJugador2.Name = "grpJugador2";
            this.grpJugador2.Size = new System.Drawing.Size(245, 210);
            this.grpJugador2.TabIndex = 2;
            this.grpJugador2.TabStop = false;
            this.grpJugador2.Text = "Jugador 2 - Inicio de Sesión";
            // 
            // lblUserJ2
            // 
            this.lblUserJ2.AutoSize = true;
            this.lblUserJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserJ2.Location = new System.Drawing.Point(15, 30);
            this.lblUserJ2.Name = "lblUserJ2";
            this.lblUserJ2.Size = new System.Drawing.Size(50, 15);
            this.lblUserJ2.TabIndex = 0;
            this.lblUserJ2.Text = "Usuario:";
            // 
            // txtUserJ2
            // 
            this.txtUserJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserJ2.Location = new System.Drawing.Point(15, 50);
            this.txtUserJ2.Name = "txtUserJ2";
            this.txtUserJ2.Size = new System.Drawing.Size(212, 23);
            this.txtUserJ2.TabIndex = 1;
            // 
            // lblPassJ2
            // 
            this.lblPassJ2.AutoSize = true;
            this.lblPassJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassJ2.Location = new System.Drawing.Point(15, 82);
            this.lblPassJ2.Name = "lblPassJ2";
            this.lblPassJ2.Size = new System.Drawing.Size(70, 15);
            this.lblPassJ2.TabIndex = 2;
            this.lblPassJ2.Text = "Contraseña:";
            // 
            // txtPassJ2
            // 
            this.txtPassJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassJ2.Location = new System.Drawing.Point(15, 102);
            this.txtPassJ2.Name = "txtPassJ2";
            this.txtPassJ2.PasswordChar = '*';
            this.txtPassJ2.Size = new System.Drawing.Size(212, 23);
            this.txtPassJ2.TabIndex = 3;
            // 
            // btnLoginJ2
            // 
            this.btnLoginJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoginJ2.Location = new System.Drawing.Point(15, 138);
            this.btnLoginJ2.Name = "btnLoginJ2";
            this.btnLoginJ2.Size = new System.Drawing.Size(102, 30);
            this.btnLoginJ2.TabIndex = 4;
            this.btnLoginJ2.Text = "Iniciar Sesión";
            this.btnLoginJ2.Click += new System.EventHandler(this.btnLoginJ2_Click);
            // 
            // btnLogoutJ2
            // 
            this.btnLogoutJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogoutJ2.Location = new System.Drawing.Point(125, 138);
            this.btnLogoutJ2.Name = "btnLogoutJ2";
            this.btnLogoutJ2.Size = new System.Drawing.Size(102, 30);
            this.btnLogoutJ2.TabIndex = 5;
            this.btnLogoutJ2.Text = "Cerrar Sesión";
            this.btnLogoutJ2.Click += new System.EventHandler(this.btnLogoutJ2_Click);
            // 
            // lblEstadoJ2
            // 
            this.lblEstadoJ2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoJ2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEstadoJ2.Location = new System.Drawing.Point(15, 178);
            this.lblEstadoJ2.Name = "lblEstadoJ2";
            this.lblEstadoJ2.Size = new System.Drawing.Size(215, 22);
            this.lblEstadoJ2.TabIndex = 6;
            this.lblEstadoJ2.Text = "Estado: Sin sesión";
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.lblRegUser);
            this.grpRegistro.Controls.Add(this.txtRegUser);
            this.grpRegistro.Controls.Add(this.lblRegPass);
            this.grpRegistro.Controls.Add(this.txtRegPass);
            this.grpRegistro.Controls.Add(this.lblRegPass2);
            this.grpRegistro.Controls.Add(this.txtRegPass2);
            this.grpRegistro.Controls.Add(this.btnRegistrar);
            this.grpRegistro.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRegistro.Location = new System.Drawing.Point(536, 60);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(244, 210);
            this.grpRegistro.TabIndex = 3;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registrarse";
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegUser.Location = new System.Drawing.Point(15, 26);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(112, 15);
            this.lblRegUser.TabIndex = 0;
            this.lblRegUser.Text = "Nombre de usuario:";
            // 
            // txtRegUser
            // 
            this.txtRegUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegUser.Location = new System.Drawing.Point(15, 45);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(212, 23);
            this.txtRegUser.TabIndex = 1;
            // 
            // lblRegPass
            // 
            this.lblRegPass.AutoSize = true;
            this.lblRegPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegPass.Location = new System.Drawing.Point(15, 73);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(70, 15);
            this.lblRegPass.TabIndex = 2;
            this.lblRegPass.Text = "Contraseña:";
            // 
            // txtRegPass
            // 
            this.txtRegPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegPass.Location = new System.Drawing.Point(15, 92);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.PasswordChar = '*';
            this.txtRegPass.Size = new System.Drawing.Size(212, 23);
            this.txtRegPass.TabIndex = 3;
            // 
            // lblRegPass2
            // 
            this.lblRegPass2.AutoSize = true;
            this.lblRegPass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegPass2.Location = new System.Drawing.Point(15, 120);
            this.lblRegPass2.Name = "lblRegPass2";
            this.lblRegPass2.Size = new System.Drawing.Size(108, 15);
            this.lblRegPass2.TabIndex = 4;
            this.lblRegPass2.Text = "Repetir contraseña:";
            // 
            // txtRegPass2
            // 
            this.txtRegPass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegPass2.Location = new System.Drawing.Point(15, 139);
            this.txtRegPass2.Name = "txtRegPass2";
            this.txtRegPass2.PasswordChar = '*';
            this.txtRegPass2.Size = new System.Drawing.Size(212, 23);
            this.txtRegPass2.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(15, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(212, 30);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnJugar);
            this.grpMenu.Controls.Add(this.btnEstadisticas);
            this.grpMenu.Controls.Add(this.btnBitacora);
            this.grpMenu.Controls.Add(this.btnHistorialXml);
            this.grpMenu.Controls.Add(this.btnBackup);
            this.grpMenu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpMenu.Location = new System.Drawing.Point(20, 282);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(760, 130);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Green;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnJugar.ForeColor = System.Drawing.Color.White;
            this.btnJugar.Location = new System.Drawing.Point(15, 30);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(730, 42);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "JUGAR BATALLA NAVAL";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstadisticas.Location = new System.Drawing.Point(15, 82);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(175, 34);
            this.btnEstadisticas.TabIndex = 1;
            this.btnEstadisticas.Text = "Estadísticas y Ranking";
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBitacora.Location = new System.Drawing.Point(200, 82);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(175, 34);
            this.btnBitacora.TabIndex = 2;
            this.btnBitacora.Text = "Ver Bitácora";
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnHistorialXml
            // 
            this.btnHistorialXml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistorialXml.Location = new System.Drawing.Point(385, 82);
            this.btnHistorialXml.Name = "btnHistorialXml";
            this.btnHistorialXml.Size = new System.Drawing.Size(175, 34);
            this.btnHistorialXml.TabIndex = 3;
            this.btnHistorialXml.Text = "Historial Partidas";
            this.btnHistorialXml.Click += new System.EventHandler(this.btnHistorialXml_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackup.Location = new System.Drawing.Point(570, 82);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(175, 34);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup / Restore BD";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpJugador1);
            this.Controls.Add(this.grpJugador2);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalla Naval - TP DAS / LUG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.grpJugador1.ResumeLayout(false);
            this.grpJugador1.PerformLayout();
            this.grpJugador2.ResumeLayout(false);
            this.grpJugador2.PerformLayout();
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
