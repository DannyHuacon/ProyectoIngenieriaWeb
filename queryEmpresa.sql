create database EmpresaWeb2
use EmpresaWeb2
go 

CREATE TABLE EmpleadosWEB(
	ID int IDENTITY(1,1) NOT NULL,
	Nombres nvarchar(50) NULL,
	Apellidos nvarchar (50) NULL,
 CONSTRAINT PK_EmpleadosWEB PRIMARY KEY CLUSTERED 
)