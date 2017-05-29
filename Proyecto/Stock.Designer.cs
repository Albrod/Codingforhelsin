namespace Proyecto
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.btn_salir = new System.Windows.Forms.Button();
            this.gpb_filtrar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dato1 = new System.Windows.Forms.Label();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chb_clase = new System.Windows.Forms.CheckBox();
            this.chb_rubro = new System.Windows.Forms.CheckBox();
            this.chb_articulo = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_borrarcampos = new System.Windows.Forms.Button();
            this.gpb_filtrar.SuspendLayout();
            this.gpb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
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
            // gpb_filtrar
            // 
            this.gpb_filtrar.Controls.Add(this.label1);
            this.gpb_filtrar.Controls.Add(this.lbl_dato1);
            this.gpb_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtrar.Location = new System.Drawing.Point(308, 8);
            this.gpb_filtrar.Name = "gpb_filtrar";
            this.gpb_filtrar.Size = new System.Drawing.Size(292, 164);
            this.gpb_filtrar.TabIndex = 19;
            this.gpb_filtrar.TabStop = false;
            this.gpb_filtrar.Text = "Filtrar artículo por:";
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
            // lbl_dato1
            // 
            this.lbl_dato1.AutoSize = true;
            this.lbl_dato1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dato1.Location = new System.Drawing.Point(12, 28);
            this.lbl_dato1.Name = "lbl_dato1";
            this.lbl_dato1.Size = new System.Drawing.Size(61, 17);
            this.lbl_dato1.TabIndex = 8;
            this.lbl_dato1.Text = "Dato 1:";
            // 
            // gpb_buscar
            // 
            this.gpb_buscar.Controls.Add(this.checkBox4);
            this.gpb_buscar.Controls.Add(this.chb_clase);
            this.gpb_buscar.Controls.Add(this.chb_rubro);
            this.gpb_buscar.Controls.Add(this.chb_articulo);
            this.gpb_buscar.Controls.Add(this.textBox4);
            this.gpb_buscar.Controls.Add(this.txb_telefono);
            this.gpb_buscar.Controls.Add(this.txb_dni);
            this.gpb_buscar.Controls.Add(this.txb_nombre);
            this.gpb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_buscar.Location = new System.Drawing.Point(8, 8);
            this.gpb_buscar.Name = "gpb_buscar";
            this.gpb_buscar.Size = new System.Drawing.Size(292, 164);
            this.gpb_buscar.TabIndex = 18;
            this.gpb_buscar.TabStop = false;
            this.gpb_buscar.Text = "Buscar artículo por:";
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
            // chb_clase
            // 
            this.chb_clase.AutoSize = true;
            this.chb_clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_clase.Location = new System.Drawing.Point(12, 100);
            this.chb_clase.Name = "chb_clase";
            this.chb_clase.Size = new System.Drawing.Size(72, 21);
            this.chb_clase.TabIndex = 10;
            this.chb_clase.Text = "Clase:";
            this.chb_clase.UseVisualStyleBackColor = true;
            // 
            // chb_rubro
            // 
            this.chb_rubro.AutoSize = true;
            this.chb_rubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_rubro.Location = new System.Drawing.Point(12, 64);
            this.chb_rubro.Name = "chb_rubro";
            this.chb_rubro.Size = new System.Drawing.Size(76, 21);
            this.chb_rubro.TabIndex = 9;
            this.chb_rubro.Text = "Rubro:";
            this.chb_rubro.UseVisualStyleBackColor = true;
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
            // txb_dni
            // 
            this.txb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_dni.Location = new System.Drawing.Point(136, 64);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(148, 23);
            this.txb_dni.TabIndex = 3;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nombre.Location = new System.Drawing.Point(136, 28);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(148, 23);
            this.txb_nombre.TabIndex = 1;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(8, 180);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(992, 488);
            this.dgv_usuarios.TabIndex = 17;
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
            this.btn_buscar.TabIndex = 21;
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
            this.btn_borrarcampos.TabIndex = 20;
            this.btn_borrarcampos.Text = "Borrar &campos";
            this.btn_borrarcampos.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondonuevo1920x1080;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_borrarcampos);
            this.Controls.Add(this.gpb_filtrar);
            this.Controls.Add(this.gpb_buscar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_FormClosing);
            this.gpb_filtrar.ResumeLayout(false);
            this.gpb_filtrar.PerformLayout();
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox gpb_filtrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dato1;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chb_clase;
        private System.Windows.Forms.CheckBox chb_rubro;
        private System.Windows.Forms.CheckBox chb_articulo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_borrarcampos;
    }
}