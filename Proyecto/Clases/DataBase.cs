using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto
{
    public static class DataBase
    {
        //Declara variables y setea la conexion con la base de datos
        static string strConexion = "Data Source=PAIN\\GDBD;" + "Initial Catalog=Comercio;" +
            "User id=usuario;" + "Password=malo;";
        static SqlConnection ConexionDB = new SqlConnection(strConexion);
        static SqlCommand Orden;
        static SqlDataReader Lector;


        //Cargar esto en el load de la clase
        //textBox.AutoCompleteCustomSource = database.Autocomplete("select * from Articulos", (Convert.ToString(cmb)));
        //textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        //textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        public static AutoCompleteStringCollection Autocomplete(string OleDb, string campo)
        {
            DataTable dt = new DataTable();
            Orden = new SqlCommand(OleDb, ConexionDB);
            SqlDataAdapter adap = new SqlDataAdapter(Orden);
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
        public static void Ejecutar(string OleDb)
        {
            try
            {
                ConexionDB.Open();
                Orden = new SqlCommand(OleDb, ConexionDB);
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
        public static void CargaDGV(DataGridView dgv, string OleDb)
        {
            try
            {
                ConexionDB.Open();
                Orden = new SqlCommand(OleDb, ConexionDB);
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
        public static void CargarCB(ComboBox cb, string OleDb, string campo)
        {
            try
            {
                ConexionDB.Open();
                Orden = new SqlCommand(OleDb, ConexionDB);
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
        public static void CargarLB(ListBox lb, string OleDb, string campo)
        {
            try
            {
                ConexionDB.Open();
                Orden = new SqlCommand(OleDb, ConexionDB);
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
        public static void Cargar_Lista_string(List<String> l, string consulta, string campo)
        {
            try
            {
                ConexionDB.Open();
                Orden = new SqlCommand(consulta, ConexionDB);
                Lector = Orden.ExecuteReader();
                while (Lector.Read())
                {
                    l.Add(Lector[campo].ToString());
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
        public static string LeerDato(string campo, string OleDb)
        {
            string dato;
            try
            {
                ConexionDB.Open();
                Orden = new SqlCommand(OleDb, ConexionDB);
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
