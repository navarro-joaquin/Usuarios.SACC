namespace Utilitarios.SACC
{
    partial class FrmConfCorreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCorreoDestino = new System.Windows.Forms.TextBox();
            this.lblCorreoDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(31, 28);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(91, 18);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor SMTP:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(128, 25);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(195, 21);
            this.txtServidor.TabIndex = 1;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(362, 28);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(84, 18);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto SMTP:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(452, 25);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(62, 21);
            this.txtPuerto.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 18);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Correo remitente:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(128, 68);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(124, 21);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(285, 71);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(74, 18);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(365, 68);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 21);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(223, 155);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCorreoDestino
            // 
            this.txtCorreoDestino.Location = new System.Drawing.Point(128, 112);
            this.txtCorreoDestino.Name = "txtCorreoDestino";
            this.txtCorreoDestino.Size = new System.Drawing.Size(124, 21);
            this.txtCorreoDestino.TabIndex = 10;
            // 
            // lblCorreoDestino
            // 
            this.lblCorreoDestino.AutoSize = true;
            this.lblCorreoDestino.Location = new System.Drawing.Point(27, 115);
            this.lblCorreoDestino.Name = "lblCorreoDestino";
            this.lblCorreoDestino.Size = new System.Drawing.Size(95, 18);
            this.lblCorreoDestino.TabIndex = 9;
            this.lblCorreoDestino.Text = "Correo destino:";
            // 
            // FrmConfCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 199);
            this.Controls.Add(this.txtCorreoDestino);
            this.Controls.Add(this.lblCorreoDestino);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConfCorreo";
            this.Text = "FrmConfCorreo";
            this.Load += new System.EventHandler(this.FrmConfCorreo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCorreoDestino;
        private System.Windows.Forms.Label lblCorreoDestino;
    }
}