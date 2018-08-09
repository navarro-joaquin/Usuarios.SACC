namespace Utilitarios.SACC
{
    partial class FrmLogUsuarios
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
            this.cessa_bdsaccDataSet = new Utilitarios.SACC.cessa_bdsaccDataSet();
            this.usuarios_logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios_logTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.usuarios_logTableAdapter();
            this.tableAdapterManager = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager();
            this.usuariosTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter();
            this.usuarios_logDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_logDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cessa_bdsaccDataSet
            // 
            this.cessa_bdsaccDataSet.DataSetName = "cessa_bdsaccDataSet";
            this.cessa_bdsaccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarios_logBindingSource
            // 
            this.usuarios_logBindingSource.DataMember = "usuarios_log";
            this.usuarios_logBindingSource.DataSource = this.cessa_bdsaccDataSet;
            // 
            // usuarios_logTableAdapter
            // 
            this.usuarios_logTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mensajesTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarios_logTableAdapter = this.usuarios_logTableAdapter;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuarios_logDataGridView
            // 
            this.usuarios_logDataGridView.AllowUserToAddRows = false;
            this.usuarios_logDataGridView.AllowUserToDeleteRows = false;
            this.usuarios_logDataGridView.AutoGenerateColumns = false;
            this.usuarios_logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_logDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.usuarios_logDataGridView.DataSource = this.usuarios_logBindingSource;
            this.usuarios_logDataGridView.Location = new System.Drawing.Point(14, 64);
            this.usuarios_logDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usuarios_logDataGridView.Name = "usuarios_logDataGridView";
            this.usuarios_logDataGridView.ReadOnly = true;
            this.usuarios_logDataGridView.Size = new System.Drawing.Size(705, 391);
            this.usuarios_logDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha_ingreso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha/Hora Ingreso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_salida";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha/Hora Salida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "duracion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duración de la Sesión";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DataSource = this.usuariosBindingSource;
            this.cmbBuscar.DisplayMember = "nombre";
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(132, 22);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(191, 26);
            this.cmbBuscar.TabIndex = 2;
            this.cmbBuscar.ValueMember = "login";
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.cessa_bdsaccDataSet;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(580, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(139, 45);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar todos los valores";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(54, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 18);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // FrmLogUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 467);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.usuarios_logDataGridView);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogUsuarios";
            this.Text = "FrmLogUsuarios";
            this.Load += new System.EventHandler(this.FrmLogUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_logDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cessa_bdsaccDataSet cessa_bdsaccDataSet;
        private System.Windows.Forms.BindingSource usuarios_logBindingSource;
        private cessa_bdsaccDataSetTableAdapters.usuarios_logTableAdapter usuarios_logTableAdapter;
        private cessa_bdsaccDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usuarios_logDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private cessa_bdsaccDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblUsuario;
    }
}