namespace Presentacion
{
    partial class FormUbicacion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTablero;
        private System.Windows.Forms.GroupBox grpFlota;
        private System.Windows.Forms.ListBox lstNaves;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.RadioButton rbVertical;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAyuda;

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
            this.pnlTablero = new System.Windows.Forms.Panel();
            this.grpFlota = new System.Windows.Forms.GroupBox();
            this.lstNaves = new System.Windows.Forms.ListBox();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.rbVertical = new System.Windows.Forms.RadioButton();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpFlota.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ubicación de Flota (Tablero 15 x 15)";
            // 
            // pnlTablero
            // 
            this.pnlTablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTablero.Location = new System.Drawing.Point(15, 45);
            this.pnlTablero.Name = "pnlTablero";
            this.pnlTablero.Size = new System.Drawing.Size(460, 460);
            this.pnlTablero.TabIndex = 1;
            // 
            // grpFlota
            // 
            this.grpFlota.Controls.Add(this.lstNaves);
            this.grpFlota.Controls.Add(this.rbHorizontal);
            this.grpFlota.Controls.Add(this.rbVertical);
            this.grpFlota.Controls.Add(this.lblAyuda);
            this.grpFlota.Controls.Add(this.btnAleatorio);
            this.grpFlota.Controls.Add(this.btnLimpiar);
            this.grpFlota.Controls.Add(this.btnConfirmar);
            this.grpFlota.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpFlota.Location = new System.Drawing.Point(490, 45);
            this.grpFlota.Name = "grpFlota";
            this.grpFlota.Size = new System.Drawing.Size(285, 460);
            this.grpFlota.TabIndex = 2;
            this.grpFlota.TabStop = false;
            this.grpFlota.Text = "Naves a Ubicar";
            // 
            // lstNaves
            // 
            this.lstNaves.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstNaves.ItemHeight = 17;
            this.lstNaves.Location = new System.Drawing.Point(15, 28);
            this.lstNaves.Name = "lstNaves";
            this.lstNaves.Size = new System.Drawing.Size(255, 140);
            this.lstNaves.TabIndex = 0;
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Checked = true;
            this.rbHorizontal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbHorizontal.Location = new System.Drawing.Point(15, 192);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(86, 21);
            this.rbHorizontal.TabIndex = 1;
            this.rbHorizontal.TabStop = true;
            this.rbHorizontal.Text = "Horizontal";
            // 
            // rbVertical
            // 
            this.rbVertical.AutoSize = true;
            this.rbVertical.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbVertical.Location = new System.Drawing.Point(135, 192);
            this.rbVertical.Name = "rbVertical";
            this.rbVertical.Size = new System.Drawing.Size(68, 21);
            this.rbVertical.TabIndex = 2;
            this.rbVertical.Text = "Vertical";
            // 
            // lblAyuda
            // 
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAyuda.ForeColor = System.Drawing.Color.DimGray;
            this.lblAyuda.Location = new System.Drawing.Point(15, 225);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(255, 70);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Seleccione una nave de la lista, elija la orientación y haga clic en el casillero" +
    " inicial del tablero. También puede ubicar la flota de forma aleatoria.";
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAleatorio.Location = new System.Drawing.Point(15, 305);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(255, 36);
            this.btnAleatorio.TabIndex = 4;
            this.btnAleatorio.Text = "Ubicar Flota Aleatoria";
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLimpiar.Location = new System.Drawing.Point(15, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(255, 36);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Tablero";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(15, 400);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(255, 44);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar Ubicación";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 520);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlTablero);
            this.Controls.Add(this.grpFlota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ubicación de Naves";
            this.Load += new System.EventHandler(this.FormUbicacion_Load);
            this.grpFlota.ResumeLayout(false);
            this.grpFlota.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
