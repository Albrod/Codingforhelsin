namespace Proyecto
{
    partial class Altas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Altas));
            this.btn_salir = new System.Windows.Forms.Button();
            this.tbc_altas = new System.Windows.Forms.TabControl();
            this.tbp_personas = new System.Windows.Forms.TabPage();
            this.gpb_datosempleado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_empleadocuil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_empleadocuil = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gpb_datosproveedor = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_proveedorcuit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_proveedorcuit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpb_datoscliente = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_clienteiva = new System.Windows.Forms.ComboBox();
            this.txb_clientecuit = new System.Windows.Forms.TextBox();
            this.lbl_clientecuit = new System.Windows.Forms.Label();
            this.lbl_clienteiva = new System.Windows.Forms.Label();
            this.gpb_datosgenerales = new System.Windows.Forms.GroupBox();
            this.txb_descripcion3 = new System.Windows.Forms.TextBox();
            this.txb_descripcion2 = new System.Windows.Forms.TextBox();
            this.txb_descripcion1 = new System.Windows.Forms.TextBox();
            this.txb_telefono3 = new System.Windows.Forms.TextBox();
            this.txb_telefono2 = new System.Windows.Forms.TextBox();
            this.txb_telefono1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_telefono3 = new System.Windows.Forms.Label();
            this.lbl_telefono2 = new System.Windows.Forms.Label();
            this.lbl_telefono1 = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_apellidos = new System.Windows.Forms.TextBox();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txb_nombres = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.gpb_clase = new System.Windows.Forms.GroupBox();
            this.chb_empleado = new System.Windows.Forms.CheckBox();
            this.chb_proveedor = new System.Windows.Forms.CheckBox();
            this.chb_cliente = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_borrarcampos = new System.Windows.Forms.Button();
            this.btn_daralta = new System.Windows.Forms.Button();
            this.tbc_altas.SuspendLayout();
            this.tbp_personas.SuspendLayout();
            this.gpb_datosempleado.SuspendLayout();
            this.gpb_datosproveedor.SuspendLayout();
            this.gpb_datoscliente.SuspendLayout();
            this.gpb_datosgenerales.SuspendLayout();
            this.gpb_clase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::Proyecto.Properties.Resources.salir32;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(8, 672);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(171, 49);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "&Cerrar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // tbc_altas
            // 
            this.tbc_altas.Controls.Add(this.tbp_personas);
            this.tbc_altas.Controls.Add(this.tabPage2);
            this.tbc_altas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_altas.Location = new System.Drawing.Point(8, 8);
            this.tbc_altas.Name = "tbc_altas";
            this.tbc_altas.SelectedIndex = 0;
            this.tbc_altas.Size = new System.Drawing.Size(992, 660);
            this.tbc_altas.TabIndex = 13;
            // 
            // tbp_personas
            // 
            this.tbp_personas.BackgroundImage = global::Proyecto.Properties.Resources.fondonuevo;
            this.tbp_personas.Controls.Add(this.gpb_datosempleado);
            this.tbp_personas.Controls.Add(this.gpb_datosproveedor);
            this.tbp_personas.Controls.Add(this.gpb_datoscliente);
            this.tbp_personas.Controls.Add(this.gpb_datosgenerales);
            this.tbp_personas.Controls.Add(this.gpb_clase);
            this.tbp_personas.Location = new System.Drawing.Point(4, 27);
            this.tbp_personas.Name = "tbp_personas";
            this.tbp_personas.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_personas.Size = new System.Drawing.Size(984, 629);
            this.tbp_personas.TabIndex = 0;
            this.tbp_personas.Text = "Personas";
            // 
            // gpb_datosempleado
            // 
            this.gpb_datosempleado.Controls.Add(this.label5);
            this.gpb_datosempleado.Controls.Add(this.txb_empleadocuil);
            this.gpb_datosempleado.Controls.Add(this.label12);
            this.gpb_datosempleado.Controls.Add(this.lbl_empleadocuil);
            this.gpb_datosempleado.Controls.Add(this.label13);
            this.gpb_datosempleado.Enabled = false;
            this.gpb_datosempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datosempleado.Location = new System.Drawing.Point(280, 520);
            this.gpb_datosempleado.Name = "gpb_datosempleado";
            this.gpb_datosempleado.Size = new System.Drawing.Size(692, 104);
            this.gpb_datosempleado.TabIndex = 3;
            this.gpb_datosempleado.TabStop = false;
            this.gpb_datosempleado.Text = "Datos de empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dato 4:";
            // 
            // txb_empleadocuil
            // 
            this.txb_empleadocuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_empleadocuil.Location = new System.Drawing.Point(96, 32);
            this.txb_empleadocuil.MaxLength = 10;
            this.txb_empleadocuil.Name = "txb_empleadocuil";
            this.txb_empleadocuil.Size = new System.Drawing.Size(160, 23);
            this.txb_empleadocuil.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Dato 3:";
            // 
            // lbl_empleadocuil
            // 
            this.lbl_empleadocuil.AutoSize = true;
            this.lbl_empleadocuil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empleadocuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleadocuil.Location = new System.Drawing.Point(8, 36);
            this.lbl_empleadocuil.Name = "lbl_empleadocuil";
            this.lbl_empleadocuil.Size = new System.Drawing.Size(47, 17);
            this.lbl_empleadocuil.TabIndex = 16;
            this.lbl_empleadocuil.Text = "CUIL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Dato 2:";
            // 
            // gpb_datosproveedor
            // 
            this.gpb_datosproveedor.Controls.Add(this.label4);
            this.gpb_datosproveedor.Controls.Add(this.txb_proveedorcuit);
            this.gpb_datosproveedor.Controls.Add(this.label9);
            this.gpb_datosproveedor.Controls.Add(this.lbl_proveedorcuit);
            this.gpb_datosproveedor.Controls.Add(this.label10);
            this.gpb_datosproveedor.Enabled = false;
            this.gpb_datosproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datosproveedor.Location = new System.Drawing.Point(280, 416);
            this.gpb_datosproveedor.Name = "gpb_datosproveedor";
            this.gpb_datosproveedor.Size = new System.Drawing.Size(692, 100);
            this.gpb_datosproveedor.TabIndex = 3;
            this.gpb_datosproveedor.TabStop = false;
            this.gpb_datosproveedor.Text = "Datos de proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dato 4:";
            // 
            // txb_proveedorcuit
            // 
            this.txb_proveedorcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_proveedorcuit.Location = new System.Drawing.Point(96, 28);
            this.txb_proveedorcuit.MaxLength = 10;
            this.txb_proveedorcuit.Name = "txb_proveedorcuit";
            this.txb_proveedorcuit.Size = new System.Drawing.Size(160, 23);
            this.txb_proveedorcuit.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dato 3:";
            // 
            // lbl_proveedorcuit
            // 
            this.lbl_proveedorcuit.AutoSize = true;
            this.lbl_proveedorcuit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_proveedorcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedorcuit.Location = new System.Drawing.Point(8, 28);
            this.lbl_proveedorcuit.Name = "lbl_proveedorcuit";
            this.lbl_proveedorcuit.Size = new System.Drawing.Size(48, 17);
            this.lbl_proveedorcuit.TabIndex = 13;
            this.lbl_proveedorcuit.Text = "CUIT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dato 2:";
            // 
            // gpb_datoscliente
            // 
            this.gpb_datoscliente.Controls.Add(this.label2);
            this.gpb_datoscliente.Controls.Add(this.label3);
            this.gpb_datoscliente.Controls.Add(this.cmb_clienteiva);
            this.gpb_datoscliente.Controls.Add(this.txb_clientecuit);
            this.gpb_datoscliente.Controls.Add(this.lbl_clientecuit);
            this.gpb_datoscliente.Controls.Add(this.lbl_clienteiva);
            this.gpb_datoscliente.Enabled = false;
            this.gpb_datoscliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datoscliente.Location = new System.Drawing.Point(280, 312);
            this.gpb_datoscliente.Name = "gpb_datoscliente";
            this.gpb_datoscliente.Size = new System.Drawing.Size(692, 100);
            this.gpb_datoscliente.TabIndex = 2;
            this.gpb_datoscliente.TabStop = false;
            this.gpb_datoscliente.Text = "Datos de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dato 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dato 4:";
            // 
            // cmb_clienteiva
            // 
            this.cmb_clienteiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clienteiva.FormattingEnabled = true;
            this.cmb_clienteiva.Items.AddRange(new object[] {
            "Monotributista",
            "Responsable inscripto",
            "Consumidor final"});
            this.cmb_clienteiva.Location = new System.Drawing.Point(96, 64);
            this.cmb_clienteiva.Name = "cmb_clienteiva";
            this.cmb_clienteiva.Size = new System.Drawing.Size(160, 24);
            this.cmb_clienteiva.TabIndex = 13;
            // 
            // txb_clientecuit
            // 
            this.txb_clientecuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_clientecuit.Location = new System.Drawing.Point(96, 28);
            this.txb_clientecuit.MaxLength = 10;
            this.txb_clientecuit.Name = "txb_clientecuit";
            this.txb_clientecuit.Size = new System.Drawing.Size(160, 23);
            this.txb_clientecuit.TabIndex = 10;
            // 
            // lbl_clientecuit
            // 
            this.lbl_clientecuit.AutoSize = true;
            this.lbl_clientecuit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientecuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientecuit.Location = new System.Drawing.Point(8, 32);
            this.lbl_clientecuit.Name = "lbl_clientecuit";
            this.lbl_clientecuit.Size = new System.Drawing.Size(48, 17);
            this.lbl_clientecuit.TabIndex = 10;
            this.lbl_clientecuit.Text = "CUIT:";
            // 
            // lbl_clienteiva
            // 
            this.lbl_clienteiva.AutoSize = true;
            this.lbl_clienteiva.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clienteiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clienteiva.Location = new System.Drawing.Point(8, 68);
            this.lbl_clienteiva.Name = "lbl_clienteiva";
            this.lbl_clienteiva.Size = new System.Drawing.Size(84, 17);
            this.lbl_clienteiva.TabIndex = 11;
            this.lbl_clienteiva.Text = "Cond. IVA:";
            // 
            // gpb_datosgenerales
            // 
            this.gpb_datosgenerales.Controls.Add(this.txb_descripcion3);
            this.gpb_datosgenerales.Controls.Add(this.txb_descripcion2);
            this.gpb_datosgenerales.Controls.Add(this.txb_descripcion1);
            this.gpb_datosgenerales.Controls.Add(this.txb_telefono3);
            this.gpb_datosgenerales.Controls.Add(this.txb_telefono2);
            this.gpb_datosgenerales.Controls.Add(this.txb_telefono1);
            this.gpb_datosgenerales.Controls.Add(this.label1);
            this.gpb_datosgenerales.Controls.Add(this.label6);
            this.gpb_datosgenerales.Controls.Add(this.label7);
            this.gpb_datosgenerales.Controls.Add(this.lbl_telefono3);
            this.gpb_datosgenerales.Controls.Add(this.lbl_telefono2);
            this.gpb_datosgenerales.Controls.Add(this.lbl_telefono1);
            this.gpb_datosgenerales.Controls.Add(this.txb_direccion);
            this.gpb_datosgenerales.Controls.Add(this.txb_dni);
            this.gpb_datosgenerales.Controls.Add(this.txb_apellidos);
            this.gpb_datosgenerales.Controls.Add(this.txb_descripcion);
            this.gpb_datosgenerales.Controls.Add(this.lbl_descripcion);
            this.gpb_datosgenerales.Controls.Add(this.txb_nombres);
            this.gpb_datosgenerales.Controls.Add(this.lbl_direccion);
            this.gpb_datosgenerales.Controls.Add(this.lbl_dni);
            this.gpb_datosgenerales.Controls.Add(this.lbl_apellidos);
            this.gpb_datosgenerales.Controls.Add(this.lbl_nombres);
            this.gpb_datosgenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datosgenerales.Location = new System.Drawing.Point(280, 8);
            this.gpb_datosgenerales.Name = "gpb_datosgenerales";
            this.gpb_datosgenerales.Size = new System.Drawing.Size(696, 300);
            this.gpb_datosgenerales.TabIndex = 1;
            this.gpb_datosgenerales.TabStop = false;
            this.gpb_datosgenerales.Text = "Datos generales";
            // 
            // txb_descripcion3
            // 
            this.txb_descripcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descripcion3.Location = new System.Drawing.Point(368, 268);
            this.txb_descripcion3.MaxLength = 10;
            this.txb_descripcion3.Name = "txb_descripcion3";
            this.txb_descripcion3.Size = new System.Drawing.Size(320, 23);
            this.txb_descripcion3.TabIndex = 21;
            // 
            // txb_descripcion2
            // 
            this.txb_descripcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descripcion2.Location = new System.Drawing.Point(368, 228);
            this.txb_descripcion2.MaxLength = 40;
            this.txb_descripcion2.Name = "txb_descripcion2";
            this.txb_descripcion2.Size = new System.Drawing.Size(320, 23);
            this.txb_descripcion2.TabIndex = 20;
            // 
            // txb_descripcion1
            // 
            this.txb_descripcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descripcion1.Location = new System.Drawing.Point(368, 188);
            this.txb_descripcion1.MaxLength = 40;
            this.txb_descripcion1.Name = "txb_descripcion1";
            this.txb_descripcion1.Size = new System.Drawing.Size(320, 23);
            this.txb_descripcion1.TabIndex = 19;
            // 
            // txb_telefono3
            // 
            this.txb_telefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_telefono3.Location = new System.Drawing.Point(96, 268);
            this.txb_telefono3.MaxLength = 10;
            this.txb_telefono3.Name = "txb_telefono3";
            this.txb_telefono3.Size = new System.Drawing.Size(160, 23);
            this.txb_telefono3.TabIndex = 18;
            // 
            // txb_telefono2
            // 
            this.txb_telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_telefono2.Location = new System.Drawing.Point(96, 228);
            this.txb_telefono2.MaxLength = 40;
            this.txb_telefono2.Name = "txb_telefono2";
            this.txb_telefono2.Size = new System.Drawing.Size(160, 23);
            this.txb_telefono2.TabIndex = 17;
            // 
            // txb_telefono1
            // 
            this.txb_telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_telefono1.Location = new System.Drawing.Point(96, 188);
            this.txb_telefono1.MaxLength = 40;
            this.txb_telefono1.Name = "txb_telefono1";
            this.txb_telefono1.Size = new System.Drawing.Size(160, 23);
            this.txb_telefono1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripción:";
            // 
            // lbl_telefono3
            // 
            this.lbl_telefono3.AutoSize = true;
            this.lbl_telefono3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono3.Location = new System.Drawing.Point(8, 272);
            this.lbl_telefono3.Name = "lbl_telefono3";
            this.lbl_telefono3.Size = new System.Drawing.Size(77, 17);
            this.lbl_telefono3.TabIndex = 12;
            this.lbl_telefono3.Text = "Teléfono:";
            // 
            // lbl_telefono2
            // 
            this.lbl_telefono2.AutoSize = true;
            this.lbl_telefono2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono2.Location = new System.Drawing.Point(8, 232);
            this.lbl_telefono2.Name = "lbl_telefono2";
            this.lbl_telefono2.Size = new System.Drawing.Size(77, 17);
            this.lbl_telefono2.TabIndex = 11;
            this.lbl_telefono2.Text = "Teléfono:";
            // 
            // lbl_telefono1
            // 
            this.lbl_telefono1.AutoSize = true;
            this.lbl_telefono1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono1.Location = new System.Drawing.Point(8, 192);
            this.lbl_telefono1.Name = "lbl_telefono1";
            this.lbl_telefono1.Size = new System.Drawing.Size(77, 17);
            this.lbl_telefono1.TabIndex = 10;
            this.lbl_telefono1.Text = "Teléfono:";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_direccion.Location = new System.Drawing.Point(96, 148);
            this.txb_direccion.MaxLength = 40;
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(232, 23);
            this.txb_direccion.TabIndex = 9;
            // 
            // txb_dni
            // 
            this.txb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_dni.Location = new System.Drawing.Point(96, 108);
            this.txb_dni.MaxLength = 10;
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(160, 23);
            this.txb_dni.TabIndex = 8;
            // 
            // txb_apellidos
            // 
            this.txb_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_apellidos.Location = new System.Drawing.Point(96, 68);
            this.txb_apellidos.MaxLength = 40;
            this.txb_apellidos.Name = "txb_apellidos";
            this.txb_apellidos.Size = new System.Drawing.Size(232, 23);
            this.txb_apellidos.TabIndex = 7;
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descripcion.Location = new System.Drawing.Point(352, 52);
            this.txb_descripcion.MaxLength = 100;
            this.txb_descripcion.Multiline = true;
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.Size = new System.Drawing.Size(336, 72);
            this.txb_descripcion.TabIndex = 6;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(348, 28);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(257, 17);
            this.lbl_descripcion.TabIndex = 5;
            this.lbl_descripcion.Text = "Descripcion/Información adicional:";
            // 
            // txb_nombres
            // 
            this.txb_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nombres.Location = new System.Drawing.Point(96, 28);
            this.txb_nombres.MaxLength = 40;
            this.txb_nombres.Name = "txb_nombres";
            this.txb_nombres.Size = new System.Drawing.Size(232, 23);
            this.txb_nombres.TabIndex = 4;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(8, 152);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(81, 17);
            this.lbl_direccion.TabIndex = 3;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(8, 112);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(39, 17);
            this.lbl_dni.TabIndex = 2;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(8, 72);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(79, 17);
            this.lbl_apellidos.TabIndex = 1;
            this.lbl_apellidos.Text = "Apellidos:";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.Location = new System.Drawing.Point(8, 32);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(77, 17);
            this.lbl_nombres.TabIndex = 0;
            this.lbl_nombres.Text = "Nombres:";
            // 
            // gpb_clase
            // 
            this.gpb_clase.Controls.Add(this.chb_empleado);
            this.gpb_clase.Controls.Add(this.chb_proveedor);
            this.gpb_clase.Controls.Add(this.chb_cliente);
            this.gpb_clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_clase.Location = new System.Drawing.Point(8, 8);
            this.gpb_clase.Name = "gpb_clase";
            this.gpb_clase.Size = new System.Drawing.Size(268, 184);
            this.gpb_clase.TabIndex = 0;
            this.gpb_clase.TabStop = false;
            this.gpb_clase.Text = "Seleccione la clase a dar de alta";
            // 
            // chb_empleado
            // 
            this.chb_empleado.AutoSize = true;
            this.chb_empleado.BackColor = System.Drawing.Color.Transparent;
            this.chb_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_empleado.Location = new System.Drawing.Point(8, 112);
            this.chb_empleado.Name = "chb_empleado";
            this.chb_empleado.Size = new System.Drawing.Size(98, 21);
            this.chb_empleado.TabIndex = 2;
            this.chb_empleado.Text = "Empleado";
            this.chb_empleado.UseVisualStyleBackColor = false;
            this.chb_empleado.CheckedChanged += new System.EventHandler(this.chb_empleado_CheckedChanged);
            // 
            // chb_proveedor
            // 
            this.chb_proveedor.AutoSize = true;
            this.chb_proveedor.BackColor = System.Drawing.Color.Transparent;
            this.chb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_proveedor.Location = new System.Drawing.Point(8, 68);
            this.chb_proveedor.Name = "chb_proveedor";
            this.chb_proveedor.Size = new System.Drawing.Size(102, 21);
            this.chb_proveedor.TabIndex = 1;
            this.chb_proveedor.Text = "Proveedor";
            this.chb_proveedor.UseVisualStyleBackColor = false;
            this.chb_proveedor.CheckedChanged += new System.EventHandler(this.chb_proveedor_CheckedChanged);
            // 
            // chb_cliente
            // 
            this.chb_cliente.AutoSize = true;
            this.chb_cliente.BackColor = System.Drawing.Color.Transparent;
            this.chb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_cliente.Location = new System.Drawing.Point(8, 28);
            this.chb_cliente.Name = "chb_cliente";
            this.chb_cliente.Size = new System.Drawing.Size(77, 21);
            this.chb_cliente.TabIndex = 0;
            this.chb_cliente.Text = "Cliente";
            this.chb_cliente.UseVisualStyleBackColor = false;
            this.chb_cliente.CheckedChanged += new System.EventHandler(this.chb_cliente_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_borrarcampos
            // 
            this.btn_borrarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarcampos.Image = global::Proyecto.Properties.Resources.limpiar32;
            this.btn_borrarcampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrarcampos.Location = new System.Drawing.Point(292, 672);
            this.btn_borrarcampos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_borrarcampos.Name = "btn_borrarcampos";
            this.btn_borrarcampos.Size = new System.Drawing.Size(184, 49);
            this.btn_borrarcampos.TabIndex = 14;
            this.btn_borrarcampos.Text = "&Borrar campos";
            this.btn_borrarcampos.UseVisualStyleBackColor = true;
            this.btn_borrarcampos.Click += new System.EventHandler(this.btn_borrarcampos_Click);
            // 
            // btn_daralta
            // 
            this.btn_daralta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daralta.Image = global::Proyecto.Properties.Resources.alta32;
            this.btn_daralta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_daralta.Location = new System.Drawing.Point(484, 671);
            this.btn_daralta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_daralta.Name = "btn_daralta";
            this.btn_daralta.Size = new System.Drawing.Size(184, 49);
            this.btn_daralta.TabIndex = 15;
            this.btn_daralta.Text = "&Dar de alta";
            this.btn_daralta.UseVisualStyleBackColor = true;
            // 
            // Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondonuevo;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_daralta);
            this.Controls.Add(this.btn_borrarcampos);
            this.Controls.Add(this.tbc_altas);
            this.Controls.Add(this.btn_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Altas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.Altas_Load);
            this.tbc_altas.ResumeLayout(false);
            this.tbp_personas.ResumeLayout(false);
            this.gpb_datosempleado.ResumeLayout(false);
            this.gpb_datosempleado.PerformLayout();
            this.gpb_datosproveedor.ResumeLayout(false);
            this.gpb_datosproveedor.PerformLayout();
            this.gpb_datoscliente.ResumeLayout(false);
            this.gpb_datoscliente.PerformLayout();
            this.gpb_datosgenerales.ResumeLayout(false);
            this.gpb_datosgenerales.PerformLayout();
            this.gpb_clase.ResumeLayout(false);
            this.gpb_clase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TabControl tbc_altas;
        private System.Windows.Forms.TabPage tbp_personas;
        private System.Windows.Forms.GroupBox gpb_datosgenerales;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_apellidos;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txb_nombres;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.GroupBox gpb_clase;
        private System.Windows.Forms.CheckBox chb_empleado;
        private System.Windows.Forms.CheckBox chb_proveedor;
        private System.Windows.Forms.CheckBox chb_cliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpb_datosempleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_empleadocuil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gpb_datosproveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_proveedorcuit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpb_datoscliente;
        private System.Windows.Forms.Label lbl_clientecuit;
        private System.Windows.Forms.Label lbl_clienteiva;
        private System.Windows.Forms.ComboBox cmb_clienteiva;
        private System.Windows.Forms.TextBox txb_clientecuit;
        private System.Windows.Forms.TextBox txb_empleadocuil;
        private System.Windows.Forms.TextBox txb_proveedorcuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_descripcion3;
        private System.Windows.Forms.TextBox txb_descripcion2;
        private System.Windows.Forms.TextBox txb_descripcion1;
        private System.Windows.Forms.TextBox txb_telefono3;
        private System.Windows.Forms.TextBox txb_telefono2;
        private System.Windows.Forms.TextBox txb_telefono1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_telefono3;
        private System.Windows.Forms.Label lbl_telefono2;
        private System.Windows.Forms.Label lbl_telefono1;
        private System.Windows.Forms.Button btn_borrarcampos;
        private System.Windows.Forms.Button btn_daralta;
    }
}