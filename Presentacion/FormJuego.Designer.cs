namespace Presentacion
{
    partial class FormJuego
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblNavesInfo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTituloAtaque;
        private System.Windows.Forms.Panel pnlAtaque;
        private System.Windows.Forms.Label lblTituloPropio;
        private System.Windows.Forms.Panel pnlPropio;
        private System.Windows.Forms.Button btnTogglePropio;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Button btnEmpate;
        private System.Windows.Forms.Button btnRendirse;
        private System.Windows.Forms.Label lblReferencias;
        private System.Windows.Forms.Timer timerPartida;

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
            this.components = new System.ComponentModel.Container();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNavesInfo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloAtaque = new System.Windows.Forms.Label();
            this.pnlAtaque = new System.Windows.Forms.Panel();
            this.lblTituloPropio = new System.Windows.Forms.Label();
            this.pnlPropio = new System.Windows.Forms.Panel();
            this.btnTogglePropio = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.btnEmpate = new System.Windows.Forms.Button();
            this.btnRendirse = new System.Windows.Forms.Button();
            this.lblReferencias = new System.Windows.Forms.Label();
            this.timerPartida = new System.Windows.Forms.Timer(this.components);
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.Green;
            this.pnlSuperior.Controls.Add(this.lblTurno);
            this.pnlSuperior.Controls.Add(this.lblNavesInfo);
            this.pnlSuperior.Controls.Add(this.lblTiempo);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(980, 58);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblTurno
            // 
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTurno.ForeColor = System.Drawing.Color.White;
            this.lblTurno.Location = new System.Drawing.Point(15, 8);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(340, 26);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno: Jugador 1";
            // 
            // lblNavesInfo
            // 
            this.lblNavesInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavesInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lblNavesInfo.Location = new System.Drawing.Point(15, 34);
            this.lblNavesInfo.Name = "lblNavesInfo";
            this.lblNavesInfo.Size = new System.Drawing.Size(500, 20);
            this.lblNavesInfo.TabIndex = 1;
            this.lblNavesInfo.Text = "Naves restantes: J1 (5) | J2 (5)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.Gold;
            this.lblTiempo.Location = new System.Drawing.Point(780, 14);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(185, 30);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo: 00:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResultado.Location = new System.Drawing.Point(15, 66);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(950, 32);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Haga clic en un casillero del Tablero de Ataque para disparar.";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloAtaque
            // 
            this.lblTituloAtaque.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloAtaque.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTituloAtaque.Location = new System.Drawing.Point(15, 104);
            this.lblTituloAtaque.Name = "lblTituloAtaque";
            this.lblTituloAtaque.Size = new System.Drawing.Size(390, 20);
            this.lblTituloAtaque.TabIndex = 2;
            this.lblTituloAtaque.Text = "TABLERO DE ATAQUE (Disparar al rival)";
            // 
            // pnlAtaque
            // 
            this.pnlAtaque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAtaque.Location = new System.Drawing.Point(15, 126);
            this.pnlAtaque.Name = "pnlAtaque";
            this.pnlAtaque.Size = new System.Drawing.Size(392, 392);
            this.pnlAtaque.TabIndex = 3;
            // 
            // lblTituloPropio
            // 
            this.lblTituloPropio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloPropio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.lblTituloPropio.Location = new System.Drawing.Point(422, 104);
            this.lblTituloPropio.Name = "lblTituloPropio";
            this.lblTituloPropio.Size = new System.Drawing.Size(265, 20);
            this.lblTituloPropio.TabIndex = 4;
            this.lblTituloPropio.Text = "MI TABLERO (Flota propia - Oculto)";
            // 
            // pnlPropio
            // 
            this.pnlPropio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPropio.Location = new System.Drawing.Point(422, 126);
            this.pnlPropio.Name = "pnlPropio";
            this.pnlPropio.Size = new System.Drawing.Size(392, 392);
            this.pnlPropio.TabIndex = 6;
            // 
            // btnTogglePropio
            // 
            this.btnTogglePropio.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnTogglePropio.Location = new System.Drawing.Point(688, 100);
            this.btnTogglePropio.Name = "btnTogglePropio";
            this.btnTogglePropio.Size = new System.Drawing.Size(126, 24);
            this.btnTogglePropio.TabIndex = 5;
            this.btnTogglePropio.Text = "Mostrar Mi Tablero";
            this.btnTogglePropio.Click += new System.EventHandler(this.btnTogglePropio_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHistorial.Location = new System.Drawing.Point(824, 104);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(145, 20);
            this.lblHistorial.TabIndex = 7;
            this.lblHistorial.Text = "Historial de Turnos";
            // 
            // lstHistorial
            // 
            this.lstHistorial.Font = new System.Drawing.Font("Consolas", 8F);
            this.lstHistorial.Location = new System.Drawing.Point(824, 126);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(145, 381);
            this.lstHistorial.TabIndex = 8;
            // 
            // btnEmpate
            // 
            this.btnEmpate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmpate.Location = new System.Drawing.Point(710, 524);
            this.btnEmpate.Name = "btnEmpate";
            this.btnEmpate.Size = new System.Drawing.Size(125, 32);
            this.btnEmpate.TabIndex = 10;
            this.btnEmpate.Text = "Acordar Empate";
            this.btnEmpate.Click += new System.EventHandler(this.btnEmpate_Click);
            // 
            // btnRendirse
            // 
            this.btnRendirse.BackColor = System.Drawing.Color.Brown;
            this.btnRendirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRendirse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRendirse.ForeColor = System.Drawing.Color.White;
            this.btnRendirse.Location = new System.Drawing.Point(844, 524);
            this.btnRendirse.Name = "btnRendirse";
            this.btnRendirse.Size = new System.Drawing.Size(125, 32);
            this.btnRendirse.TabIndex = 11;
            this.btnRendirse.Text = "Rendirse";
            this.btnRendirse.UseVisualStyleBackColor = false;
            this.btnRendirse.Click += new System.EventHandler(this.btnRendirse_Click);
            // 
            // lblReferencias
            // 
            this.lblReferencias.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblReferencias.ForeColor = System.Drawing.Color.DimGray;
            this.lblReferencias.Location = new System.Drawing.Point(15, 528);
            this.lblReferencias.Name = "lblReferencias";
            this.lblReferencias.Size = new System.Drawing.Size(680, 22);
            this.lblReferencias.TabIndex = 9;
            this.lblReferencias.Text = "Referencias:  Mar (sin disparar)  |  Salpicadura (Agua)  |  Explosión (Tocado)  |" +
    "  Cruz roja (Hundido)  |  Barco (Flota propia)";
            // 
            // timerPartida
            // 
            this.timerPartida.Interval = 1000;
            this.timerPartida.Tick += new System.EventHandler(this.timerPartida_Tick);
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTituloAtaque);
            this.Controls.Add(this.pnlAtaque);
            this.Controls.Add(this.lblTituloPropio);
            this.Controls.Add(this.btnTogglePropio);
            this.Controls.Add(this.pnlPropio);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblReferencias);
            this.Controls.Add(this.btnEmpate);
            this.Controls.Add(this.btnRendirse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalla Naval - Partida en Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJuego_FormClosing);
            this.Load += new System.EventHandler(this.FormJuego_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
