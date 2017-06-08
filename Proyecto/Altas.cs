using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Altas : Form
    {
        public Altas()
        {
            InitializeComponent();
        }

        private void Altas_Load(object sender, EventArgs e)
        {
            gpb_clase.BackColor = Color.FromArgb(16, 0, 0, 0);
            gpb_datosgenerales.BackColor = Color.FromArgb(16, 0, 0, 0);
            gpb_datoscliente.BackColor = Color.FromArgb(16, 0, 0, 0);
            gpb_datosempleado.BackColor = Color.FromArgb(16, 0, 0, 0);
            gpb_proveedores.BackColor = Color.FromArgb(16, 0, 0, 0);
        }

        private void chb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_cliente.Checked == true)
                gpb_datoscliente.Enabled = true;
            else
                gpb_datoscliente.Enabled = false;
        }

        private void chb_empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_empleado.Checked == true)
                gpb_datosempleado.Enabled = true;
            else
                gpb_datosempleado.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_borrarcampos_Click(object sender, EventArgs e)
        {
            txb_personanombres.Clear();
            txb_personaapellidos.Clear();
            txb_clientecuit.Clear();
            txb_personadescripcion.Clear();
            txb_personadireccion.Clear();
            txb_personadni.Clear();
            txb_empleadocuil.Clear();
            txb_empleadocuil.Clear();
            txb_personatelefono1.Clear();
            txb_personatelefono2.Clear();
            txb_personatelefono3.Clear();
            txb_personadescripcion1.Clear();
            txb_personadescripcion2.Clear();
            txb_personadescripcion3.Clear();
            cmb_clienteiva.SelectedIndex = -1;
            chb_cliente.Checked = false;
            chb_empleado.Checked = false;
        }

        private void rdb_proveedornuevo_CheckedChanged(object sender, EventArgs e)
        {
            gpb_proveedorpersona.Enabled = true;
            gpb_proveedordatos.Enabled = true;
            cmb_proveedordni.Enabled = false;
        }

        private void rdb_proveedorexistente_CheckedChanged(object sender, EventArgs e)
        {
            gpb_proveedorpersona.Enabled = false;
            cmb_proveedordni.Enabled = true;
            gpb_proveedordatos.Enabled = true;
        }

        private void Altas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void btn_daralta_Click(object sender, EventArgs e)
        {
            if ((txb_personanombres.TextLength > 2) && (txb_personaapellidos.TextLength > 2) && (txb_personadni.TextLength > 6))
                Personas.ingresarpersonas(txb_personanombres.Text, txb_personaapellidos.Text, txb_personadni.Text, txb_personadireccion.Text, txb_personadescripcion.Text);
            //, Convert.ToInt32(txb_personatelefono1.Text), Convert.ToInt32(txb_personatelefono2.Text), Convert.ToInt32(txb_personatelefono3.Text), txb_proveedordescripcion1.Text, txb_proveedordescripcion2.Text, txb_proveedordescripcion3.Text)

        }
    }
}
