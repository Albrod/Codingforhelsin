namespace Proyecto
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btn_salir = new System.Windows.Forms.Button();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.cmb_dni = new System.Windows.Forms.ComboBox();
            this.cmb_nombre = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chb_telefono = new System.Windows.Forms.CheckBox();
            this.chb_dni = new System.Windows.Forms.CheckBox();
            this.chb_nombre = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.gpb_filtrar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_borrarcampos = new System.Windows.Forms.Button();
            this.gpb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.gpb_filtrar.SuspendLayout();
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
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "&Cerrar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gpb_buscar
            // 
            this.gpb_buscar.Controls.Add(this.cmb_dni);
            this.gpb_buscar.Controls.Add(this.cmb_nombre);
            this.gpb_buscar.Controls.Add(this.checkBox4);
            this.gpb_buscar.Controls.Add(this.chb_telefono);
            this.gpb_buscar.Controls.Add(this.chb_dni);
            this.gpb_buscar.Controls.Add(this.chb_nombre);
            this.gpb_buscar.Controls.Add(this.textBox4);
            this.gpb_buscar.Controls.Add(this.txb_telefono);
            this.gpb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_buscar.Location = new System.Drawing.Point(8, 8);
            this.gpb_buscar.Name = "gpb_buscar";
            this.gpb_buscar.Size = new System.Drawing.Size(292, 164);
            this.gpb_buscar.TabIndex = 15;
            this.gpb_buscar.TabStop = false;
            this.gpb_buscar.Text = "Buscar cliente por:";
            // 
            // cmb_dni
            // 
            this.cmb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dni.FormattingEnabled = true;
            this.cmb_dni.Location = new System.Drawing.Point(136, 64);
            this.cmb_dni.Name = "cmb_dni";
            this.cmb_dni.Size = new System.Drawing.Size(148, 24);
            this.cmb_dni.TabIndex = 14;
            // 
            // cmb_nombre
            // 
            this.cmb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nombre.FormattingEnabled = true;
            this.cmb_nombre.Location = new System.Drawing.Point(136, 28);
            this.cmb_nombre.Name = "cmb_nombre";
            this.cmb_nombre.Size = new System.Drawing.Size(148, 24);
            this.cmb_nombre.TabIndex = 13;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(12, 136);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 21);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Dato 4:";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // chb_telefono
            // 
            this.chb_telefono.AutoSize = true;
            this.chb_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_telefono.Location = new System.Drawing.Point(12, 100);
            this.chb_telefono.Name = "chb_telefono";
            this.chb_telefono.Size = new System.Drawing.Size(96, 21);
            this.chb_telefono.TabIndex = 10;
            this.chb_telefono.Text = "Teléfono:";
            this.chb_telefono.UseVisualStyleBackColor = true;
            // 
            // chb_dni
            // 
            this.chb_dni.AutoSize = true;
            this.chb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_dni.Location = new System.Drawing.Point(12, 64);
            this.chb_dni.Name = "chb_dni";
            this.chb_dni.Size = new System.Drawing.Size(58, 21);
            this.chb_dni.TabIndex = 9;
            this.chb_dni.Text = "DNI:";
            this.chb_dni.UseVisualStyleBackColor = true;
            // 
            // chb_nombre
            // 
            this.chb_nombre.AutoSize = true;
            this.chb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_nombre.Location = new System.Drawing.Point(12, 28);
            this.chb_nombre.Name = "chb_nombre";
            this.chb_nombre.Size = new System.Drawing.Size(88, 21);
            this.chb_nombre.TabIndex = 8;
            this.chb_nombre.Text = "Nombre:";
            this.chb_nombre.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(136, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 23);
            this.textBox4.TabIndex = 7;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_telefono.Location = new System.Drawing.Point(136, 100);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(148, 23);
            this.txb_telefono.TabIndex = 5;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(8, 180);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(992, 488);
            this.dgv_usuarios.TabIndex = 14;
            // 
            // gpb_filtrar
            // 
            this.gpb_filtrar.Controls.Add(this.comboBox1);
            this.gpb_filtrar.Controls.Add(this.label1);
            this.gpb_filtrar.Controls.Add(this.lbl_iva);
            this.gpb_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtrar.Location = new System.Drawing.Point(308, 8);
            this.gpb_filtrar.Name = "gpb_filtrar";
            this.gpb_filtrar.Size = new System.Drawing.Size(292, 164);
            this.gpb_filtrar.TabIndex = 16;
            this.gpb_filtrar.TabStop = false;
            this.gpb_filtrar.Text = "Filtrar cliente por:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dato 2:";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.BackColor = System.Drawing.Color.Transparent;
            this.lbl_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.Location = new System.Drawing.Point(12, 28);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(37, 17);
            this.lbl_iva.TabIndex = 8;
            this.lbl_iva.Text = "IVA:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::Proyecto.Properties.Resources.buscar32;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(608, 32);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(184, 49);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "&Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_borrarcampos
            // 
            this.btn_borrarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarcampos.Image = global::Proyecto.Properties.Resources.limpiar32;
            this.btn_borrarcampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrarcampos.Location = new System.Drawing.Point(608, 104);
            this.btn_borrarcampos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_borrarcampos.Name = "btn_borrarcampos";
            this.btn_borrarcampos.Size = new System.Drawing.Size(184, 49);
            this.btn_borrarcampos.TabIndex = 16;
            this.btn_borrarcampos.Text = "Borrar &campos";
            this.btn_borrarcampos.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondonuevo1920x1080;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.gpb_filtrar);
            this.Controls.Add(this.btn_borrarcampos);
            this.Controls.Add(this.gpb_buscar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clientes_FormClosing);
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.gpb_filtrar.ResumeLayout(false);
            this.gpb_filtrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chb_telefono;
        private System.Windows.Forms.CheckBox chb_dni;
        private System.Windows.Forms.CheckBox chb_nombre;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.GroupBox gpb_filtrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_borrarcampos;
        private System.Windows.Forms.ComboBox cmb_dni;
        private System.Windows.Forms.ComboBox cmb_nombre;
    }
}