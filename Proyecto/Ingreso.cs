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
    public partial class Ingreso : Form
    {
        
        static void Main()
        {
            Application.Run(new Ingreso());
            
        }

        public Ingreso()
        {
            InitializeComponent();
            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Tag = this;
            principal.Show();
            Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
