using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaNegocio;
using System.Data;
using System.Data.SqlClient;



namespace CapaPruebas
{
    [TestClass]
    public class CPLogin
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        
        [DataSource("System.Data.OleDB",
            @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=J:\Proyectos\EmisionActas\Actas\Actas.xlsx;  
            Extended Properties='Excel 12.0;HDR=yes';",
            "Login$",
            DataAccessMethod.Sequential)]

        public void LoginPrueba()
        {
            CNEmpleado _cnempleado=new CNEmpleado();
            //leer datos de la hoja
            string usuario = Convert.ToString(TestContext.DataRow["user"]);
            string clave = Convert.ToString(TestContext.DataRow["pass"]);
            string usuarioesp = Convert.ToString(TestContext.DataRow["useresp"]);
            string claveesp = Convert.ToString(TestContext.DataRow["passesp"]);

            _cnempleado.Usuario = usuario;
            _cnempleado.Contrasena = clave;
            _cnempleado.IniciarSesion();
            string usuactual = _cnempleado.Usuario;
            string passactual = _cnempleado.Contrasena;

            //evaluar
            Assert.AreEqual(usuarioesp, usuactual, "", _cnempleado.ToString());
            Assert.AreEqual(claveesp, passactual, "", _cnempleado.ToString());

            
        }
    }
}
