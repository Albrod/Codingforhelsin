using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Matarife
{
    class DataBase
    {
        //Declara variables y setea la conexion con la base de datos
        static string strConexion = @"Provider=Microsoft.JET.OLEDB.4.0;" +
                "Data Source=database.mdb";
        public OleDbConnection ConexionDB = new OleDbConnection(strConexion);
        public OleDbCommand Orden;
        public OleDbDataReader Lector;


        //Cargar esto en el load de la clase
        //textBox.AutoCompleteCustomSource = database.Autocomplete("select * from Articulos", (Convert.ToString(cmb)));
        //textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        //textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        public AutoCompleteStringCollection Autocomplete(string OleDb, string campo)
        {
            DataTable dt = new DataTable();
            Orden = new OleDbCommand(OleDb, ConexionDB);
            OleDbDataAdapter adap = new OleDbDataAdapter(Orden);
            adap.Fill(dt);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo]));
            }
            return coleccion;
        }

        //Metodo para ejecutar consultas (EJ: insert, update, delete)
        public void Ejecutar(string OleDb)
        {
            try
            {
                ConexionDB.Open();
                Orden = new OleDbCommand(OleDb, ConexionDB);
                Orden.ExecuteNonQuery();
                ConexionDB.Close();
            }
            catch 
            {
                if (ConexionDB.State == ConnectionState.Open)
                    ConexionDB.Close();
                MessageBox.Show("Fallo la conexion con la base de datos");
            }
        }

        //Carga del data grid view (EJ: select * from tabla)
        public void CargaDGV(DataGridView dgv, string OleDb)
        {
            try
            {
                ConexionDB.Open();
                Orden = new OleDbCommand(OleDb, ConexionDB);
                Lector = Orden.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(Lector);
                dgv.DataSource = dt;
                ConexionDB.Close();
            }
            catch
            {
                if (ConexionDB.State == ConnectionState.Open)
                ConexionDB.Close();
                MessageBox.Show("Fallo la conexion con la base de datos");
            }
        }
        //Carga del combo box (EJ: select * from tabla, campo)
        public void CargarCB(ComboBox cb, string OleDb, string campo)
        {
            try
            {
                ConexionDB.Open();
                Orden = new OleDbCommand(OleDb, ConexionDB);
                Lector = Orden.ExecuteReader();
                while (Lector.Read())
                {
                    cb.Items.Add(Lector[campo].ToString());
                }
                Lector.Close();
                ConexionDB.Close();
            }
            catch
            {
                if (ConexionDB.State == ConnectionState.Open)
                {
                    Lector.Close();
                    ConexionDB.Close();
                }
                MessageBox.Show("Fallo la conexion con la base de datos");
            }
        }
        //Carga del list box (EJ: select * from tabla, campo)
        public void CargarLB(ListBox lb, string OleDb, string campo)
        {
            try
            {
                ConexionDB.Open();
                Orden = new OleDbCommand(OleDb, ConexionDB);
                Lector = Orden.ExecuteReader();
                while (Lector.Read())
                {
                    lb.Items.Add(Lector[campo].ToString());
                }
                Lector.Close();
                ConexionDB.Close();
            }
            catch
            {
                if (ConexionDB.State == ConnectionState.Open)
                {
                    Lector.Close();
                    ConexionDB.Close();
                }
                MessageBox.Show("Fallo la conexion con la base de datos");
            }

        }
        //Devuelve un valor unico de una consulta (EJ: select * from tabla where x=z,campo)
        public string LeerDato(string campo, string OleDb)
        {
            string dato;
            try
            {
                ConexionDB.Open();
                Orden = new OleDbCommand(OleDb, ConexionDB);
                Lector = Orden.ExecuteReader();
                Lector.Read();
                dato = Lector[campo].ToString();
                Lector.Close();
                ConexionDB.Close();
                return (dato);
            }
            catch
            {
                if (ConexionDB.State == ConnectionState.Open)
                {
                    Lector.Close();
                    ConexionDB.Close();
                }
                return ("-1");
            }

        }
    }

}
