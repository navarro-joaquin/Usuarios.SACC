﻿namespace Utilitarios.SACC
{
    partial class FrmPrincipalMDI
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemAvisos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVideos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemLogAccesos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemReportesAtendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemConfCorreo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuItemCerrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuArchivo,
            this.MnuOperaciones,
            this.MnuReportes,
            this.MnuHerramientas,
            this.MnuVer,
            this.MnuVentanas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.MnuVentanas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(819, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuArchivo
            // 
            this.MnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemSalir});
            this.MnuArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MnuArchivo.Name = "MnuArchivo";
            this.MnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.MnuArchivo.Text = "&Archivo";
            // 
            // MnuItemSalir
            // 
            this.MnuItemSalir.Name = "MnuItemSalir";
            this.MnuItemSalir.Size = new System.Drawing.Size(96, 22);
            this.MnuItemSalir.Text = "&Salir";
            this.MnuItemSalir.Click += new System.EventHandler(this.EMnuItemSalir_Click);
            // 
            // MnuOperaciones
            // 
            this.MnuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemUsuarios,
            this.MnuItemAvisos,
            this.MnuItemVideos,
            this.MnuItemLogAccesos});
            this.MnuOperaciones.Name = "MnuOperaciones";
            this.MnuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.MnuOperaciones.Text = "&Operaciones";
            // 
            // MnuItemUsuarios
            // 
            this.MnuItemUsuarios.Name = "MnuItemUsuarios";
            this.MnuItemUsuarios.Size = new System.Drawing.Size(220, 22);
            this.MnuItemUsuarios.Text = "Mantenimiento de &Usuarios";
            this.MnuItemUsuarios.Click += new System.EventHandler(this.MnuItemUsuarios_Click);
            // 
            // MnuItemAvisos
            // 
            this.MnuItemAvisos.Name = "MnuItemAvisos";
            this.MnuItemAvisos.Size = new System.Drawing.Size(220, 22);
            this.MnuItemAvisos.Text = "Mantenimiento de &Avisos";
            this.MnuItemAvisos.Click += new System.EventHandler(this.MnuItemAvisos_Click);
            // 
            // MnuItemVideos
            // 
            this.MnuItemVideos.Name = "MnuItemVideos";
            this.MnuItemVideos.Size = new System.Drawing.Size(220, 22);
            this.MnuItemVideos.Text = "Mantenimiento de &Videos";
            this.MnuItemVideos.Click += new System.EventHandler(this.MnuItemVideos_Click);
            // 
            // MnuItemLogAccesos
            // 
            this.MnuItemLogAccesos.Name = "MnuItemLogAccesos";
            this.MnuItemLogAccesos.Size = new System.Drawing.Size(220, 22);
            this.MnuItemLogAccesos.Text = "&Log de Accesos";
            this.MnuItemLogAccesos.Click += new System.EventHandler(this.MnuItemLogAccesos_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemReportesAtendidos});
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(65, 20);
            this.MnuReportes.Text = "&Reportes";
            // 
            // MnuItemReportesAtendidos
            // 
            this.MnuItemReportesAtendidos.Name = "MnuItemReportesAtendidos";
            this.MnuItemReportesAtendidos.Size = new System.Drawing.Size(168, 22);
            this.MnuItemReportesAtendidos.Text = "&Tickets Atendidos";
            this.MnuItemReportesAtendidos.Click += new System.EventHandler(this.MnuItemReportesAtendidos_Click);
            // 
            // MnuHerramientas
            // 
            this.MnuHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemConfCorreo});
            this.MnuHerramientas.Name = "MnuHerramientas";
            this.MnuHerramientas.Size = new System.Drawing.Size(90, 20);
            this.MnuHerramientas.Text = "Herramientas";
            // 
            // MnuItemConfCorreo
            // 
            this.MnuItemConfCorreo.Name = "MnuItemConfCorreo";
            this.MnuItemConfCorreo.Size = new System.Drawing.Size(142, 22);
            this.MnuItemConfCorreo.Text = "Conf. Correo";
            this.MnuItemConfCorreo.Click += new System.EventHandler(this.MnuItemConfCorreo_Click);
            // 
            // MnuVer
            // 
            this.MnuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemHerramientas,
            this.MnuItemEstado});
            this.MnuVer.Name = "MnuVer";
            this.MnuVer.Size = new System.Drawing.Size(35, 20);
            this.MnuVer.Text = "&Ver";
            // 
            // MnuItemHerramientas
            // 
            this.MnuItemHerramientas.Checked = true;
            this.MnuItemHerramientas.CheckOnClick = true;
            this.MnuItemHerramientas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuItemHerramientas.Name = "MnuItemHerramientas";
            this.MnuItemHerramientas.Size = new System.Drawing.Size(189, 22);
            this.MnuItemHerramientas.Text = "&Barra de herramientas";
            this.MnuItemHerramientas.Click += new System.EventHandler(this.MnuItemHerramientas_Click);
            // 
            // MnuItemEstado
            // 
            this.MnuItemEstado.Checked = true;
            this.MnuItemEstado.CheckOnClick = true;
            this.MnuItemEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuItemEstado.Name = "MnuItemEstado";
            this.MnuItemEstado.Size = new System.Drawing.Size(189, 22);
            this.MnuItemEstado.Text = "&Barra de estado";
            this.MnuItemEstado.Click += new System.EventHandler(this.MnuItemEstado_Click);
            // 
            // MnuVentanas
            // 
            this.MnuVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCascada,
            this.MnuItemVertical,
            this.MnuItemHorizontal,
            this.toolStripSeparator1,
            this.MnuItemCerrarTodo});
            this.MnuVentanas.Name = "MnuVentanas";
            this.MnuVentanas.Size = new System.Drawing.Size(66, 20);
            this.MnuVentanas.Text = "&Ventanas";
            // 
            // MnuItemCascada
            // 
            this.MnuItemCascada.Name = "MnuItemCascada";
            this.MnuItemCascada.Size = new System.Drawing.Size(175, 22);
            this.MnuItemCascada.Text = "&Cascada";
            this.MnuItemCascada.Click += new System.EventHandler(this.MnuItemCascada_Click);
            // 
            // MnuItemVertical
            // 
            this.MnuItemVertical.Name = "MnuItemVertical";
            this.MnuItemVertical.Size = new System.Drawing.Size(175, 22);
            this.MnuItemVertical.Text = "Mosaico &vertical";
            this.MnuItemVertical.Click += new System.EventHandler(this.MnuItemVertical_Click);
            // 
            // MnuItemHorizontal
            // 
            this.MnuItemHorizontal.Name = "MnuItemHorizontal";
            this.MnuItemHorizontal.Size = new System.Drawing.Size(175, 22);
            this.MnuItemHorizontal.Text = "Mosaico &horizontal";
            this.MnuItemHorizontal.Click += new System.EventHandler(this.MnuItemHorizontal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // MnuItemCerrarTodo
            // 
            this.MnuItemCerrarTodo.Name = "MnuItemCerrarTodo";
            this.MnuItemCerrarTodo.Size = new System.Drawing.Size(175, 22);
            this.MnuItemCerrarTodo.Text = "C&errar todo";
            this.MnuItemCerrarTodo.Click += new System.EventHandler(this.MnuItemCerrarTodo_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(819, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 575);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(819, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // FrmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 597);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipalMDI";
            this.Text = "FrmPrincipalMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MnuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem MnuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuVer;
        private System.Windows.Forms.ToolStripMenuItem MnuItemHerramientas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemEstado;
        private System.Windows.Forms.ToolStripMenuItem MnuVentanas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCascada;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVertical;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCerrarTodo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem MnuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MnuItemAvisos;
        private System.Windows.Forms.ToolStripMenuItem MnuItemVideos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuItemReportesAtendidos;
        private System.Windows.Forms.ToolStripMenuItem MnuHerramientas;
        private System.Windows.Forms.ToolStripMenuItem MnuItemConfCorreo;
        private System.Windows.Forms.ToolStripMenuItem MnuItemLogAccesos;
    }
}



