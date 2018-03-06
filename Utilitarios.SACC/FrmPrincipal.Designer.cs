namespace Utilitarios.SACC
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnVideos = new System.Windows.Forms.Button();
            this.btnAvisos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideos
            // 
            this.btnVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVideos.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideos.Image = global::Utilitarios.SACC.Properties.Resources.video_player;
            this.btnVideos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideos.Location = new System.Drawing.Point(279, 99);
            this.btnVideos.Name = "btnVideos";
            this.btnVideos.Size = new System.Drawing.Size(249, 137);
            this.btnVideos.TabIndex = 2;
            this.btnVideos.Text = "Videos";
            this.btnVideos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVideos.UseVisualStyleBackColor = false;
            this.btnVideos.Click += new System.EventHandler(this.btnVideos_Click);
            // 
            // btnAvisos
            // 
            this.btnAvisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAvisos.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAvisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvisos.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvisos.Image = global::Utilitarios.SACC.Properties.Resources.clipboards;
            this.btnAvisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvisos.Location = new System.Drawing.Point(15, 165);
            this.btnAvisos.Name = "btnAvisos";
            this.btnAvisos.Size = new System.Drawing.Size(249, 137);
            this.btnAvisos.TabIndex = 1;
            this.btnAvisos.Text = "Avisos";
            this.btnAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvisos.UseVisualStyleBackColor = false;
            this.btnAvisos.Click += new System.EventHandler(this.btnAvisos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = global::Utilitarios.SACC.Properties.Resources.user;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(15, 16);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(249, 137);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 317);
            this.Controls.Add(this.btnVideos);
            this.Controls.Add(this.btnAvisos);
            this.Controls.Add(this.btnUsuarios);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.Button btnAvisos;
		private System.Windows.Forms.Button btnVideos;
	}
}

