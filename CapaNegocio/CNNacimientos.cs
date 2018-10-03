using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNNacimientos
    {
        private CDNacimientos objetoCD = new CDNacimientos();

        public DataTable MostrarNac()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar();
            return tabla;
        }

        public void InsertarNacimiento(int libro, int folio, string nombre, string appaterno, string apmaterno, string fecha, string acta)
        {
            objetoCD.InsertarNac(Convert.ToInt32(libro), Convert.ToInt32(folio), nombre, appaterno, apmaterno, fecha, acta);

        }

        public void editarNac(int libro, int folio, string nombre, string appaterno, string apmaterno, string fecha, string acta, int id)
        {
            objetoCD.EditarNac(Convert.ToInt32(libro), Convert.ToInt32(folio), nombre, appaterno, apmaterno, fecha, acta, Convert.ToInt32(id));
        }

        
    }
}
