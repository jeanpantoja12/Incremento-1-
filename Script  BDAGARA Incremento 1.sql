CREATE DATABASE DBAGARA;

GO

USE DBAGARA;

GO

SET DATEFORMAT DMY

GO


 CREATE TABLE tblCuenta(
 Usuario VARCHAR(15) PRIMARY KEY,
 cuenPass VARCHAR(20) NOT NULL,

 )


CREATE TABLE tblUsuario
(Usuario VARCHAR(15) PRIMARY KEY,
 DNI int NOT NULL,
 usuNombre VARCHAR(20) NOT NULL,
 usuApellidoPaterno VARCHAR(40) NOT NULL,
 usuApellidoMaterno VARCHAR(40) NOT NULL,
 usuGenero VARCHAR(1) NOT NULL,
 usuDireccion VARCHAR(30) NOT NULL,
 usuTelefono INT NOT NULL
 FOREIGN KEY (Usuario) REFERENCES tblCuenta(Usuario)
 );


CREATE TABLE tblProducto
(proCodigo INT PRIMARY KEY,
 proNombre VARCHAR(20) NOT NULL,
 proDescripcion VARCHAR(40) NOT NULL,
 proStock INT,
 proPrecio MONEY NOT NULL,
 proMarca VARCHAR(30) NOT NULL,
 proMaterial VARCHAR(20),
 proTipo VARCHAR(30) NOT NULL,
 );

 CREATE TABLE tblDetalleProducto(
 Usuario VARCHAR(15),
 proCodigo INT,
 fechaCompra date NOT NULL,
 horaCompra time NOT NULL,
 codCompra INT NOT NULL,
 proEstado VARCHAR(8) NOT NULL,
 
 PRIMARY KEY (Usuario, proCodigo),
 FOREIGN KEY(Usuario) REFERENCES tblUsuario(Usuario),
 FOREIGN KEY(proCodigo) REFERENCES tblProducto(proCodigo)
 )
