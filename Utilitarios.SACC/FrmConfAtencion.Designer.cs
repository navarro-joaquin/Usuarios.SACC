namespace Utilitarios.SACC
{
    partial class FrmConfAtencion
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
            this.gbxPlataforma = new System.Windows.Forms.GroupBox();
            this.gbxCajas = new System.Windows.Forms.GroupBox();
            this.btnPlat2n1m = new System.Windows.Forms.Button();
            this.btnPlat2m1n = new System.Windows.Forms.Button();
            this.btnCajas2n1m = new System.Windows.Forms.Button();
            this.btnCajas2m1n = new System.Windows.Forms.Button();
            this.gbxPlataforma.SuspendLayout();
            this.gbxCajas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlataforma
            // 
            this.gbxPlataforma.Controls.Add(this.btnPlat2m1n);
            this.gbxPlataforma.Controls.Add(this.btnPlat2n1m);
            this.gbxPlataforma.Location = new System.Drawing.Point(12, 12);
            this.gbxPlataforma.Name = "gbxPlataforma";
            this.gbxPlataforma.Size = new System.Drawing.Size(330, 121);
            this.gbxPlataforma.TabIndex = 0;
            this.gbxPlataforma.TabStop = false;
            this.gbxPlataforma.Text = "Plataforma";
            // 
            // gbxCajas
            // 
            this.gbxCajas.Controls.Add(this.btnCajas2m1n);
            this.gbxCajas.Controls.Add(this.btnCajas2n1m);
            this.gbxCajas.Location = new System.Drawing.Point(12, 139);
            this.gbxCajas.Name = "gbxCajas";
            this.gbxCajas.Size = new System.Drawing.Size(330, 121);
            this.gbxCajas.TabIndex = 1;
            this.gbxCajas.TabStop = false;
            this.gbxCajas.Text = "Cajas";
            // 
            // btnPlat2n1m
            // 
            this.btnPlat2n1m.Location = new System.Drawing.Point(17, 37);
            this.btnPlat2n1m.Name = "btnPlat2n1m";
            this.btnPlat2n1m.Size = new System.Drawing.Size(133, 57);
            this.btnPlat2n1m.TabIndex = 0;
            this.btnPlat2n1m.Text = "2 Normales y 1 Mayor";
            this.btnPlat2n1m.UseVisualStyleBackColor = true;
            this.btnPlat2n1m.Click += new System.EventHandler(this.btnPlat2n1m_Click);
            // 
            // btnPlat2m1n
            // 
            this.btnPlat2m1n.Location = new System.Drawing.Point(180, 37);
            this.btnPlat2m1n.Name = "btnPlat2m1n";
            this.btnPlat2m1n.Size = new System.Drawing.Size(133, 57);
            this.btnPlat2m1n.TabIndex = 1;
            this.btnPlat2m1n.Text = "2 Mayores y 1 Normal";
            this.btnPlat2m1n.UseVisualStyleBackColor = true;
            this.btnPlat2m1n.Click += new System.EventHandler(this.btnPlat2m1n_Click);
            // 
            // btnCajas2n1m
            // 
            this.btnCajas2n1m.Location = new System.Drawing.Point(17, 38);
            this.btnCajas2n1m.Name = "btnCajas2n1m";
            this.btnCajas2n1m.Size = new System.Drawing.Size(133, 57);
            this.btnCajas2n1m.TabIndex = 2;
            this.btnCajas2n1m.Text = "2 Normales y 1 Mayor";
            this.btnCajas2n1m.UseVisualStyleBackColor = true;
            this.btnCajas2n1m.Click += new System.EventHandler(this.btnCajas2n1m_Click);
            // 
            // btnCajas2m1n
            // 
            this.btnCajas2m1n.Location = new System.Drawing.Point(180, 38);
            this.btnCajas2m1n.Name = "btnCajas2m1n";
            this.btnCajas2m1n.Size = new System.Drawing.Size(133, 57);
            this.btnCajas2m1n.TabIndex = 2;
            this.btnCajas2m1n.Text = "2 Mayores y 1 Normal";
            this.btnCajas2m1n.UseVisualStyleBackColor = true;
            this.btnCajas2m1n.Click += new System.EventHandler(this.btnCajas2m1n_Click);
            // 
            // FrmConfAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 273);
            this.Controls.Add(this.gbxCajas);
            this.Controls.Add(this.gbxPlataforma);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConfAtencion";
            this.Text = "Configuración de Atención";
            this.gbxPlataforma.ResumeLayout(false);
            this.gbxCajas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlataforma;
        private System.Windows.Forms.Button btnPlat2m1n;
        private System.Windows.Forms.Button btnPlat2n1m;
        private System.Windows.Forms.GroupBox gbxCajas;
        private System.Windows.Forms.Button btnCajas2m1n;
        private System.Windows.Forms.Button btnCajas2n1m;
    }
}