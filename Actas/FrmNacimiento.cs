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
using System.Drawing.Printing;
using Microsoft.VisualBasic.Devices;

namespace Actas
{
    public partial class FrmNacimiento : Form
    {
        CNNacimientos objetoCN = new CNNacimientos();
        //variable para indetificar si se editara el archivo o se insertara uno nuevo
        private string idAcNac=null;
        private bool editar = false;
        string ruta = "";

        public FrmNacimiento()
        {
            InitializeComponent();
        }

        
        private void FrmNacimiento_Load(object sender, EventArgs e)
        {

            gruponac1.Enabled = false;
            MostrarNacimientos();
        }

        private void MostrarNacimientos()
        {
            CNNacimientos objetoCN2 = new CNNacimientos();
            dgnacimientos.DataSource = objetoCN2.MostrarNac();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (editar == false && gruponac1.Enabled==true)
            {
                try
                {
                    //objetoCN.InsertarNacimiento(txtlibro.Text,txtfolio.Text,txtnombre.Text,txtappaterno.Text,txtapmaterno.Text,dtpfecha.Text,txtruta.Text);
                    objetoCN.InsertarNacimiento(Convert.ToInt32(txtlibro.Text), Convert.ToInt32(txtfolio.Text), txtnombre.Text, txtappaterno.Text, txtapmaterno.Text, dtpfecha.Text, ruta);
                    
                    MessageBox.Show("Se Inserto Registro Correctamente");
                    MostrarNacimientos();
                    dgnacimientos.Enabled = true;
                    gruponac1.Enabled = false;
                    btnnuevo.Enabled = true;
                    btneliminar.Text = "Eliminar";
                    btnsalir.Enabled = true;
                    btnImpacta.Enabled = true;
                    gruponac1.Enabled = false;
                    dgnacimientos.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Ingresar los datos por: " + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    objetoCN.editarNac(Convert.ToInt32(txtlibro.Text), Convert.ToInt32(txtfolio.Text), txtnombre.Text, txtappaterno.Text, txtapmaterno.Text, dtpfecha.Text, ruta,Convert.ToInt32(idAcNac));
                    MessageBox.Show("Se Edito Registro Correctamente");
                    MostrarNacimientos();
                    dgnacimientos.Enabled = true;
                    gruponac1.Enabled = false;
                    btnnuevo.Enabled = true;
                    btneliminar.Text = "Eliminar";
                    btnsalir.Enabled = true;
                    btnImpacta.Enabled = true;
                    gruponac1.Enabled = false;
                    dgnacimientos.Enabled = true;
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Editar los datos por: " + ex);
                }
            }
            
            


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (btneliminar.Text == "Eliminar")
            {
                try
                {
                    MessageBox.Show("El Registro se ha Eliminado");
                }
                catch
                {

                }
            }

            if (btneliminar.Text == "Cancelar")
            {
                try
                {
                    btnnuevo.Enabled = true;
                    btneliminar.Text = "Eliminar";
                    btnsalir.Enabled = true;
                    btnImpacta.Enabled = true;
                    gruponac1.Enabled = false;
                    dgnacimientos.Enabled = true;
                }
                catch
                {

                }
            }


        }
        
        private void dgnacimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cargarcajas();
                        
        }

        

        private void cargarcajas()
        {
            if (dgnacimientos.SelectedRows.Count > 0)
            {
                txtlibro.Text = dgnacimientos.CurrentRow.Cells["LIBRO"].Value.ToString();
                txtfolio.Text = dgnacimientos.CurrentRow.Cells["FOLIO"].Value.ToString();
                txtnombre.Text = dgnacimientos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txtappaterno.Text = dgnacimientos.CurrentRow.Cells["APELLIDO_PAT"].Value.ToString();
                txtapmaterno.Text = dgnacimientos.CurrentRow.Cells["APELLIDO_MAT"].Value.ToString();
                dtpfecha.Text = dgnacimientos.CurrentRow.Cells["FECHA_NACI"].Value.ToString();
                txtruta.Text = dgnacimientos.CurrentRow.Cells["ACTA"].Value.ToString();
                pdfnac.src = dgnacimientos.CurrentRow.Cells["ACTA"].Value.ToString();
                idAcNac = dgnacimientos.CurrentRow.Cells["CODIGO"].Value.ToString();
                //ruta = dgnacimientos.CurrentRow.Cells["ACTA"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar=true;
            
            gruponac1.Enabled = true;
            dgnacimientos.Enabled = false;
            cargarcajas();
            btnnuevo.Enabled = false;
            btneliminar.Text = "Cancelar";
            btnsalir.Enabled = false;
            btnImpacta.Enabled = false;
        }

        private void btnVeracta_Click(object sender, EventArgs e)
        {
            pdfnac.Print();
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Computer miPc = new Computer();

        private void button1_Click(object sender, EventArgs e)
        {
            //algoritmo para obtener una cadena con fecha y hora actual
            DateTime hoy = DateTime.Now;
            string nombre = Convert.ToString(hoy.Year) + Convert.ToString(hoy.Month) + Convert.ToString(hoy.Day) + Convert.ToString(hoy.Hour) + Convert.ToString(hoy.Minute) + Convert.ToString(hoy.Second);
            
            using(OpenFileDialog objPDF=new OpenFileDialog(){ValidateNames=true,Multiselect=false, Filter="PDF|*.pdf"})
                if (objPDF.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ruta = @"C:\Program Files\actas\NACIMIENTO";
                        txtruta.Text = objPDF.FileName;
                        ruta = ruta + @"\ACTA" + nombre + ".pdf";

                        //MessageBox.Show("y se copiara a " + ruta);
                        miPc.FileSystem.CopyFile(objPDF.FileName, ruta);
                        //MessageBox.Show("archivo copiado exitosamente");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error al copiar el acta" + ex);
                    }

                   
                    
                }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    btnnuevo.Enabled = false;
                    btneliminar.Text = "Cancelar";
                    btnsalir.Enabled = false;
                    btnImpacta.Enabled = false;
                    dgnacimientos.Enabled = false;
                    gruponac1.Enabled = true;
                    txtapmaterno.Text = "";
                    txtappaterno.Text = "";
                    txtfolio.Text = "";
                    txtlibro.Text = "";
                    txtruta.Text = "";
                    txtnombre.Text = "";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Ingresar los datos por: " + ex);
                }
            }
           
        }
      
        
    }
    
}
