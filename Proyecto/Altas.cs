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
            gpb_datosproveedor.BackColor = Color.FromArgb(16, 0, 0, 0);
            gpb_datosempleado.BackColor = Color.FromArgb(16, 0, 0, 0);
        }

        private void chb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_cliente.Checked == true)
                gpb_datoscliente.Enabled = true;
            else
                gpb_datoscliente.Enabled = false;
        }

        private void chb_proveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_proveedor.Checked == true)
                gpb_datosproveedor.Enabled = true;
            else
                gpb_datosproveedor.Enabled = false;
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
            txb_nombres.Clear();
            txb_apellidos.Clear();
            txb_clientecuit.Clear();
            txb_descripcion.Clear();
            txb_direccion.Clear();
            txb_dni.Clear();
            txb_empleadocuil.Clear();
            txb_empleadocuil.Clear();
            txb_proveedorcuit.Clear();
            txb_telefono1.Clear();
            txb_telefono2.Clear();
            txb_telefono3.Clear();
            txb_descripcion1.Clear();
            txb_descripcion2.Clear();
            txb_descripcion3.Clear();
            cmb_clienteiva.SelectedIndex = -1;
            chb_cliente.Checked = false;
            chb_empleado.Checked = false;
            chb_proveedor.Checked = false;
        }
    }
}
