namespace Proyecto
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.gpb_filtrar = new System.Windows.Forms.GroupBox();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chb_numerofactura = new System.Windows.Forms.CheckBox();
            this.chb_dni = new System.Windows.Forms.CheckBox();
            this.chb_articulo = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_borrarcampos = new System.Windows.Forms.Button();
            this.cmb_articulo = new System.Windows.Forms.ComboBox();
            this.cmb_dni = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.gpb_filtrar.SuspendLayout();
            this.gpb_buscar.SuspendLayout();
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
            // dgv_registros
            // 
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(8, 180);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.Size = new System.Drawing.Size(992, 488);
            this.dgv_registros.TabIndex = 12;
            // 
            // gpb_filtrar
            // 
            this.gpb_filtrar.Controls.Add(this.dtp_hasta);
            this.gpb_filtrar.Controls.Add(this.dtp_desde);
            this.gpb_filtrar.Controls.Add(this.lbl_hasta);
            this.gpb_filtrar.Controls.Add(this.lbl_desde);
            this.gpb_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtrar.Location = new System.Drawing.Point(308, 8);
            this.gpb_filtrar.Name = "gpb_filtrar";
            this.gpb_filtrar.Size = new System.Drawing.Size(292, 164);
            this.gpb_filtrar.TabIndex = 18;
            this.gpb_filtrar.TabStop = false;
            this.gpb_filtrar.Text = "Filtrar por fecha:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(12, 64);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(55, 17);
            this.lbl_hasta.TabIndex = 9;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(12, 28);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(59, 17);
            this.lbl_desde.TabIndex = 8;
            this.lbl_desde.Text = "Desde:";
            // 
            // gpb_buscar
            // 
            this.gpb_buscar.Controls.Add(this.cmb_dni);
            this.gpb_buscar.Controls.Add(this.cmb_articulo);
            this.gpb_buscar.Controls.Add(this.checkBox4);
            this.gpb_buscar.Controls.Add(this.chb_numerofactura);
            this.gpb_buscar.Controls.Add(this.chb_dni);
            this.gpb_buscar.Controls.Add(this.chb_articulo);
            this.gpb_buscar.Controls.Add(this.textBox4);
            this.gpb_buscar.Controls.Add(this.txb_telefono);
            this.gpb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_buscar.Location = new System.Drawing.Point(8, 8);
            this.gpb_buscar.Name = "gpb_buscar";
            this.gpb_buscar.Size = new System.Drawing.Size(292, 164);
            this.gpb_buscar.TabIndex = 17;
            this.gpb_buscar.TabStop = false;
            this.gpb_buscar.Text = "Buscar registro por:";
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
            // chb_numerofactura
            // 
            this.chb_numerofactura.AutoSize = true;
            this.chb_numerofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_numerofactura.Location = new System.Drawing.Point(12, 100);
            this.chb_numerofactura.Name = "chb_numerofactura";
            this.chb_numerofactura.Size = new System.Drawing.Size(119, 21);
            this.chb_numerofactura.TabIndex = 10;
            this.chb_numerofactura.Text = "Nro. factura:";
            this.chb_numerofactura.UseVisualStyleBackColor = true;
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
            // chb_articulo
            // 
            this.chb_articulo.AutoSize = true;
            this.chb_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_articulo.Location = new System.Drawing.Point(12, 28);
            this.chb_articulo.Name = "chb_articulo";
            this.chb_articulo.Size = new System.Drawing.Size(87, 21);
            this.chb_articulo.TabIndex = 8;
            this.chb_articulo.Text = "Artículo:";
            this.chb_articulo.UseVisualStyleBackColor = true;
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
            // dtp_desde
            // 
            this.dtp_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_desde.Location = new System.Drawing.Point(76, 24);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 24);
            this.dtp_desde.TabIndex = 10;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hasta.Location = new System.Drawing.Point(76, 60);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 24);
            this.dtp_hasta.TabIndex = 11;
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
            this.btn_buscar.TabIndex = 23;
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
            this.btn_borrarcampos.TabIndex = 22;
            this.btn_borrarcampos.Text = "Borrar &campos";
            this.btn_borrarcampos.UseVisualStyleBackColor = true;
            // 
            // cmb_articulo
            // 
            this.cmb_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_articulo.FormattingEnabled = true;
            this.cmb_articulo.Location = new System.Drawing.Point(136, 28);
            this.cmb_articulo.Name = "cmb_articulo";
            this.cmb_articulo.Size = new System.Drawing.Size(148, 24);
            this.cmb_articulo.TabIndex = 12;
            // 
            // cmb_dni
            // 
            this.cmb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dni.FormattingEnabled = true;
            this.cmb_dni.Location = new System.Drawing.Point(136, 64);
            this.cmb_dni.Name = "cmb_dni";
            this.cmb_dni.Size = new System.Drawing.Size(148, 24);
            this.cmb_dni.TabIndex = 13;
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondonuevo1920x1080;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_borrarcampos);
            this.Controls.Add(this.gpb_filtrar);
            this.Controls.Add(this.gpb_buscar);
            this.Controls.Add(this.dgv_registros);
            this.Controls.Add(this.btn_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.gpb_filtrar.ResumeLayout(false);
            this.gpb_filtrar.PerformLayout();
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.GroupBox gpb_filtrar;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chb_numerofactura;
        private System.Windows.Forms.CheckBox chb_dni;
        private System.Windows.Forms.CheckBox chb_articulo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_borrarcampos;
        private System.Windows.Forms.ComboBox cmb_articulo;
        private System.Windows.Forms.ComboBox cmb_dni;
    }
}