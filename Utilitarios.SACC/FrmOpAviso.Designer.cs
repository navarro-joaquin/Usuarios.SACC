namespace Utilitarios.SACC
{
    partial class FrmOpAviso
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
            System.Windows.Forms.Label textoLabel;
            System.Windows.Forms.Label fecha_inicioLabel;
            System.Windows.Forms.Label fecha_conclusionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.mensajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cessa_bdsaccDataSet = new Utilitarios.SACC.cessa_bdsaccDataSet();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaConclusión = new System.Windows.Forms.DateTimePicker();
            this.mensajesTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.mensajesTableAdapter();
            this.tableAdapterManager = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            textoLabel = new System.Windows.Forms.Label();
            fecha_inicioLabel = new System.Windows.Forms.Label();
            fecha_conclusionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textoLabel
            // 
            textoLabel.AutoSize = true;
            textoLabel.Location = new System.Drawing.Point(16, 25);
            textoLabel.Name = "textoLabel";
            textoLabel.Size = new System.Drawing.Size(49, 16);
            textoLabel.TabIndex = 2;
            textoLabel.Text = "Texto:";
            // 
            // fecha_inicioLabel
            // 
            fecha_inicioLabel.AutoSize = true;
            fecha_inicioLabel.Location = new System.Drawing.Point(16, 167);
            fecha_inicioLabel.Name = "fecha_inicioLabel";
            fecha_inicioLabel.Size = new System.Drawing.Size(108, 16);
            fecha_inicioLabel.TabIndex = 4;
            fecha_inicioLabel.Text = "Fecha de Inicio:";
            // 
            // fecha_conclusionLabel
            // 
            fecha_conclusionLabel.AutoSize = true;
            fecha_conclusionLabel.Location = new System.Drawing.Point(16, 196);
            fecha_conclusionLabel.Name = "fecha_conclusionLabel";
            fecha_conclusionLabel.Size = new System.Drawing.Size(142, 16);
            fecha_conclusionLabel.TabIndex = 6;
            fecha_conclusionLabel.Text = "Fecha de Conclusión:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(textoLabel);
            this.groupBox1.Controls.Add(this.txtTexto);
            this.groupBox1.Controls.Add(fecha_inicioLabel);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(fecha_conclusionLabel);
            this.groupBox1.Controls.Add(this.dtpFechaConclusión);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del aviso";
            // 
            // txtTexto
            // 
            this.txtTexto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mensajesBindingSource, "texto", true));
            this.txtTexto.Location = new System.Drawing.Point(174, 21);
            this.txtTexto.MaxLength = 500;
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(353, 136);
            this.txtTexto.TabIndex = 3;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // mensajesBindingSource
            // 
            this.mensajesBindingSource.DataMember = "mensajes";
            this.mensajesBindingSource.DataSource = this.cessa_bdsaccDataSet;
            // 
            // cessa_bdsaccDataSet
            // 
            this.cessa_bdsaccDataSet.DataSetName = "cessa_bdsaccDataSet";
            this.cessa_bdsaccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mensajesBindingSource, "fecha_inicio", true));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(174, 163);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(228, 23);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // dtpFechaConclusión
            // 
            this.dtpFechaConclusión.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mensajesBindingSource, "fecha_conclusion", true));
            this.dtpFechaConclusión.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaConclusión.Location = new System.Drawing.Point(174, 192);
            this.dtpFechaConclusión.Name = "dtpFechaConclusión";
            this.dtpFechaConclusión.Size = new System.Drawing.Size(228, 23);
            this.dtpFechaConclusión.TabIndex = 7;
            this.dtpFechaConclusión.ValueChanged += new System.EventHandler(this.dtpFechaConclusión_ValueChanged);
            // 
            // mensajesTableAdapter
            // 
            this.mensajesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mensajesTableAdapter = this.mensajesTableAdapter;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 54);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(437, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 54);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "500";
            // 
            // FrmOpAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmOpAviso";
            this.Text = "FrmOpAviso";
            this.Load += new System.EventHandler(this.FrmOpAviso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private cessa_bdsaccDataSet cessa_bdsaccDataSet;
        private System.Windows.Forms.BindingSource mensajesBindingSource;
        private cessa_bdsaccDataSetTableAdapters.mensajesTableAdapter mensajesTableAdapter;
        private cessa_bdsaccDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaConclusión;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}