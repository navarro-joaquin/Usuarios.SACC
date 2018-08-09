namespace Utilitarios.SACC
{
    partial class FrmListadoVideos
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
            this.gbxVideos = new System.Windows.Forms.GroupBox();
            this.videosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cessa_bdsaccDataSet = new Utilitarios.SACC.cessa_bdsaccDataSet();
            this.videosTableAdapter = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.videosTableAdapter();
            this.tableAdapterManager = new Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager();
            this.gbxVideos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxVideos
            // 
            this.gbxVideos.Controls.Add(this.videosDataGridView);
            this.gbxVideos.Location = new System.Drawing.Point(12, 12);
            this.gbxVideos.Name = "gbxVideos";
            this.gbxVideos.Size = new System.Drawing.Size(909, 444);
            this.gbxVideos.TabIndex = 0;
            this.gbxVideos.TabStop = false;
            this.gbxVideos.Text = "Listado de videos en reproducción";
            // 
            // videosDataGridView
            // 
            this.videosDataGridView.AllowUserToAddRows = false;
            this.videosDataGridView.AllowUserToDeleteRows = false;
            this.videosDataGridView.AutoGenerateColumns = false;
            this.videosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.videosDataGridView.DataSource = this.videosBindingSource;
            this.videosDataGridView.Location = new System.Drawing.Point(6, 22);
            this.videosDataGridView.Name = "videosDataGridView";
            this.videosDataGridView.ReadOnly = true;
            this.videosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.videosDataGridView.Size = new System.Drawing.Size(897, 416);
            this.videosDataGridView.TabIndex = 0;
            this.videosDataGridView.DoubleClick += new System.EventHandler(this.videosDataGridView_DoubleClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ruta_archivo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ruta Archivo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_archivo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Archivo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 450;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad_reproducciones";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad Reproducciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "videos";
            this.videosBindingSource.DataSource = this.cessa_bdsaccDataSet;
            // 
            // cessa_bdsaccDataSet
            // 
            this.cessa_bdsaccDataSet.DataSetName = "cessa_bdsaccDataSet";
            this.cessa_bdsaccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mensajesTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.tiposTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Utilitarios.SACC.cessa_bdsaccDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarios_logTableAdapter = null;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.videosTableAdapter = this.videosTableAdapter;
            // 
            // FrmListadoVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 468);
            this.Controls.Add(this.gbxVideos);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListadoVideos";
            this.Text = "FrmListadoVideos";
            this.Load += new System.EventHandler(this.FrmListadoVideos_Load);
            this.gbxVideos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cessa_bdsaccDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVideos;
        private cessa_bdsaccDataSet cessa_bdsaccDataSet;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private cessa_bdsaccDataSetTableAdapters.videosTableAdapter videosTableAdapter;
        private cessa_bdsaccDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView videosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}