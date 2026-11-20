namespace Presentacion
{
    partial class FormBackup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Label lblRutaBackup;
        private System.Windows.Forms.TextBox txtRutaBackup;
        private System.Windows.Forms.Button btnExaminarBackup;
        private System.Windows.Forms.Button btnRealizarBackup;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Label lblRutaRestore;
        private System.Windows.Forms.TextBox txtRutaRestore;
        private System.Windows.Forms.Button btnExaminarRestore;
        private System.Windows.Forms.Button btnRealizarRestore;
        private System.Windows.Forms.Button btnCerrar;

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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.lblRutaBackup = new System.Windows.Forms.Label();
            this.txtRutaBackup = new System.Windows.Forms.TextBox();
            this.btnExaminarBackup = new System.Windows.Forms.Button();
            this.btnRealizarBackup = new System.Windows.Forms.Button();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lblRutaRestore = new System.Windows.Forms.Label();
            this.txtRutaRestore = new System.Windows.Forms.TextBox();
            this.btnExaminarRestore = new System.Windows.Forms.Button();
            this.btnRealizarRestore = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(570, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Backup y Restore de la Base de Datos (BATALLA_NAVAL)";
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.lblRutaBackup);
            this.grpBackup.Controls.Add(this.txtRutaBackup);
            this.grpBackup.Controls.Add(this.btnExaminarBackup);
            this.grpBackup.Controls.Add(this.btnRealizarBackup);
            this.grpBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpBackup.Location = new System.Drawing.Point(15, 50);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(570, 125);
            this.grpBackup.TabIndex = 1;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Realizar Backup (Respaldo)";
            // 
            // lblRutaBackup
            // 
            this.lblRutaBackup.AutoSize = true;
            this.lblRutaBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRutaBackup.Location = new System.Drawing.Point(15, 28);
            this.lblRutaBackup.Name = "lblRutaBackup";
            this.lblRutaBackup.Size = new System.Drawing.Size(196, 15);
            this.lblRutaBackup.TabIndex = 0;
            this.lblRutaBackup.Text = "Dirección destino del archivo (.bak):";
            // 
            // txtRutaBackup
            // 
            this.txtRutaBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRutaBackup.Location = new System.Drawing.Point(15, 48);
            this.txtRutaBackup.Name = "txtRutaBackup";
            this.txtRutaBackup.Size = new System.Drawing.Size(440, 23);
            this.txtRutaBackup.TabIndex = 1;
            // 
            // btnExaminarBackup
            // 
            this.btnExaminarBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExaminarBackup.Location = new System.Drawing.Point(465, 46);
            this.btnExaminarBackup.Name = "btnExaminarBackup";
            this.btnExaminarBackup.Size = new System.Drawing.Size(90, 26);
            this.btnExaminarBackup.TabIndex = 2;
            this.btnExaminarBackup.Text = "Examinar...";
            this.btnExaminarBackup.Click += new System.EventHandler(this.btnExaminarBackup_Click);
            // 
            // btnRealizarBackup
            // 
            this.btnRealizarBackup.BackColor = System.Drawing.Color.Green;
            this.btnRealizarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRealizarBackup.ForeColor = System.Drawing.Color.White;
            this.btnRealizarBackup.Location = new System.Drawing.Point(15, 80);
            this.btnRealizarBackup.Name = "btnRealizarBackup";
            this.btnRealizarBackup.Size = new System.Drawing.Size(165, 32);
            this.btnRealizarBackup.TabIndex = 3;
            this.btnRealizarBackup.Text = "Generar Backup";
            this.btnRealizarBackup.UseVisualStyleBackColor = false;
            this.btnRealizarBackup.Click += new System.EventHandler(this.btnRealizarBackup_Click);
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.lblRutaRestore);
            this.grpRestore.Controls.Add(this.txtRutaRestore);
            this.grpRestore.Controls.Add(this.btnExaminarRestore);
            this.grpRestore.Controls.Add(this.btnRealizarRestore);
            this.grpRestore.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRestore.Location = new System.Drawing.Point(15, 190);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(570, 125);
            this.grpRestore.TabIndex = 2;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Realizar Restore (Restauración)";
            // 
            // lblRutaRestore
            // 
            this.lblRutaRestore.AutoSize = true;
            this.lblRutaRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRutaRestore.Location = new System.Drawing.Point(15, 28);
            this.lblRutaRestore.Name = "lblRutaRestore";
            this.lblRutaRestore.Size = new System.Drawing.Size(148, 15);
            this.lblRutaRestore.TabIndex = 0;
            this.lblRutaRestore.Text = "Archivo de respaldo (.bak):";
            // 
            // txtRutaRestore
            // 
            this.txtRutaRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRutaRestore.Location = new System.Drawing.Point(15, 48);
            this.txtRutaRestore.Name = "txtRutaRestore";
            this.txtRutaRestore.Size = new System.Drawing.Size(440, 23);
            this.txtRutaRestore.TabIndex = 1;
            // 
            // btnExaminarRestore
            // 
            this.btnExaminarRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExaminarRestore.Location = new System.Drawing.Point(465, 46);
            this.btnExaminarRestore.Name = "btnExaminarRestore";
            this.btnExaminarRestore.Size = new System.Drawing.Size(90, 26);
            this.btnExaminarRestore.TabIndex = 2;
            this.btnExaminarRestore.Text = "Examinar...";
            this.btnExaminarRestore.Click += new System.EventHandler(this.btnExaminarRestore_Click);
            // 
            // btnRealizarRestore
            // 
            this.btnRealizarRestore.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRealizarRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarRestore.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRealizarRestore.ForeColor = System.Drawing.Color.White;
            this.btnRealizarRestore.Location = new System.Drawing.Point(15, 80);
            this.btnRealizarRestore.Name = "btnRealizarRestore";
            this.btnRealizarRestore.Size = new System.Drawing.Size(165, 32);
            this.btnRealizarRestore.TabIndex = 3;
            this.btnRealizarRestore.Text = "Restaurar Base";
            this.btnRealizarRestore.UseVisualStyleBackColor = false;
            this.btnRealizarRestore.Click += new System.EventHandler(this.btnRealizarRestore_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCerrar.Location = new System.Drawing.Point(485, 328);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 372);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpBackup);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup y Restore - SQL Server";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
