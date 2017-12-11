using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilitarios.SACC
{
    public partial class FrmOpAviso : Form
    {
        int id_usuario;
        int a_modificar;

        public FrmOpAviso(int id)
        {
            InitializeComponent();
            id_usuario = id;
            a_modificar = -1;
        }

        public FrmOpAviso(int id, int aviso)
        {
            InitializeComponent();
            id_usuario = id;
            a_modificar = aviso;
        }

        private void FrmOpAviso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cessa_bdsaccDataSet.mensajes' Puede moverla o quitarla según sea necesario.
            // this.mensajesTableAdapter.Fill(this.cessa_bdsaccDataSet.mensajes);
            if (a_modificar > 0)
            {
                this.btnAgregar.Text = "Modificar";
                this.mensajesTableAdapter.getAvisoById(this.cessa_bdsaccDataSet.mensajes, a_modificar);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (a_modificar < 0)
            {
                if (txtTexto.Text != "")
                {
                    string texto = txtTexto.Text;
                    DateTime fechaInicio = dtpFechaInicio.Value;
                    DateTime fechaConclusion = dtpFechaConclusión.Value;
                    DateTime creado = DateTime.Today;
                    try
                    {
                        this.mensajesTableAdapter.InsertAviso(texto, fechaInicio, fechaConclusion, creado, null, id_usuario, null);
                        MessageBox.Show("El aviso se creó correctamente");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
            }
            else
            {
                if (txtTexto.Text != "")
                {
                    string texto = txtTexto.Text;
                    DateTime fechaInicio = dtpFechaInicio.Value;
                    DateTime fechaConclusion = dtpFechaConclusión.Value;
                    DateTime modificado = DateTime.Today;
                    try
                    {
                        this.mensajesTableAdapter.updateAviso(texto, fechaInicio, fechaConclusion, modificado, id_usuario, a_modificar);
                        MessageBox.Show("Aviso modificado correctamente");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            int limite = 500;
            limite -= txtTexto.Text.Length;
            label1.Text = limite.ToString();
        }

        private void dtpFechaConclusión_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaConclusión.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha de conclusión no puede ser anterior a la fecha de inicio");
                dtpFechaConclusión.Value = dtpFechaInicio.Value;
            }
        }
    }
}
