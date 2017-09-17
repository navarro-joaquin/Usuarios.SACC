namespace Utilitarios.SACC
{
	partial class FrmPasswordUsuario
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtConfirmacion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.usuariosTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtConfirmacion);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.lblPassword);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(317, 91);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Introduzca su nueva contraseña";
			// 
			// txtConfirmacion
			// 
			this.txtConfirmacion.Location = new System.Drawing.Point(139, 50);
			this.txtConfirmacion.MaxLength = 30;
			this.txtConfirmacion.Name = "txtConfirmacion";
			this.txtConfirmacion.PasswordChar = '*';
			this.txtConfirmacion.Size = new System.Drawing.Size(162, 21);
			this.txtConfirmacion.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Confirmación:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(139, 18);
			this.txtPassword.MaxLength = 30;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(162, 21);
			this.txtPassword.TabIndex = 1;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(7, 21);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(109, 15);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Nueva contraseña:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(13, 111);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(93, 43);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(237, 111);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(93, 43);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// usuariosTableAdapter
			// 
			this.usuariosTableAdapter.ClearBeforeFill = true;
			// 
			// FrmPasswordUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 168);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmPasswordUsuario";
			this.Text = "FrmPasswordUsuario";
			this.Load += new System.EventHandler(this.FrmPasswordUsuario_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtConfirmacion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnSalir;
		private cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
	}
}