using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Utilitarios.SACC
{
    public partial class FrmListadoVideos : Form
    {
        public FrmListadoVideos()
        {
            InitializeComponent();
        }

        public void ActualizarListado()
        {
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.videos' Puede moverla o quitarla según sea necesario.
            this.videosTableAdapter.Fill(this.cessa_bdsaccDataSet.videos);
        }

        private void FrmListadoVideos_Load(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private void videosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string cantidad = Interaction.InputBox("Introduzca la cantidad de reproducciones", "Número de reproducciones");
            if (cantidad != "" && Regex.IsMatch(cantidad, @"^[0-9]+$"))
            {
                int id = Convert.ToInt32(videosDataGridView.CurrentRow.Cells[0].Value.ToString());
                int cantidad_reproducciones = Convert.ToInt32(cantidad);
                if (cantidad_reproducciones <= 15)
                {
                    this.videosTableAdapter.ActualizarCantidad(cantidad_reproducciones, id);
                    ActualizarListado();
                }
                else
                {
                    MessageBox.Show("El máximo permitido son 15 reproducciones por video");
                }
            }
            else
            {
                MessageBox.Show("Se ingresaron caracteres no permitidos");
            }
        }
    }
}
