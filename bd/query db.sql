/*Drop*/
DROP DATABASE comercio;
/*DataBase*/
CREATE DATABASE comercio;
GO
USE comercio;
GO
/* Tables */

CREATE TABLE [Articulos] (
[id_articulo] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[nombre] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[id_unidad] INT,
[id_clase] INT,
[id_rubro] INT,
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Unidades] (
[id_unidad] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Clase] (
[id_clase] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[nombre] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Clase-Rubro] (
[id_clase_rubro] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_clase] INT,
[id_rubro] INT,
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Cliente] (
[id_cliente] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT UNIQUE,
[cuit] NVARCHAR(40),
[condicion IVA] NVARCHAR(40),
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Empleados] (
[id_empleado] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT UNIQUE,
[cuil] NVARCHAR(40),
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Facturacion] (
[id_facturacion] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[cod_factura] NVARCHAR(40),
[id_cliente] INTEGER,
[id_articulo] INTEGER,
[tipo iva] NVARCHAR(40),
[tipo factura] NVARCHAR(40)
);
GO
CREATE TABLE [Ficha de transaccion] (
[id_transac] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[tipo] NVARCHAR(40),
[fecha] DATETIME,
[id_articulo] INT,
[cantidad] INT,
[precio x unidad] INT,
[total] INT,
[id_facturacion] INT null,
);
GO
CREATE TABLE [Personas] (
[id_persona] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[nombre] NVARCHAR(40),
[apellido] NVARCHAR(40),
[dni] NVARCHAR(40),
[direccion] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
);
GO
CREATE TABLE [Proveedor] (
[id_proveedor] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT UNIQUE,
[cuit] NVARCHAR(40),
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Proveedor-Articulo] (
[id_pro_art] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_proveedor] INT,
[id_articulo] INT,
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Rubro] (
[Id_rubro] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[Nombre] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Stock] (
[id_stock] INT NOT NULL UNIQUE,
[cantidad] INT,
[precio] INT,
[total] INT,
[stock minimo] INT,
[iva] INT,
[ganancia] INT,
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Telefonos] (
[id_telefono] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT,
[numero de telefono] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
CREATE TABLE [Usuarios] (
[id_usuario] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_empleado] INT,
[usuario] NVARCHAR(40),
[contraseña] NVARCHAR(40) /**COMMENT* almacenar de manera encriptada o cifrada */,
[estado] NVARCHAR(40) DEFAULT 'Activo'
);
GO
/* Relations */
/* Foreign keys for Articulos */
ALTER TABLE [Articulos] ADD CONSTRAINT [ArticulosClase] FOREIGN KEY (id_clase) REFERENCES [Clase] (Id_clase) ON UPDATE CASCADE;
ALTER TABLE [Articulos] ADD CONSTRAINT [ArticulosRubro] FOREIGN KEY (id_rubro) REFERENCES [Rubro] (Id_rubro) ON UPDATE CASCADE;
ALTER TABLE [Articulos] ADD CONSTRAINT [ArticulosStock] FOREIGN KEY (id_articulo) REFERENCES [Stock] (id_Stock);
ALTER TABLE [Articulos] ADD CONSTRAINT [ArticulosUnidades] FOREIGN KEY (id_unidad) REFERENCES [Unidades] (id_unidad);
GO
/* Foreign keys for Clase-Rubro */
ALTER TABLE [Clase-Rubro] ADD CONSTRAINT [ClaseClase-Rubro] FOREIGN KEY (id_clase) REFERENCES [Clase] (Id_clase) ON UPDATE CASCADE;
ALTER TABLE [Clase-Rubro] ADD CONSTRAINT [RubroClase-Rubro] FOREIGN KEY (id_rubro) REFERENCES [Rubro] (Id_rubro) ON UPDATE CASCADE;
GO
/* Foreign keys for Cliente */
ALTER TABLE [Cliente] ADD CONSTRAINT [PersonasCliente] FOREIGN KEY (id_persona) REFERENCES [Personas] (id_persona);
GO
/* Foreign keys for Empleados */
ALTER TABLE [Empleados] ADD CONSTRAINT [PersonasEmpleados] FOREIGN KEY (id_persona) REFERENCES [Personas] (id_persona);
GO
/* Foreign keys for Facturacion */
ALTER TABLE [Facturacion] ADD CONSTRAINT [ArticulosFacturacion] FOREIGN KEY (id_articulo) REFERENCES [Articulos] (id_articulo);
ALTER TABLE [Facturacion] ADD CONSTRAINT [ClienteFacturacion] FOREIGN KEY (id_cliente) REFERENCES [Cliente] (id_cliente);
GO
/* Foreign keys for Ficha de transaccion */
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT [ArticulosFicha de transaccion] FOREIGN KEY (id_articulo) REFERENCES [Articulos] (id_articulo);
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT [FacturacionFicha de transaccion] FOREIGN KEY (id_facturacion) REFERENCES [Facturacion] (id_facturacion);
GO
/* Foreign keys for Personas */
ALTER TABLE [Personas] ADD CONSTRAINT [ProveedorPersonas] FOREIGN KEY (id_persona) REFERENCES [Proveedor] (id_persona);
GO
/* Foreign keys for Proveedor-Articulo */
ALTER TABLE [Proveedor-Articulo] ADD CONSTRAINT [ArticulosProveedor-Articulo] FOREIGN KEY (id_articulo) REFERENCES [Articulos] (id_articulo);
ALTER TABLE [Proveedor-Articulo] ADD CONSTRAINT [ProveedorProveedor-Articulo] FOREIGN KEY (id_proveedor) REFERENCES [Proveedor] (id_proveedor);
GO
/* Foreign keys for Telefonos */
ALTER TABLE [Telefonos] ADD CONSTRAINT [PersonasTelefonos] FOREIGN KEY (id_persona) REFERENCES [Personas] (id_persona);
GO
/* Foreign keys for Usuarios */
ALTER TABLE [Usuarios] ADD CONSTRAINT [EmpleadosUsuarios] FOREIGN KEY (id_empleado) REFERENCES [Empleados] (id_empleado);

/*Restrains*/
/*Triggers*/
/*Stored procedure*/
/*Views*/
CREATE VIEW [Personas_Clientes] AS 
SELECT Cliente.id_cliente, Personas.id_persona, Personas.nombre, Personas.apellido, Personas.dni, Cliente.cuit, Cliente.[condicion IVA], Personas.direccion, Personas.descripcion, Cliente.estado
FROM Personas INNER JOIN Cliente ON Personas.id_persona = Cliente.id_persona;
GO
select * From [Personas_Clientes]
/*Funciones*/