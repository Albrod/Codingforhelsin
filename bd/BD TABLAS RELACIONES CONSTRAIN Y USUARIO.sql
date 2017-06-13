/*User*/ /*EJECUTAR A LO ULTIMO*/
USE [master]
CREATE LOGIN [usuario] WITH PASSWORD=N'malo', DEFAULT_DATABASE=[Comercio], DEFAULT_LANGUAGE=[Español], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
/*asignar el usuario*/ /*es el usuario desde el que vamos a conectar a la BD en la aplicaccion*/
USE [Comercio]
CREATE USER [usuario] FOR LOGIN [usuario]
USE [Comercio]
EXEC sp_addrolemember N'db_owner', N'usuario'
USE [Comercio]
EXEC sp_addrolemember N'db_datareader', N'usuario'
USE [Comercio]
EXEC sp_addrolemember N'db_datawriter', N'usuario'
GO

/*Drop*/
--DROP DATABASE Comercio;
/*DataBase*/
CREATE DATABASE Comercio;
USE Comercio;
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

CREATE TABLE [Unidades] (
[id_unidad] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Clase] (
[id_clase] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[nombre] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Clase-Rubro] (
[id_clase_rubro] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_clase] INT,
[id_rubro] INT,
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Cliente] (
[id_cliente] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT UNIQUE,
[cuit] NVARCHAR(40),
[condicion IVA] NVARCHAR(40), /*CONS FINAL Y MONOTRIBUTISTA (FACTURA B), RESPONSABLE INSCRIPTO (FACTURA A)*/
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Empleados] (
[id_empleado] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT UNIQUE,
[cuil] NVARCHAR(40),
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Facturacion] (
[id_facturacion] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[cod_factura] NVARCHAR(40),
[id_cliente] INTEGER,
[id_articulo] INTEGER,
[tipo iva] NVARCHAR(40), /*Discriminado (FACTURA A), no discriminado o exento (FACTURA B)*/
[iva] INT,  
[tipo factura] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
);

CREATE TABLE [Ficha de transaccion] (
[id_transac] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[tipo] NVARCHAR(40),
[fecha] DATETIME,
[id_articulo] INT,
[cantidad] INT,
[precio x unidad] INT,
[total] INT,
[id_facturacion] INT null,
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
);

CREATE TABLE [Personas] (
[id_persona] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[nombre] NVARCHAR(40),
[apellido] NVARCHAR(40),
[dni] NVARCHAR(40),
[direccion] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
);

CREATE TABLE [Proveedor] (
[id_proveedor] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT UNIQUE,
[cuit] NVARCHAR(40),
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Proveedor-Articulo] (
[id_pro_art] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_proveedor] INT,
[id_articulo] INT,
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Rubro] (
[Id_rubro] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[Nombre] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Stock] (
[id_stock] INT NOT NULL UNIQUE,
[cantidad] INT,
[precio] SMALLMONEY,
[total] INT,
[stock minimo] INT,
[ganancia] INT,
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

CREATE TABLE [Telefonos] (
[id_telefono] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[id_persona] INT,
[numero de telefono] NVARCHAR(40),
[descripcion] NVARCHAR(100) DEFAULT 'Sin Descripcion',
[estado] NVARCHAR(40) DEFAULT 'Activo'
);

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

/* Foreign keys for Clase-Rubro */
ALTER TABLE [Clase-Rubro] ADD CONSTRAINT [ClaseClase-Rubro] FOREIGN KEY (id_clase) REFERENCES [Clase] (Id_clase) ON UPDATE CASCADE;
ALTER TABLE [Clase-Rubro] ADD CONSTRAINT [RubroClase-Rubro] FOREIGN KEY (id_rubro) REFERENCES [Rubro] (Id_rubro) ON UPDATE CASCADE;

/* Foreign keys for Cliente */
ALTER TABLE [Cliente] ADD CONSTRAINT [PersonasCliente] FOREIGN KEY (id_persona) REFERENCES [Personas] (id_persona);

/* Foreign keys for Empleados */
ALTER TABLE [Empleados] ADD CONSTRAINT [PersonasEmpleados] FOREIGN KEY (id_persona) REFERENCES [Personas] (id_persona);

/* Foreign keys for Facturacion */
ALTER TABLE [Facturacion] ADD CONSTRAINT [ArticulosFacturacion] FOREIGN KEY (id_articulo) REFERENCES [Articulos] (id_articulo);
ALTER TABLE [Facturacion] ADD CONSTRAINT [ClienteFacturacion] FOREIGN KEY (id_cliente) REFERENCES [Cliente] (id_cliente);

/* Foreign keys for Ficha de transaccion */
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT [ArticulosFicha de transaccion] FOREIGN KEY (id_articulo) REFERENCES [Articulos] (id_articulo);
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT [FacturacionFicha de transaccion] FOREIGN KEY (id_facturacion) REFERENCES [Facturacion] (id_facturacion);

/* Foreign keys for Personas */
ALTER TABLE [Personas] ADD CONSTRAINT [ProveedorPersonas] FOREIGN KEY (id_persona) REFERENCES [Proveedor] (id_persona);

/* Foreign keys for Proveedor-Articulo */
ALTER TABLE [Proveedor-Articulo] ADD CONSTRAINT [ArticulosProveedor-Articulo] FOREIGN KEY (id_articulo) REFERENCES [Articulos] (id_articulo);
ALTER TABLE [Proveedor-Articulo] ADD CONSTRAINT [ProveedorProveedor-Articulo] FOREIGN KEY (id_proveedor) REFERENCES [Proveedor] (id_proveedor);

/* Foreign keys for Telefonos */
ALTER TABLE [Telefonos] ADD CONSTRAINT [PersonasTelefonos] FOREIGN KEY (id_persona) REFERENCES [Personas] (id_persona);

/* Foreign keys for Usuarios */
ALTER TABLE [Usuarios] ADD CONSTRAINT [EmpleadosUsuarios] FOREIGN KEY (id_empleado) REFERENCES [Empleados] (id_empleado);
GO

/*Restricciones*/
ALTER TABLE Cliente ADD UNIQUE(cuit)
ALTER TABLE Proveedor ADD UNIQUE(cuit)
ALTER TABLE Empleados ADD UNIQUE(cuil)
ALTER TABLE Telefonos ADD UNIQUE([numero de telefono])
ALTER TABLE Stock ADD CONSTRAINT stock_precio_mayor0 CHECK (precio >=0)
ALTER TABLE Stock ADD CONSTRAINT stock_total_mayor0 CHECK (total >=0)
ALTER TABLE Stock ADD CONSTRAINT stock_ganancia_mayor0 CHECK (ganancia >=0)
ALTER TABLE Facturacion ADD CONSTRAINT facturacion_iva_mayor0 CHECK (iva >=0)
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT ficha_cantidad_mayor0 CHECK (cantidad >=0)
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT ficha_total_mayor0 CHECK (total >=0)
ALTER TABLE [Ficha de transaccion] ADD CONSTRAINT ficha_preciox_mayor0 CHECK ([precio x unidad] >=0)
GO