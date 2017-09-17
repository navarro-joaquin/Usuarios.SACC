namespace Utilitarios.SACC
{
	partial class FrmLogin
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label lblLogin;
			System.Windows.Forms.Label lblPassword;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cessa_bdsaccDataSet = new Utilitarios.SACC.cessa_bdsaccDataSet();
			this.usuariosTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter();
			this.tableAdapterManager = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager();
			lblLogin = new System.Windows.Forms.Label();
			lblPassword = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLogin
			// 
			lblLogin.AutoSize = true;
			lblLogin.Location = new System.Drawing.Point(15, 35);
			lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblLogin.Name = "lblLogin";
			lblLogin.Size = new System.Drawing.Size(60, 18);
			lblLogin.TabIndex = 0;
			lblLogin.Text = "Usuario:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new System.Drawing.Point(15, 75);
			lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new System.Drawing.Size(81, 18);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "Contraseña:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLogin);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(lblLogin);
			this.groupBox1.Controls.Add(lblPassword);
			this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(323, 111);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Introduce tus datos para ingresar al sistema";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(115, 33);
			this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtLogin.MaxLength = 30;
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(192, 23);
			this.txtLogin.TabIndex = 1;
			this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(115, 72);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPassword.MaxLength = 30;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(192, 23);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(16, 132);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(121, 33);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Iniciar Sesión";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(217, 132);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(121, 33);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// usuariosBindingSource
			// 
			this.usuariosBindingSource.DataMember = "usuarios";
			this.usuariosBindingSource.DataSource = this.cessa_bdsaccDataSet;
			// 
			// cessa_bdsaccDataSet
			// 
			this.cessa_bdsaccDataSet.DataSetName = "cessa_bdsaccDataSet";
			this.cessa_bdsaccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usuariosTableAdapter
			// 
			this.usuariosTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.mensajesTableAdapter = null;
			this.tableAdapterManager.ticketsTableAdapter = null;
			this.tableAdapterManager.tiposTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 174);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLogin2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private cessa_bdsaccDataSet cessa_bdsaccDataSet;
		private System.Windows.Forms.BindingSource usuariosBindingSource;
		private cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
		private cessa_bdsaccDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtPassword;
	}
}