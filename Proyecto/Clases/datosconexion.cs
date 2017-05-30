using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Proyecto
{
    public static class datosconexion
    {
        public static string server_name = "";
        public static List<string> lista_conexiones = new List<string>();        
        public static void crear_leer_config_bd()
        {
            if (File.Exists("cfg.ini"))
            {
                string aux = "";
                StreamReader sr = new StreamReader("cfg.ini");
                while (!(sr.EndOfStream))
                {
                    aux = sr.ReadLine();
                    if (aux.Contains("server_name="))
                    {
                        server_name = aux.Substring(aux.IndexOf("=")+1);
                        break;
                    }
                }
                sr.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("cfg.ini", true);
                sw.WriteLine("server_name=" + lista_conexiones[0].ToString());
                sw.Close();
                server_name =lista_conexiones[0].ToString();
            }
        }
    }
}
