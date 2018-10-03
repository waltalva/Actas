using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace Actas
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            CNEmpleado objempleado = new CNEmpleado();
            SqlDataReader loguear;
            objempleado.Usuario = txtuser.Text;
            objempleado.Contrasena = txtcontrasena.Text;

            if (objempleado.Usuario == txtuser.Text)
            {
                if (objempleado.Contrasena == txtcontrasena.Text)
                {
                    loguear = objempleado.IniciarSesion();
                    if (loguear.Read() == true)
                    {
                        this.Hide();
                        MDIPrincipal objFP = new MDIPrincipal();
                        objFP.Show();
                    }
                    else
                    {
                        MessageBox.Show("usuario contraseña invalido");
                        txtuser.Text = "";
                        txtcontrasena.Text = "";
                        txtuser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(objempleado.Contrasena);
                    txtuser.Text = "";
                    txtcontrasena.Text = "";
                    txtuser.Focus();
                }
                    
                
            }
            else
            {
                MessageBox.Show(objempleado.Usuario);
                txtuser.Focus();
            }
                
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
    
}
