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
			this.btnUsuarios = new System.Windows.Forms.Button();
			this.btnMensajes = new System.Windows.Forms.Button();
			this.btnVideos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.Location = new System.Drawing.Point(12, 12);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(121, 61);
			this.btnUsuarios.TabIndex = 0;
			this.btnUsuarios.Text = "Usuarios";
			this.btnUsuarios.UseVisualStyleBackColor = true;
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// btnMensajes
			// 
			this.btnMensajes.Location = new System.Drawing.Point(141, 12);
			this.btnMensajes.Name = "btnMensajes";
			this.btnMensajes.Size = new System.Drawing.Size(121, 61);
			this.btnMensajes.TabIndex = 1;
			this.btnMensajes.Text = "Mensajes";
			this.btnMensajes.UseVisualStyleBackColor = true;
			// 
			// btnVideos
			// 
			this.btnVideos.Location = new System.Drawing.Point(268, 12);
			this.btnVideos.Name = "btnVideos";
			this.btnVideos.Size = new System.Drawing.Size(121, 61);
			this.btnVideos.TabIndex = 2;
			this.btnVideos.Text = "Videos";
			this.btnVideos.UseVisualStyleBackColor = true;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 174);
			this.Controls.Add(this.btnVideos);
			this.Controls.Add(this.btnMensajes);
			this.Controls.Add(this.btnUsuarios);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmPrincipal";
			this.Text = "FrmPrincipal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.Button btnMensajes;
		private System.Windows.Forms.Button btnVideos;
	}
}

