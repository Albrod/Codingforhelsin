namespace Proyecto
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tbc_principal = new System.Windows.Forms.TabControl();
            this.tbp_ventas = new System.Windows.Forms.TabPage();
            this.tbp_compras = new System.Windows.Forms.TabPage();
            this.bt_compras_daralta = new System.Windows.Forms.Button();
            this.tb__compras_descompra = new System.Windows.Forms.TextBox();
            this.tb_compras_fechacompra = new System.Windows.Forms.TextBox();
            this.tb_compras_pt = new System.Windows.Forms.TextBox();
            this.tb_compras_pxu = new System.Windows.Forms.TextBox();
            this.cb_compras_unidad = new System.Windows.Forms.ComboBox();
            this.tb_compras_cantcomprada = new System.Windows.Forms.TextBox();
            this.btn_altastock = new System.Windows.Forms.Button();
            this.bt_compras_borrarlista = new System.Windows.Forms.Button();
            this.bt_compras_agregar = new System.Windows.Forms.Button();
            this.dgv_compras_listacompra = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_compras_art = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_registros = new System.Windows.Forms.Button();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_bajasmodif = new System.Windows.Forms.Button();
            this.btn_altas = new System.Windows.Forms.Button();
            this.spc_principal = new System.Windows.Forms.SplitContainer();
            this.tbc_principal.SuspendLayout();
            this.tbp_compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras_listacompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_principal)).BeginInit();
            this.spc_principal.Panel1.SuspendLayout();
            this.spc_principal.Panel2.SuspendLayout();
            this.spc_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_principal
            // 
            this.tbc_principal.Controls.Add(this.tbp_ventas);
            this.tbc_principal.Controls.Add(this.tbp_compras);
            this.tbc_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_principal.Location = new System.Drawing.Point(4, 4);
            this.tbc_principal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbc_principal.Name = "tbc_principal";
            this.tbc_principal.SelectedIndex = 0;
            this.tbc_principal.Size = new System.Drawing.Size(780, 592);
            this.tbc_principal.TabIndex = 1;
            // 
            // tbp_ventas
            // 
            this.tbp_ventas.Location = new System.Drawing.Point(4, 27);
            this.tbp_ventas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbp_ventas.Name = "tbp_ventas";
            this.tbp_ventas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbp_ventas.Size = new System.Drawing.Size(772, 561);
            this.tbp_ventas.TabIndex = 0;
            this.tbp_ventas.Text = "Ventas";
            this.tbp_ventas.UseVisualStyleBackColor = true;
            // 
            // tbp_compras
            // 
            this.tbp_compras.Controls.Add(this.bt_compras_daralta);
            this.tbp_compras.Controls.Add(this.tb__compras_descompra);
            this.tbp_compras.Controls.Add(this.tb_compras_fechacompra);
            this.tbp_compras.Controls.Add(this.tb_compras_pt);
            this.tbp_compras.Controls.Add(this.tb_compras_pxu);
            this.tbp_compras.Controls.Add(this.cb_compras_unidad);
            this.tbp_compras.Controls.Add(this.tb_compras_cantcomprada);
            this.tbp_compras.Controls.Add(this.btn_altastock);
            this.tbp_compras.Controls.Add(this.bt_compras_borrarlista);
            this.tbp_compras.Controls.Add(this.bt_compras_agregar);
            this.tbp_compras.Controls.Add(this.dgv_compras_listacompra);
            this.tbp_compras.Controls.Add(this.cb_compras_art);
            this.tbp_compras.Controls.Add(this.label6);
            this.tbp_compras.Controls.Add(this.label5);
            this.tbp_compras.Controls.Add(this.label4);
            this.tbp_compras.Controls.Add(this.label3);
            this.tbp_compras.Controls.Add(this.label2);
            this.tbp_compras.Controls.Add(this.label1);
            this.tbp_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_compras.Location = new System.Drawing.Point(4, 27);
            this.tbp_compras.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbp_compras.Name = "tbp_compras";
            this.tbp_compras.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbp_compras.Size = new System.Drawing.Size(772, 561);
            this.tbp_compras.TabIndex = 1;
            this.tbp_compras.Text = "Compras";
            this.tbp_compras.UseVisualStyleBackColor = true;
            // 
            // bt_compras_daralta
            // 
            this.bt_compras_daralta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compras_daralta.Image = global::Proyecto.Properties.Resources.alta32;
            this.bt_compras_daralta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_compras_daralta.Location = new System.Drawing.Point(591, 481);
            this.bt_compras_daralta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_compras_daralta.Name = "bt_compras_daralta";
            this.bt_compras_daralta.Size = new System.Drawing.Size(171, 49);
            this.bt_compras_daralta.TabIndex = 23;
            this.bt_compras_daralta.Text = "  &Agregar a lista";
            this.bt_compras_daralta.UseVisualStyleBackColor = true;
            // 
            // tb__compras_descompra
            // 
            this.tb__compras_descompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb__compras_descompra.Location = new System.Drawing.Point(172, 216);
            this.tb__compras_descompra.Name = "tb__compras_descompra";
            this.tb__compras_descompra.Size = new System.Drawing.Size(196, 23);
            this.tb__compras_descompra.TabIndex = 21;
            // 
            // tb_compras_fechacompra
            // 
            this.tb_compras_fechacompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compras_fechacompra.Location = new System.Drawing.Point(172, 176);
            this.tb_compras_fechacompra.Name = "tb_compras_fechacompra";
            this.tb_compras_fechacompra.Size = new System.Drawing.Size(148, 23);
            this.tb_compras_fechacompra.TabIndex = 20;
            // 
            // tb_compras_pt
            // 
            this.tb_compras_pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compras_pt.Location = new System.Drawing.Point(172, 136);
            this.tb_compras_pt.Name = "tb_compras_pt";
            this.tb_compras_pt.Size = new System.Drawing.Size(76, 23);
            this.tb_compras_pt.TabIndex = 19;
            // 
            // tb_compras_pxu
            // 
            this.tb_compras_pxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compras_pxu.Location = new System.Drawing.Point(172, 96);
            this.tb_compras_pxu.Name = "tb_compras_pxu";
            this.tb_compras_pxu.Size = new System.Drawing.Size(76, 23);
            this.tb_compras_pxu.TabIndex = 18;
            // 
            // cb_compras_unidad
            // 
            this.cb_compras_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_compras_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_compras_unidad.FormattingEnabled = true;
            this.cb_compras_unidad.Items.AddRange(new object[] {
            "Gramos",
            "Kilos",
            "Litros",
            "C.C.",
            "Unidad",
            "Otros"});
            this.cb_compras_unidad.Location = new System.Drawing.Point(252, 56);
            this.cb_compras_unidad.Name = "cb_compras_unidad";
            this.cb_compras_unidad.Size = new System.Drawing.Size(116, 24);
            this.cb_compras_unidad.TabIndex = 17;
            // 
            // tb_compras_cantcomprada
            // 
            this.tb_compras_cantcomprada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compras_cantcomprada.Location = new System.Drawing.Point(172, 56);
            this.tb_compras_cantcomprada.Name = "tb_compras_cantcomprada";
            this.tb_compras_cantcomprada.Size = new System.Drawing.Size(76, 23);
            this.tb_compras_cantcomprada.TabIndex = 16;
            // 
            // btn_altastock
            // 
            this.btn_altastock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altastock.Image = global::Proyecto.Properties.Resources.guardar32;
            this.btn_altastock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_altastock.Location = new System.Drawing.Point(592, 568);
            this.btn_altastock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_altastock.Name = "btn_altastock";
            this.btn_altastock.Size = new System.Drawing.Size(171, 49);
            this.btn_altastock.TabIndex = 15;
            this.btn_altastock.Text = "&Cargar";
            this.btn_altastock.UseVisualStyleBackColor = true;
            // 
            // bt_compras_borrarlista
            // 
            this.bt_compras_borrarlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compras_borrarlista.Image = global::Proyecto.Properties.Resources.borrar32;
            this.bt_compras_borrarlista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_compras_borrarlista.Location = new System.Drawing.Point(592, 356);
            this.bt_compras_borrarlista.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_compras_borrarlista.Name = "bt_compras_borrarlista";
            this.bt_compras_borrarlista.Size = new System.Drawing.Size(171, 49);
            this.bt_compras_borrarlista.TabIndex = 14;
            this.bt_compras_borrarlista.Text = "     &Borrar seleccion";
            this.bt_compras_borrarlista.UseVisualStyleBackColor = true;
            // 
            // bt_compras_agregar
            // 
            this.bt_compras_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compras_agregar.Image = global::Proyecto.Properties.Resources.agregar32;
            this.bt_compras_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_compras_agregar.Location = new System.Drawing.Point(592, 264);
            this.bt_compras_agregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_compras_agregar.Name = "bt_compras_agregar";
            this.bt_compras_agregar.Size = new System.Drawing.Size(171, 49);
            this.bt_compras_agregar.TabIndex = 13;
            this.bt_compras_agregar.Text = "  &Agregar a lista";
            this.bt_compras_agregar.UseVisualStyleBackColor = true;
            // 
            // dgv_compras_listacompra
            // 
            this.dgv_compras_listacompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compras_listacompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Unidades,
            this.Preciounitario,
            this.Total,
            this.Descripción});
            this.dgv_compras_listacompra.Location = new System.Drawing.Point(12, 264);
            this.dgv_compras_listacompra.Name = "dgv_compras_listacompra";
            this.dgv_compras_listacompra.ReadOnly = true;
            this.dgv_compras_listacompra.Size = new System.Drawing.Size(572, 356);
            this.dgv_compras_listacompra.TabIndex = 7;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // Preciounitario
            // 
            this.Preciounitario.HeaderText = "Precio Unitario";
            this.Preciounitario.Name = "Preciounitario";
            this.Preciounitario.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // cb_compras_art
            // 
            this.cb_compras_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_compras_art.FormattingEnabled = true;
            this.cb_compras_art.Location = new System.Drawing.Point(172, 16);
            this.cb_compras_art.Name = "cb_compras_art";
            this.cb_compras_art.Size = new System.Drawing.Size(196, 24);
            this.cb_compras_art.TabIndex = 6;
            this.cb_compras_art.Enter += new System.EventHandler(this.cb_compras_art_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio por Unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículo:";
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Image = global::Proyecto.Properties.Resources.empleados32;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(12, 327);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(171, 49);
            this.btn_usuarios.TabIndex = 9;
            this.btn_usuarios.Text = "&Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.Image = global::Proyecto.Properties.Resources.clientes32;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(12, 248);
            this.btn_clientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(171, 49);
            this.btn_clientes.TabIndex = 8;
            this.btn_clientes.Text = "&Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_registros
            // 
            this.btn_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registros.Image = global::Proyecto.Properties.Resources.archivos32;
            this.btn_registros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registros.Location = new System.Drawing.Point(12, 170);
            this.btn_registros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(171, 49);
            this.btn_registros.TabIndex = 7;
            this.btn_registros.Text = "&Registros";
            this.btn_registros.UseVisualStyleBackColor = true;
            this.btn_registros.Click += new System.EventHandler(this.btn_registros_Click);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedores.Image = global::Proyecto.Properties.Resources.proveedores32;
            this.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedores.Location = new System.Drawing.Point(12, 91);
            this.btn_proveedores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(171, 49);
            this.btn_proveedores.TabIndex = 6;
            this.btn_proveedores.Text = "&Proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = true;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Image = global::Proyecto.Properties.Resources.stock32;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(12, 12);
            this.btn_stock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(171, 49);
            this.btn_stock.TabIndex = 5;
            this.btn_stock.Text = "S&tock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
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
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_bajasmodif
            // 
            this.btn_bajasmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bajasmodif.Image = global::Proyecto.Properties.Resources.modificar32;
            this.btn_bajasmodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bajasmodif.Location = new System.Drawing.Point(12, 487);
            this.btn_bajasmodif.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_bajasmodif.Name = "btn_bajasmodif";
            this.btn_bajasmodif.Size = new System.Drawing.Size(171, 49);
            this.btn_bajasmodif.TabIndex = 12;
            this.btn_bajasmodif.Text = "&Bajas/Modif.";
            this.btn_bajasmodif.UseVisualStyleBackColor = true;
            this.btn_bajasmodif.Click += new System.EventHandler(this.btn_bajasmodif_Click);
            // 
            // btn_altas
            // 
            this.btn_altas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altas.Image = global::Proyecto.Properties.Resources.agregar32;
            this.btn_altas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_altas.Location = new System.Drawing.Point(12, 408);
            this.btn_altas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_altas.Name = "btn_altas";
            this.btn_altas.Size = new System.Drawing.Size(171, 49);
            this.btn_altas.TabIndex = 11;
            this.btn_altas.Text = "&Altas";
            this.btn_altas.UseVisualStyleBackColor = true;
            this.btn_altas.Click += new System.EventHandler(this.btn_altas_Click);
            // 
            // spc_principal
            // 
            this.spc_principal.Location = new System.Drawing.Point(4, 68);
            this.spc_principal.Name = "spc_principal";
            // 
            // spc_principal.Panel1
            // 
            this.spc_principal.Panel1.Controls.Add(this.btn_stock);
            this.spc_principal.Panel1.Controls.Add(this.btn_bajasmodif);
            this.spc_principal.Panel1.Controls.Add(this.btn_proveedores);
            this.spc_principal.Panel1.Controls.Add(this.btn_altas);
            this.spc_principal.Panel1.Controls.Add(this.btn_registros);
            this.spc_principal.Panel1.Controls.Add(this.btn_clientes);
            this.spc_principal.Panel1.Controls.Add(this.btn_usuarios);
            // 
            // spc_principal.Panel2
            // 
            this.spc_principal.Panel2.Controls.Add(this.tbc_principal);
            this.spc_principal.Size = new System.Drawing.Size(988, 600);
            this.spc_principal.SplitterDistance = 195;
            this.spc_principal.TabIndex = 13;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondonuevo1920x1080;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.spc_principal);
            this.Controls.Add(this.btn_salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tbc_principal.ResumeLayout(false);
            this.tbp_compras.ResumeLayout(false);
            this.tbp_compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras_listacompra)).EndInit();
            this.spc_principal.Panel1.ResumeLayout(false);
            this.spc_principal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_principal)).EndInit();
            this.spc_principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_principal;
        private System.Windows.Forms.TabPage tbp_compras;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_registros;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_bajasmodif;
        private System.Windows.Forms.Button btn_altas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_altastock;
        private System.Windows.Forms.Button bt_compras_borrarlista;
        private System.Windows.Forms.Button bt_compras_agregar;
        private System.Windows.Forms.DataGridView dgv_compras_listacompra;
        private System.Windows.Forms.TextBox tb_compras_cantcomprada;
        private System.Windows.Forms.TextBox tb__compras_descompra;
        private System.Windows.Forms.TextBox tb_compras_fechacompra;
        private System.Windows.Forms.TextBox tb_compras_pt;
        private System.Windows.Forms.TextBox tb_compras_pxu;
        private System.Windows.Forms.ComboBox cb_compras_unidad;
        private System.Windows.Forms.TabPage tbp_ventas;
        private System.Windows.Forms.SplitContainer spc_principal;
        private System.Windows.Forms.ComboBox cb_compras_art;
        private System.Windows.Forms.Button bt_compras_daralta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;

    }
}