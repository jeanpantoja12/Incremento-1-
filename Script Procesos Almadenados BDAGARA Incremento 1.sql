--Proceso Almacenado de AÑADIR



create procedure InsertarCuenta
@Usu varchar(15),
@contra varchar(20)
as
begin
insert into tblCuenta values(@Usu, @contra)
end

EXEC InsertarCuenta 'Usuarioc', 'contra'

create procedure InsertarProducto
@Pronombre varchar(20), 
@ProDesc varchar(40),
@proStock int,
@proPrecio MONEY,
@proMarca varchar(30),
@proMateria varchar(20),
@proTipo varchar(30) 
as 
begin 
declare @Autoincremento int = ((select isnull(MAX(proCodigo),0) from tblProducto)+1) 
insert into tblProducto values(@Autoincremento,@Pronombre,@ProDesc,@proStock,@proPrecio,@proMarca,@proMateria,@proTipo) 
end 

EXEC InsertarProducto 'Camisa Redv','Camisa de cuadros color rojo',12,27.5,'Adidas','Algodón','Camisa' 
select * from tblProducto

create procedure InsertarUsuario
@UsuPedido VARCHAR(15),
@DNI int, 
@Nombre varchar(40),
@ApellidoPaterno VARCHAR(40),
@ApellidoMaterno VARCHAR(40),
@Genero VARCHAR(1),
@Direccion VARCHAR(30),
@Telefono INT
as 
begin 
declare @Usuario varchar(15) = (select Usuario from tblCuenta where Usuario=@UsuPedido)
insert into tblUsuario values(@Usuario,@DNI,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Genero,@Direccion,@Telefono) 
end 

EXEC InsertarUsuario 'Usuarioc',12345678,'Edward','Manuelo','Alvarez','M','Av.JOrgeBorges232',968574248
select * from tblUsuario

create procedure InsertarCompra
@Cliente varchar(15),
@Product int,
@proEstado VARCHAR(8)
as 
begin 
declare @Autoincremento int = ((select isnull(MAX(codCompra),0) from tblDetalleProducto)+1)
declare @Usu varchar(15) = (select Usuario from tblUsuario where usuario=@Cliente)
declare @proCod int = (select proCodigo from tblProducto where proCodigo=@Product)
declare @fechaCompra date = getdate()
declare @horaCompra time = (select convert(char(5), getdate(), 108) as [hh:mm])
insert into tblDetalleProducto values(@Usu,@proCod,@fechaCompra,@horaCompra,@Autoincremento,@proEstado) 
end 

EXEC InsertarCompra 'Usuarioa',5,'Activo'
select * from tblDetalleProducto

--Proceso Almacenado de CONSULTAR


SELECT * FROM tblCuenta;

SELECT * FROM tblUsuario;

SELECT * FROM tblProducto;

SELECT * FROM tblDetalleProducto;


--Proceso Almacenado de MODIFICAR


UPDATE tblCuenta
SET	cuenPass = 'Nueva Contraseña'

UPDATE tblUsuario
SET Usuario = 'Nuevo Usuario',
	DNI = 87654321,
	usuNombre = 'Nuevo Nombre',
	usuGenero = 'N',
	usuDireccion = 'Nueva Direccion',
	usuTelefono = 9785484

UPDATE tblProducto
SET proCodigo = 0880,
	proNombre = 'Nuevo Nombre',
	proDescripcion = 'Nueva Descripción',
	proStock = 2,
	proPrecio = 90.20,
	proMarca = 'Nueva Marca',
	proMaterial = 'Nuevo Material',
	proTipo = 'Nuevo Tipo de Prenda'

UPDATE tblDetalleProducto 
SET	fechaCompra = 06/04/2019,
	horaCompra = 20-26-10,
	codCompra = 0003,
	proEstado = 'Activo'


--Proceso Almacenado de ELIMINAR (Estado Inactivo)


UPDATE tblDetalleProducto 
SET	 proEstado = 'Inactivo'


