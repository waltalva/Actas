using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDNacimientos
    {
        private CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            //transact sql
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from NACIDOS";
            leer=comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //metodo para insersión de registros
        public void InsertarNac(int libro, int folio, string nombre, string appaterno, string apmaterno, string fecha, string acta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into NACIDOS values(" +libro+ ","+folio+",'"+nombre+"','"+appaterno+"','"+apmaterno+"','"+fecha+"','"+acta+"')";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        //editar un registro
        public void EditarNac(int libro, int folio, string nombre, string appaterno, string apmaterno, string fecha, string acta, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarnac";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@libro", libro);
            comando.Parameters.AddWithValue("@folio", folio);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@appaterno", appaterno);
            comando.Parameters.AddWithValue("@apmaterno", apmaterno);
            comando.Parameters.AddWithValue("@fnac", fecha);
            comando.Parameters.AddWithValue("@acta", acta);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
