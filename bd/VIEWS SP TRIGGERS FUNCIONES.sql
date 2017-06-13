USE Comercio
GO

/*Triggers*/
GO

/*Stored procedure*/
GO

/*Views*/
CREATE VIEW [Personas_Clientes] AS 
SELECT Cliente.id_cliente, Personas.id_persona, Personas.nombre, Personas.apellido, Personas.dni, Cliente.cuit, Cliente.[condicion IVA], Personas.direccion, Personas.descripcion, Cliente.estado
FROM Personas INNER JOIN Cliente ON Personas.id_persona = Cliente.id_persona;
GO

select * From [Personas_Clientes]

/*Funciones*/
GO