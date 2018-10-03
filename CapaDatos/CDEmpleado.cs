using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDEmpleado
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader IniciarSesion(string user,string pass)
            {
            //string sql = "select * from Usuarios where account='"+user+"' and password='"+pass+"'";
            SqlCommand comando = new SqlCommand("sp_login",Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario",user);
            comando.Parameters.AddWithValue("@pass", pass);
            leer = comando.ExecuteReader();
            return leer;
            }
    }
}
