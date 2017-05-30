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
        instancias_form instancias = new instancias_form();

        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            Articulos.cargar_articulos();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            instancias.stock_crear_mostrar();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            instancias.proveedores_crear_mostrar();
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            instancias.registros_crear_mostrar();  
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            instancias.clientes_crear_mostrar();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            instancias.usuarios_crear_mostrar();
        }

        private void btn_altas_Click(object sender, EventArgs e)
        {
            instancias.altas_crear_mostrar();            
        }

        private void btn_bajasmodif_Click(object sender, EventArgs e)
        {
            instancias.bajasmodif_crear_mostrar();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cb_compras_art_Enter(object sender, EventArgs e)
        {
            cb_compras_art.DataSource = datos.lista_articulos;
        }

    }
}
