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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Tag = this;
            stock.Show();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Tag = this;
            proveedores.Show();
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.Tag = this;
            registros.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Tag = this;
            clientes.Show();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Tag = this;
            usuarios.Show();
        }

        private void btn_altas_Click(object sender, EventArgs e)
        {
            Altas altas = new Altas();
            altas.Tag = this;
            altas.Show();
        }

        private void btn_bajasmodif_Click(object sender, EventArgs e)
        {
            BajasModif bajasmodif = new BajasModif();
            bajasmodif.Tag = this;
            bajasmodif.Show();
        }

    }
}
