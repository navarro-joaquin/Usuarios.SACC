namespace Utilitarios.SACC
{
	partial class FrmOpUsuario
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
			System.Windows.Forms.Label lblNombre;
			System.Windows.Forms.Label lblCargo;
			System.Windows.Forms.Label lblRol;
			System.Windows.Forms.Label lblUbicacion;
			System.Windows.Forms.Label lblEstado;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cessa_bdsaccDataSet = new Utilitarios.SACC.cessa_bdsaccDataSet();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.dtpCreado = new System.Windows.Forms.DateTimePicker();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.usuariosTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter();
			this.tableAdapterManager = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager();
			this.lblCreado = new System.Windows.Forms.Label();
			this.cmbCargo = new System.Windows.Forms.ComboBox();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.cmbUbicacion = new System.Windows.Forms.ComboBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			lblLogin = new System.Windows.Forms.Label();
			lblPassword = new System.Windows.Forms.Label();
			lblNombre = new System.Windows.Forms.Label();
			lblCargo = new System.Windows.Forms.Label();
			lblRol = new System.Windows.Forms.Label();
			lblUbicacion = new System.Windows.Forms.Label();
			lblEstado = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLogin
			// 
			lblLogin.AutoSize = true;
			lblLogin.Location = new System.Drawing.Point(12, 23);
			lblLogin.Name = "lblLogin";
			lblLogin.Size = new System.Drawing.Size(41, 15);
			lblLogin.TabIndex = 2;
			lblLogin.Text = "Login:";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new System.Drawing.Point(12, 50);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new System.Drawing.Size(73, 15);
			lblPassword.TabIndex = 4;
			lblPassword.Text = "Contraseña:";
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new System.Drawing.Point(12, 77);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new System.Drawing.Size(55, 15);
			lblNombre.TabIndex = 6;
			lblNombre.Text = "Nombre:";
			// 
			// lblCargo
			// 
			lblCargo.AutoSize = true;
			lblCargo.Location = new System.Drawing.Point(12, 104);
			lblCargo.Name = "lblCargo";
			lblCargo.Size = new System.Drawing.Size(43, 15);
			lblCargo.TabIndex = 8;
			lblCargo.Text = "Cargo:";
			// 
			// lblRol
			// 
			lblRol.AutoSize = true;
			lblRol.Location = new System.Drawing.Point(12, 134);
			lblRol.Name = "lblRol";
			lblRol.Size = new System.Drawing.Size(29, 15);
			lblRol.TabIndex = 10;
			lblRol.Text = "Rol:";
			// 
			// lblUbicacion
			// 
			lblUbicacion.AutoSize = true;
			lblUbicacion.Location = new System.Drawing.Point(12, 163);
			lblUbicacion.Name = "lblUbicacion";
			lblUbicacion.Size = new System.Drawing.Size(65, 15);
			lblUbicacion.TabIndex = 12;
			lblUbicacion.Text = "Ubicación:";
			// 
			// lblEstado
			// 
			lblEstado.AutoSize = true;
			lblEstado.Location = new System.Drawing.Point(12, 192);
			lblEstado.Name = "lblEstado";
			lblEstado.Size = new System.Drawing.Size(48, 15);
			lblEstado.TabIndex = 14;
			lblEstado.Text = "Estado:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbEstado);
			this.groupBox1.Controls.Add(this.cmbUbicacion);
			this.groupBox1.Controls.Add(this.cmbRol);
			this.groupBox1.Controls.Add(this.cmbCargo);
			this.groupBox1.Controls.Add(this.lblCreado);
			this.groupBox1.Controls.Add(lblLogin);
			this.groupBox1.Controls.Add(this.txtLogin);
			this.groupBox1.Controls.Add(lblPassword);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(lblNombre);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(lblCargo);
			this.groupBox1.Controls.Add(lblRol);
			this.groupBox1.Controls.Add(lblUbicacion);
			this.groupBox1.Controls.Add(lblEstado);
			this.groupBox1.Controls.Add(this.dtpCreado);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 256);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del usuario";
			// 
			// txtLogin
			// 
			this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "login", true));
			this.txtLogin.Location = new System.Drawing.Point(150, 20);
			this.txtLogin.MaxLength = 30;
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(174, 21);
			this.txtLogin.TabIndex = 3;
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
			// txtPassword
			// 
			this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "password", true));
			this.txtPassword.Location = new System.Drawing.Point(150, 47);
			this.txtPassword.MaxLength = 30;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(174, 21);
			this.txtPassword.TabIndex = 5;
			// 
			// txtNombre
			// 
			this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nombre", true));
			this.txtNombre.Location = new System.Drawing.Point(150, 74);
			this.txtNombre.MaxLength = 60;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(174, 21);
			this.txtNombre.TabIndex = 7;
			// 
			// dtpCreado
			// 
			this.dtpCreado.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuariosBindingSource, "creado", true));
			this.dtpCreado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCreado.Location = new System.Drawing.Point(150, 218);
			this.dtpCreado.Name = "dtpCreado";
			this.dtpCreado.Size = new System.Drawing.Size(174, 21);
			this.dtpCreado.TabIndex = 17;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 274);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(96, 44);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(260, 274);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(96, 44);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
			// lblCreado
			// 
			this.lblCreado.AutoSize = true;
			this.lblCreado.Location = new System.Drawing.Point(12, 223);
			this.lblCreado.Name = "lblCreado";
			this.lblCreado.Size = new System.Drawing.Size(50, 15);
			this.lblCreado.TabIndex = 18;
			this.lblCreado.Text = "Creado:";
			// 
			// cmbCargo
			// 
			this.cmbCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "cargo", true));
			this.cmbCargo.FormattingEnabled = true;
			this.cmbCargo.Items.AddRange(new object[] {
            "PLATAFORMA",
            "CAJAS",
            "RRPP",
            "ADMINISTRADOR"});
			this.cmbCargo.Location = new System.Drawing.Point(150, 101);
			this.cmbCargo.Name = "cmbCargo";
			this.cmbCargo.Size = new System.Drawing.Size(174, 23);
			this.cmbCargo.TabIndex = 19;
			this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
			// 
			// cmbRol
			// 
			this.cmbRol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "rol", true));
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Location = new System.Drawing.Point(150, 131);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(174, 23);
			this.cmbRol.TabIndex = 20;
			this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
			// 
			// cmbUbicacion
			// 
			this.cmbUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "ubicacion", true));
			this.cmbUbicacion.FormattingEnabled = true;
			this.cmbUbicacion.Location = new System.Drawing.Point(150, 160);
			this.cmbUbicacion.Name = "cmbUbicacion";
			this.cmbUbicacion.Size = new System.Drawing.Size(174, 23);
			this.cmbUbicacion.TabIndex = 21;
			// 
			// cmbEstado
			// 
			this.cmbEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "estado", true));
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Items.AddRange(new object[] {
            "1"});
			this.cmbEstado.Location = new System.Drawing.Point(150, 189);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(174, 23);
			this.cmbEstado.TabIndex = 22;
			// 
			// FrmOpUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 330);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmOpUsuario";
			this.Text = "FrmOpUsuario";
			this.Load += new System.EventHandler(this.FrmOpUsuario_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private cessa_bdsaccDataSet cessa_bdsaccDataSet;
		private System.Windows.Forms.BindingSource usuariosBindingSource;
		private cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
		private cessa_bdsaccDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DateTimePicker dtpCreado;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblCreado;
		private System.Windows.Forms.ComboBox cmbEstado;
		private System.Windows.Forms.ComboBox cmbUbicacion;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.ComboBox cmbCargo;
	}
}