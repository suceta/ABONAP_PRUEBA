
-- **********Tema 06)*************

---------TABLA DEPARTAMENTOS)
use ABONAP_DB
GO
INSERT INTO Departamentos 
			(Descripcion, Codigo, Estado, IdSucursal)
	values ('TEGNOLOGIA' , 'DEPTEC00001', 1, 1)
		  ,('NEGOCIOS'   , 'DEPNEG00002', 1, 1)
		  ,('OPERACIONES', 'DEPOPE00001', 1, 1)
GO

---------TABLA EMPRESAS)
INSERT INTO Empresas 
			(Descripcion, Codigo, Estado)
	values ('ABONAP' , 'EMPABO00001', 1)
GO

---------TABLA PERSONAS)
	   
INSERT INTO Personas 
			(Nombres, PrimerApellido, SegundoApellido, Codigo,Estado)
	values ('RONALD' , 'PAULINO', 'ALBERTO', 'PER1508539',1)
		  ,('ALEXANDER'   , 'ALMONTO', 'TINEO', 'PER2098250',1)
		  ,('WILLY CARLOS', 'PORTALATIN', 'OWEN', 'PER5845931',1)
GO

---------TABLA DOCUMENTO)
INSERT INTO Documento 
			(Descripcion, Estado, IdTipoDocumento)
	values ('402-7896247-3' , 1, 2)
		  ,('048-0089654-4' , 1, 2)
		  ,('047-98745960' , 1, 2)
		  ,('005-87598-9' , 0, 1)
GO

---------TABLA TIPODOCUMENTO)
INSERT INTO TipoDocumento 
			(Descripcion, Codigo)
	values ('RNC' , '1')
		  ,('CEDULA' , '2')
		  ,('PASAPORTE' , '3')
GO

---------TABLA SUCURSALES)
INSERT INTO Sucursales 
			(Descripcion, Codigo, Estado, IdEmpresa)
	values ('AVENIDA LIBERTAD' , 'SUC00001', 1,1)
		  ,('16 DE AGOSTO'  , 'SUC00002', 1, 1)
		  ,('SANTIAGO', 'SUC00008', 1, 1)
		  ,('SANTO DOMINGO', 'SUC00009', 1,1)
GO

---------TABLA EMPLEADOS)
INSERT INTO Empleados 
			(Codigo, Estado,IdPersona, IdSucursal)
	values ('EMP00001' ,1, 1,1)
		  ,('EMP00002'  , 1,2, 1)
GO

---------TABLA CLIENTES)
INSERT INTO Clientes 
			(Codigo, Estado,IdPersona, IdSucursal)
	values ('CLI00001' ,1, 1,1)
		  ,('CLI00002'  , 1,2, 1)
GO

---------TABLA PRESTAMOS)
INSERT INTO Prestamos 
			(Codigo, Estado,IdCliente, idSucursal,Monto,FechaCreacion,FechaActualizacion)
	values ('PRES00001' ,'C', 1,1,55000,'2022-02-07','2022-02-07')
		  ,('PRES00002'  , 'A',1, 2,125000,'2022-07-04','2022-07-04')
		  ,('PRES00003'  , 'A',2, 3,235000,'2022-07-07','2022-07-04')
GO

--------------------- procedimiento almacenado TEMA 7)

CREATE PROCEDURE PROC_GET_MONTO_PRESTAMO_CLI 
(
@Codigo varchar(30)
)
AS 
BEGIN
	SELECT p.Monto, n.Nombres, n.PrimerApellido 
		   FROM Prestamos p
		   JOIN Clientes c on c.IdCliente = p.IdCliente
		   JOIN Personas n on n.IdPersona = c.IdPersona
		   WHERE p.Codigo = @Codigo;

END;
go
EXEC PROC_GET_MONTO_PRESTAMO_CLI 'PRES00001';
GO
