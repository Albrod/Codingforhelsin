using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public class instancias_form
    {
        Stock stock = null;
        Altas altas = null;
        Proveedores proveedores = null;
        Registros registros = null;
        Clientes clientes = null;
        Usuarios usuarios = null;
        BajasModif bajasmodif = null;

        public void stock_crear_mostrar()
        {
            if (stock == null)
            {
                stock = new Stock();
                stock.FormClosed += (o, ea) => stock = null;
            }
            else
            {
                stock.WindowState = FormWindowState.Normal;
                stock.Focus();
            }
            stock.Tag = this;
            stock.Show();
        }

        public void altas_crear_mostrar()
        {
            if (altas == null)
            {
                altas = new Altas();
                altas.FormClosed += (o, ea) => altas = null;
            }
            else
            {
                altas.WindowState = FormWindowState.Normal;
                altas.Focus();
            }
            altas.Tag = this;
            altas.Show();
        }

        public void proveedores_crear_mostrar()
        {
            if (proveedores == null)
            {
                proveedores = new Proveedores();
                proveedores.FormClosed += (o, ea) => proveedores = null;
            }
            else
            {
                proveedores.WindowState = FormWindowState.Normal;
                proveedores.Focus();
            }
            proveedores.Tag = this;
            proveedores.Show();
        }

        public void registros_crear_mostrar()
        {
            if (registros == null)
            {
                registros = new Registros();
                registros.FormClosed += (o, ea) => registros = null;
            }
            else
            {
                registros.WindowState = FormWindowState.Normal;
                registros.Focus();
            }
            registros.Tag = this;
            registros.Show();
        }

        public void clientes_crear_mostrar()
        {
            if (clientes == null)
            {
                clientes = new Clientes();
                clientes.FormClosed += (o, ea) => clientes = null;
            }
            else
            {
                clientes.WindowState = FormWindowState.Normal;
                clientes.Focus();
            }
            clientes.Tag = this;
            clientes.Show();
        }

        public void usuarios_crear_mostrar()
        {
            if (usuarios == null)
            {
                usuarios = new Usuarios();
                usuarios.FormClosed += (o, ea) => usuarios = null;
            }
            else
            {
                usuarios.WindowState = FormWindowState.Normal;
                usuarios.Focus();
            }
            usuarios.Tag = this;
            usuarios.Show();
        }

        public void bajasmodif_crear_mostrar()
        {
            if (bajasmodif == null)
            {
                bajasmodif = new BajasModif();
                bajasmodif.FormClosed += (o, ea) => bajasmodif = null;
            }
            else
            {
                bajasmodif.WindowState = FormWindowState.Normal;
                bajasmodif.Focus();
            }
            bajasmodif.Tag = this;
            bajasmodif.Show();
        }
    }
}
