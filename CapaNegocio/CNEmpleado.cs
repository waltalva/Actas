using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        //encapsular variables
        private CDEmpleado objDato = new CDEmpleado();//insancia a la capa de datos empleado
        //declarar todos los atributos del empleado
        private string _Usuario;
        private string _Contrasena;

        public string Usuario
        {
            set {
                if (value == "") { _Usuario = "Ingrese un valor en el campo usuario"; }
                else{_Usuario=value;}
            }
            get { return _Usuario; }
        }

        public string Contrasena
        {
            set
            {
                if (value == "") { _Contrasena = "Ingrese su contraseña"; }
                else { _Contrasena = value; }
            }
            get { return _Contrasena;}
        }
        //constructor
        public CNEmpleado() { }
        //funciones o metodos
        public SqlDataReader IniciarSesion() {
            SqlDataReader loguear;
            loguear=objDato.IniciarSesion(Usuario,Contrasena);
            return loguear;
        
            }
    }
}
