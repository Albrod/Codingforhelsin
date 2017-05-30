using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto
{
    public static class Articulos
    {
        public static void cargar_articulos()
        {
            DataBase.Cargar_Lista_string(datos.lista_articulos, "SELECT * FROM Articulos", "Nombre");
            datos.lista_articulos.Add("AGREGAR NUEVO");
        }
    }
}
