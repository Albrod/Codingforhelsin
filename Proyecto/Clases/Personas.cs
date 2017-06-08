using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto
{
    public static class Personas
    {
        public static void ingresarpersonas(string nombres, string apellidos, string dni, string direccion, string descripcion)
        //, int telefono1, int telefono2, int telefono3, string descripcion1, string descripcion2, string descripcion3
        {
            string cmdsql = "Insert into Personas ('nombre','apellido','dni','direccion','descripcion') VALUES (nombre='" + nombres + "',apellido='" + apellidos + "',dni='" + dni + "',direccion='" + direccion + "',descripcion='" + descripcion + "');";
            DataBase.Ejecutar(cmdsql);
            int idpersona=Convert.ToInt32(DataBase.LeerDato("idpersona","Select idpersona from Personas where nombre='"+nombres+"');"));
            //string cmdsql = "Insert into Telefonos ('
        }
    }
}
