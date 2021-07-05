using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNS_SysInv_X.MVCModel
{
    class Respaldo_BD
    {
        /*OJO RESPALDO DEL 29 DE MAYOOOOOOOOOO
 /////////////////////////TABLAS//////////////////////////
         alter TABLE AuditLog (
    ID int IDENTITY(1,1) PRIMARY KEY,
    usuario varchar(50) NOT NULL,
    fechaInicio datetime NOT NULL,
    fechaSalida datetime NULL
);


ALTER TABLE ROL
ADD bitacora bit NOT NULL

ALTER TABLE ROL (
    ID int IDENTITY(1,1) PRIMARY KEY,
    nombre varchar (30) NOT NULL,
    inventario bit NOT NULL,
    usuarios bit NOT NULL,
    prestamo bit NOT NULL,
    entrega bit NOT NULL,
    roles bit NOT NULL,
    bitacora bit NOT NULL,
);

CREATE TABLE MoviemientosLog(
	ID int IDENTITY(1,1) PRIMARY KEY,
	usuario varchar(50),
	fecha datetime NOT NULL,
	moviemiento varchar(50),
	detalle varchar (100)
)

CREATE TABLE Usuarios(
 usuario varchar(50) PRIMARY KEY,
 clave varchar(50) NOT NULL,
 activo bit NOT NULL,
 rol int NOT NULL,
 nombre varchar(50) NOT NULL,
 apellido varchar(50) NOT NULL,
 correo varchar(50) NOT NULL
)

CREATE TABLE Inventario (
ID int IDENTITY(1,1) PRIMARY KEY,
nombre varchar(50) NOT NULL,
tipo varchar(50) NOT NULL,
serialnumber varchar(50) NOT NULL,
marca varchar(50) NOT NULL,
modelo varchar(50) NOT NULL,
estado varchar(50) NOT NULL,
fechamodificacion datetime NOT NULL,
usuario varchar(50) NOT NULL
)
     
        ////////////////////SP///////////////////////
        ///
USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPRoles]
        @opc int,  @nombre varchar(50)=null,@inventario bit = null, @usuarios bit=null, @prestamo bit = null,
           @entrega bit= null, @roles bit = null, @bitacora bit = null,@oportunidades bit = null,
           @vendedores bit = null, @clientes bit = null, @ID int = null
as
if @opc = 1
begin

    select* from Rol
end

if @opc = 2
begin
    insert into Rol values(@nombre, @inventario, @usuarios, @prestamo, @entrega, @roles, @bitacora, @oportunidades, @vendedores, @clientes)
end

if @opc = 3
begin
    delete from Rol where nombre = @nombre
end

if @opc = 4
begin
    update Rol set nombre=nombre,
	inventario=@inventario, usuarios = @usuarios, prestamo = @prestamo, entrega=@entrega,
	roles=@roles, bitacora=@bitacora, oportunidades=@oportunidades, vendedores=@vendedores, clientes=@clientes where nombre=@nombre
end

if @opc = 5
begin
    select nombre from Rol
end

if @opc = 6
begin
    select A.ID, A.bitacora, A.entrega, A.inventario, A.prestamo, A.roles, A.usuarios, A.oportunidades, A.clientes, A.vendedores from Rol A, Usuarios B where A.ID = b.rol and a.id = @ID
 end
        /////////////////////////////////////////////////////
USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPUsuario]
        @opc int, @usuario varchar(50)=null,@clave varchar(50)=null,@activo int=null, @rol int=null,
	@nombre varchar(50)= null, @apellido varchar(50) = null, @correo varchar(50) = null
as
if @opc = 1
begin

    select* from Usuarios
end

if @opc = 2
begin
    insert into Usuarios values(@usuario, @clave, @activo, @rol, @nombre, @apellido, @correo)
end

if @opc = 3
begin
    delete from Usuarios where usuario = @usuario
end

if @opc = 4
begin
    update Usuarios set usuario=@usuario,clave=@clave,
	activo=@activo,rol=@rol, nombre = @nombre, apellido = @apellido, correo = @correo where usuario=@usuario

end

if @opc = 5
begin


    select* from Usuarios where usuario = @usuario and clave = @clave and activo = 1
	
end

if @opc = 6
begin
    update Usuarios set clave=@clave where usuario=@usuario
end

if @opc = 7
begin

    select* from Usuarios where usuario=@usuario
end


        /////////////////////////////////////////////
     

        ///////////////////////
USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure[dbo].[SPInventario]
        @opc int, @id int= null ,@nombre varchar(50)=null,@tipo varchar(50)=null,@serialnumber varchar(50)=null,@marca varchar(50)=null,
	@modelo varchar(50)= null, @estado varchar(50) = null, @fechamodificacion datetime = null, @usuario varchar(50)= null,
	@ID_Articulo int= null, @ID_Cliente int= null
as
if @opc = 1
begin

    select* from Inventario
end

if @opc = 2
begin
    insert into Inventario values(@nombre, @tipo, @serialnumber, @marca, @modelo, @estado, @fechamodificacion, @usuario)
end

if @opc = 3
begin
    delete from Inventario where id = @id
end

if @opc = 4
begin
    update Inventario set nombre=@nombre,tipo=@tipo,
	serialnumber=@serialnumber,marca=@marca, modelo =@modelo, estado = @estado, fechamodificacion = @fechamodificacion where  id = @id
end

if @opc = 5
begin

    select* from Inventario where estado='Bodega'
end

if @opc = 6
begin
    update Inventario set  estado = 'Prestamo', fechamodificacion = GETDATE() where id = @id
end

if @opc = 7
begin

    insert into Prestamo values(@ID_Articulo, GETDATE(), @ID_Cliente)
end

        $$$$$$$$$$$$$$$$$$$$$4SP entrega

        USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPEntrega]
        @opc int, @ID int=null,@cliente varchar(50)=null,@tipo varchar(50)=null, @numeroDeSerie varchar(50)=null,
	 @marca varchar(50)=null,
	@fecha date = null, @contacto varchar(50) = null, @direccion varchar(50) = null, @cantidad int=null,
	@descripcion varchar(50) = null, @entregadoPor varchar(50)
as
if @opc = 1
begin

    select* from Entrega
end

if @opc = 2
begin
    insert into Entrega values(@cliente, @tipo, @numeroDeSerie, @marca, @fecha, @contacto, @direccion, @cantidad, @descripcion, @entregadoPor)
end

if @opc = 3

begin
    update Entrega set cliente=@cliente,tipo=@tipo,
	numeroDeSerie=@numeroDeSerie,marca=@marca, fecha = @fecha, contacto = @contacto, direccion = @direccion,
	cantidad=@cantidad,descripcion=@descripcion, entregadoPor= @entregadoPor where ID=@ID


end

        %%%%%%%%% SP VENDEDOR
        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure[dbo].[SPVendedor]
        @opc int, @cedula int=null, @nombre varchar(50)=null,@apellido1 varchar(50)=null,@apellido2 varchar(50)=null, 
	@genero varchar(50)=nulll, @fechaNacimiento datetime = null, @correo varchar(100)=null
as
if @opc = 1
begin

    select* from Vendedores
end

if @opc = 2
begin
    insert into Vendedores values(@cedula, @nombre, @apellido1, @apellido2, @genero, @fechaNacimiento, @correo)
end

if @opc = 3
begin
    delete from Vendedores where cedula = @cedula
end

if @opc = 4
begin
    update Vendedores set nombre=@nombre,apellido1=@apellido1,
	apellido2=@apellido2,genero=@genero, fechaNacimiento =@fechaNacimiento, correo = @correo where cedula = @cedula
end
if @opc = 5
begin
    select nombre from Vendedores
end
/////////////OPORTUNIDADES

        USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure[dbo].[SPOportunidades]
        @opc int, @ID int= null, @nombreCliente int=null, @fechaCierre date = null, @marca varchar(50)=null,@detalles varchar(250)=null, 
	@presupuesto int=null, @vendedor int=null
as
if @opc = 1
begin

    select* from Oportunidades
end

if @opc = 2
begin
    insert into Oportunidades values(@nombreCliente, @fechaCierre, @marca, @detalles, @presupuesto, @vendedor)
end

if @opc = 3
begin
    delete from Oportunidades where nombreCliente = @nombreCliente
end

if @opc = 4
begin
    update Oportunidades set nombreCliente=@nombreCliente,fechaCierre=@fechaCierre,
	marca=@marca,detalles=@detalles,presupuesto=@presupuesto, vendedor=@vendedor where ID = @ID


end

        ///////////////////CLIENTES

        USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO


ALTER procedure[dbo].[SPClientes]
        @opc int, @cedula int=null, @tipo varchar(50)=null,@contacto varchar(50)=null,@telefono varchar(50)=null, 
	@correo varchar(50)=null, @direcion varchar(50)=null,@agente int=null,@nombre varchar(50)=null
as
if @opc = 1
begin

    select* from Clientes
end

if @opc = 2
begin
    insert into Clientes values(@cedula, @tipo, @contacto, @telefono, @correo, @direcion, @agente, @nombre)
end

if @opc = 3
begin
    delete from Clientes where cedula = @cedula
end

if @opc = 4
begin
    update Clientes set tipo=@tipo,contacto=@contacto,
	telefono=@telefono,correo=@correo,direcion=@direcion, agente=@agente, nombre=@nombre where cedula = @cedula
end

if @opc = 5
begin
    select nombre from Clientes
end
//////////BITACORA

        USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure[dbo].[SPBitacora]
        @opc int, @id int=null, @usuario varchar(50)=null,@fechainicio date = null, @fechaSalida date=null, @fecha date = null, @movimiento varchar(50)=null,
	@detalle varchar(100)=null
as
if @opc = 1
begin

    select* from AuditLog
end

if @opc = 2
begin
    insert into AuditLog values(@usuario, GETDATE(),NULL)
end

if @opc = 3
begin
    update AuditLog set fechaSalida=GETDATE() where usuario=@usuario and fechaSalida IS null
enD

if @opc = 4
begin

    select* from MovimientosLog
end

if @opc = 5
begin

    insert into MovimientosLog values(@usuario, GETDATE(), @movimiento, @detalle)
end


        ////////////CREAR AUDIT LOG

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[AuditLog](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [usuario] [varchar](50) NOT NULL,

[fechaInicio] [smalldatetime]
        NOT NULL,

[fechaSalida] [smalldatetime]
        NULL,
 CONSTRAINT[PK__AuditLog__3214EC274DB69766] PRIMARY KEY CLUSTERED
(
   [ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

        ///////////// CLIENTES TB
        USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Clientes](
	[cedula]
        [int] NOT NULL,

[tipo] [varchar](50) NOT NULL,

[contacto] [varchar](50) NOT NULL,

[telefono] [varchar](50) NOT NULL,

[correo] [varchar](50) NOT NULL,

[direcion] [varchar](50) NOT NULL,

[agente] [int] NOT NULL,

[nombre] [varchar](50) NOT NULL,
CONSTRAINT[PK__Clientes__415B7BE4B536E3B2] PRIMARY KEY CLUSTERED
(
[cedula] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE[dbo].[Clientes]
        WITH CHECK ADD CONSTRAINT[FK_Clientes_Vendedores] FOREIGN KEY([agente])
REFERENCES[dbo].[Vendedores] ([cedula])
GO

ALTER TABLE[dbo].[Clientes]
        CHECK CONSTRAINT[FK_Clientes_Vendedores]
GO


////////// ENTREGAS TB

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Entrega](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [cliente] [varchar](50) NOT NULL,

[tipo] [varchar](50) NOT NULL,

[numeroDeSerie] [varchar](50) NOT NULL,

[marca] [varchar](50) NOT NULL,

[fecha] [smalldatetime]
        NOT NULL,

[contacto] [varchar](50) NOT NULL,

[direccion] [varchar](50) NOT NULL,

[cantidad] [int] NOT NULL,

[descripcion] [varchar](50) NOT NULL,

[entregadoPor] [varchar](50) NOT NULL,
CONSTRAINT[PK__Entrega__3214EC27420D802E] PRIMARY KEY CLUSTERED
(
[ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

        //////////////// TB INVENTARIO

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Inventario](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [nombre] [varchar](50) NOT NULL,

[tipo] [varchar](50) NOT NULL,

[serialnumber] [varchar](50) NOT NULL,

[marca] [varchar](50) NOT NULL,

[modelo] [varchar](50) NOT NULL,

[estado] [varchar](50) NOT NULL,

[fechamodificacion] [datetime]
        NOT NULL,

[usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED
(
[ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO


        //////////// TB MOVIMIENTOS LOG

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[MovimientosLog](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [usuario] [varchar](50) NULL,
	[fecha]
        [smalldatetime]
        NOT NULL,

    [movimiento] [varchar](50) NULL,
	[detalle]
        [varchar](100) NULL,
 CONSTRAINT[PK__Movimien__3214EC278116BD3F] PRIMARY KEY CLUSTERED
(
   [ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

////////////// TB OPORTUNIDADES

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Oportunidades](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [nombreCliente] [varchar](50) NOT NULL,

[fechaCierre] [smalldatetime]
        NOT NULL,

[marca] [varchar](50) NOT NULL,

[detalles] [varchar](250) NOT NULL,

[presupuesto] [varchar](50) NOT NULL,

[vendedor] [int] NOT NULL,
CONSTRAINT[PK__Oportuni__3214EC270296F853] PRIMARY KEY CLUSTERED
(
[ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE[dbo].[Oportunidades]
        WITH CHECK ADD CONSTRAINT[FK_Oportunidades_Vendedores1] FOREIGN KEY([vendedor])
REFERENCES[dbo].[Vendedores] ([cedula])
GO

ALTER TABLE[dbo].[Oportunidades]
        CHECK CONSTRAINT[FK_Oportunidades_Vendedores1]
GO
/////////// PRESTAMO

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE[dbo].[Prestamo](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [ID_Articulo] [int] NOT NULL,

   [fechaPrestamo] [date]
        NULL,
	[IDCliente]
        [int] NOT NULL,
CONSTRAINT[PK__Prestamo__3214EC2712FA467D] PRIMARY KEY CLUSTERED
(
[ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

ALTER TABLE[dbo].[Prestamo]
        WITH CHECK ADD CONSTRAINT[FK_Prestamo_Clientes] FOREIGN KEY([IDCliente])
REFERENCES[dbo].[Clientes] ([cedula])
GO

ALTER TABLE[dbo].[Prestamo]
        CHECK CONSTRAINT[FK_Prestamo_Clientes]
GO

ALTER TABLE[dbo].[Prestamo]
        WITH CHECK ADD CONSTRAINT[FK_Prestamo_Inventario] FOREIGN KEY([ID_Articulo])
REFERENCES[dbo].[Inventario] ([ID])
GO

ALTER TABLE[dbo].[Prestamo]
        CHECK CONSTRAINT[FK_Prestamo_Inventario]
GO

/////////////////////   ROL

        USE [DB_CNV]
GO
        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Rol](
	[ID]
        [int] IDENTITY(1,1) NOT NULL,

   [nombre] [varchar](30) NOT NULL,

[inventario] [bit]
        NOT NULL,

[usuarios] [bit]
        NOT NULL,

[prestamo] [bit]
        NOT NULL,

[entrega] [bit]
        NOT NULL,

[roles] [bit]
        NOT NULL,

[bitacora] [bit]
        NOT NULL,

[oportunidades] [bit]
        NULL,
	[vendedores]
        [bit]
        NULL,
	[clientes]
        [bit]
        NULL,
PRIMARY KEY CLUSTERED
(
    [ID] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO


////////// TB USUARIOS

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Usuarios](
	[usuario]
        [varchar](50) NOT NULL,

[clave] [varchar](50) NOT NULL,

[activo] [bit]
        NOT NULL,

[rol] [int] NOT NULL,

[nombre] [varchar](50) NOT NULL,

[apellido] [varchar](50) NOT NULL,

[correo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED
(
    [usuario] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE[dbo].[Usuarios]
        WITH CHECK ADD CONSTRAINT[FK_Usuarios_Rol] FOREIGN KEY([rol])
REFERENCES[dbo].[Rol] ([ID])
GO

ALTER TABLE[dbo].[Usuarios]
        CHECK CONSTRAINT[FK_Usuarios_Rol]
GO

        ////////////TB VENDEDORES

        USE [DB_CNV]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Vendedores](
	[cedula]
        [int] NOT NULL,

[nombre] [varchar](50) NOT NULL,

[apellido1] [varchar](50) NOT NULL,

[apellido2] [varchar](50) NOT NULL,

[genero] [varchar](50) NOT NULL,

[fechaNacimiento] [datetime]
        NOT NULL,

[correo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED
(
[cedula] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO










         */
    }
}
