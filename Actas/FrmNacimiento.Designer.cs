namespace Actas
{
    partial class FrmNacimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNacimiento));
            this.gruponac1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtapmaterno = new System.Windows.Forms.TextBox();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgnacimientos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImpacta = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pdfnac = new AxAcroPDFLib.AxAcroPDF();
            this.gruponac1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgnacimientos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfnac)).BeginInit();
            this.SuspendLayout();
            // 
            // gruponac1
            // 
            this.gruponac1.Controls.Add(this.button1);
            this.gruponac1.Controls.Add(this.txtruta);
            this.gruponac1.Controls.Add(this.dtpfecha);
            this.gruponac1.Controls.Add(this.txtapmaterno);
            this.gruponac1.Controls.Add(this.txtappaterno);
            this.gruponac1.Controls.Add(this.txtnombre);
            this.gruponac1.Controls.Add(this.txtfolio);
            this.gruponac1.Controls.Add(this.txtlibro);
            this.gruponac1.Controls.Add(this.label7);
            this.gruponac1.Controls.Add(this.label6);
            this.gruponac1.Controls.Add(this.label5);
            this.gruponac1.Controls.Add(this.label4);
            this.gruponac1.Controls.Add(this.label3);
            this.gruponac1.Controls.Add(this.label2);
            this.gruponac1.Location = new System.Drawing.Point(15, 50);
            this.gruponac1.Name = "gruponac1";
            this.gruponac1.Size = new System.Drawing.Size(538, 126);
            this.gruponac1.TabIndex = 0;
            this.gruponac1.TabStop = false;
            this.gruponac1.Text = "Datos Generales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Seleccionar Acta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(20, 86);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(402, 20);
            this.txtruta.TabIndex = 14;
            this.txtruta.Visible = false;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(420, 55);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(91, 20);
            this.dtpfecha.TabIndex = 13;
            // 
            // txtapmaterno
            // 
            this.txtapmaterno.Location = new System.Drawing.Point(265, 52);
            this.txtapmaterno.Name = "txtapmaterno";
            this.txtapmaterno.Size = new System.Drawing.Size(100, 20);
            this.txtapmaterno.TabIndex = 12;
            // 
            // txtappaterno
            // 
            this.txtappaterno.Location = new System.Drawing.Point(77, 52);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.Size = new System.Drawing.Size(119, 20);
            this.txtappaterno.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(305, 26);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(206, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(197, 26);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(49, 20);
            this.txtfolio.TabIndex = 9;
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(77, 26);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(43, 20);
            this.txtlibro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "F. de Nac.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ap. Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ap. Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "N° de Folio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° de Libro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Impresión de ACTAS REGISTRALES";
            // 
            // dgnacimientos
            // 
            this.dgnacimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnacimientos.Location = new System.Drawing.Point(15, 181);
            this.dgnacimientos.Name = "dgnacimientos";
            this.dgnacimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgnacimientos.Size = new System.Drawing.Size(538, 445);
            this.dgnacimientos.TabIndex = 2;
            this.dgnacimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgnacimientos_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImpacta);
            this.groupBox2.Controls.Add(this.btneditar);
            this.groupBox2.Controls.Add(this.btnsalir);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Location = new System.Drawing.Point(569, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 574);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento";
            // 
            // btnImpacta
            // 
            this.btnImpacta.Image = global::Actas.Properties.Resources.printer;
            this.btnImpacta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImpacta.Location = new System.Drawing.Point(12, 503);
            this.btnImpacta.Name = "btnImpacta";
            this.btnImpacta.Size = new System.Drawing.Size(75, 55);
            this.btnImpacta.TabIndex = 5;
            this.btnImpacta.Text = "Imprimir";
            this.btnImpacta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImpacta.UseVisualStyleBackColor = true;
            this.btnImpacta.Click += new System.EventHandler(this.btnVeracta_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Actas.Properties.Resources.btnew;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(11, 108);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 62);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Actas.Properties.Resources.btdeshace;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(11, 310);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 56);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::Actas.Properties.Resources.btguarda;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardar.Location = new System.Drawing.Point(11, 246);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 58);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Actas.Properties.Resources.btelimina;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(11, 176);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 64);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::Actas.Properties.Resources.nuevo;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnuevo.Location = new System.Drawing.Point(11, 42);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 60);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vista Previa";
            // 
            // pdfnac
            // 
            this.pdfnac.Enabled = true;
            this.pdfnac.Location = new System.Drawing.Point(719, 52);
            this.pdfnac.Name = "pdfnac";
            this.pdfnac.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfnac.OcxState")));
            this.pdfnac.Size = new System.Drawing.Size(439, 574);
            this.pdfnac.TabIndex = 5;
            // 
            // FrmNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1286, 676);
            this.Controls.Add(this.pdfnac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgnacimientos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gruponac1);
            this.Name = "FrmNacimiento";
            this.Text = "FrmNacimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNacimiento_Load);
            this.gruponac1.ResumeLayout(false);
            this.gruponac1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgnacimientos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfnac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gruponac1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgnacimientos;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtapmaterno;
        private System.Windows.Forms.TextBox txtappaterno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.TextBox txtlibro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label8;
        private AxAcroPDFLib.AxAcroPDF pdfnac;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnImpacta;
        private System.Windows.Forms.Button button1;

    }
}